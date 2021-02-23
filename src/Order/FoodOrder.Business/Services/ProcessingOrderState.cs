using System;
using System.Collections.Generic;
using Automatonymous;
using FoodOrder.Shared.Models.Models;
using MassTransit.EntityFrameworkCoreIntegration;
using MassTransit.EntityFrameworkCoreIntegration.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodOrder.Business.Services
{
    public class ProcessingOrderState : SagaStateMachineInstance
    {
        public ProcessingOrderState(Guid correlationId)
        {
            this.CorrelationId = correlationId;
        }
        public Order Order { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid CorrelationId { get; set; }

        public string State { get; set; }
        public byte[] RowVersion { get; set; }
    }

    public class OrderStateMap :
        SagaClassMap<ProcessingOrderState>
    {
        protected override void Configure(EntityTypeBuilder<ProcessingOrderState> entity, ModelBuilder model)
        {
            entity.Property(x => x.State).HasMaxLength(64);
            entity.Property(x => x.Created);
            entity.Property(x => x.Updated);
            entity.Property(x => x.RowVersion).IsRowVersion();
            entity.OwnsOne(x => x.Order);
            entity.Property(x => x.RowVersion).IsRowVersion();
        }
    }

    public class OrderStateDbContext :
        SagaDbContext
    {
        public OrderStateDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override IEnumerable<ISagaClassMap> Configurations {
            get { yield return new OrderStateMap(); }
        }
    }
}