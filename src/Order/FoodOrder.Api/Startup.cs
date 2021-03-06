using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Reflection;
using FoodOrder.Business.Command;
using FoodOrder.Business.Services;
using FoodOrder.Data.SqlServer;
using FoodOrder.Data.SqlServer.Repository;
using FoodOrder.Domain.Entity.ClientAggregate;
using FoodOrder.Domain.Entity.OrderAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using MassTransit;
using MassTransit.EntityFrameworkCoreIntegration;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FoodOrder.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FoodOrder.Api", Version = "v1" });
            });
            services.AddDbContext<OrderingContext>(options => {
                options.UseSqlServer(Configuration["ConnectionString"],
                    sqlServerOptionsAction: sqlOptions => {
                        sqlOptions.MigrationsAssembly(typeof(OrderingContext).GetTypeInfo().Assembly.GetName().Name);
                        sqlOptions.EnableRetryOnFailure(maxRetryCount: 15, maxRetryDelay: TimeSpan.FromSeconds(30), errorNumbersToAdd: null);
                    });
            });
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IRestaurantRepository, RestaurantRepository>();
            services.AddMediatR(typeof(CreateOrdersCommand));

            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, cfg) => {
                    cfg.ConfigureEndpoints(context);
                });
                x.AddSagaStateMachine<OrderProcessorStateMachine, ProcessingOrderState>()
                    .EntityFrameworkRepository(r => {
                        r.ConcurrencyMode = ConcurrencyMode.Optimistic;

                        r.AddDbContext<DbContext, OrderStateDbContext>((provider, builder) => {
                            builder.UseSqlServer(Configuration["ConnectionString"], m => {
                                m.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name);
                                m.MigrationsHistoryTable($"__{nameof(OrderStateDbContext)}");
                            });
                        });
                    });
            });
            services.AddMassTransitHostedService();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FoodOrder.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
        }
    }
}
