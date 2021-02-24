using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using FoodOrder.Domain.Entity;
using FoodOrder.Domain.Entity.ClientAggregate;
using FoodOrder.Domain.Entity.RestaurantAggregate;
using JsonNet.ContractResolvers;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace FoodOrder.Data.SqlServer
{
    public static class ModelBuilderExtensions
    {
        private const string InitialRestaurantFileName = "SampleData.json";
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Restaurant
            var assembly = typeof(ModelBuilderExtensions).GetTypeInfo().Assembly;
            var resourceNames = assembly.GetManifestResourceNames()
                .Where(x => x.EndsWith(InitialRestaurantFileName, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (resourceNames.Count == 0)
                throw new Exception($"Unable to locate embedded resource '{InitialRestaurantFileName}'.");
            if (resourceNames.Count > 1)
                throw new Exception($"Multiple resources with name '{InitialRestaurantFileName}'");

            using var resourceStream = assembly.GetManifestResourceStream(resourceNames.Single())
                   ?? throw new Exception("Resource stream was null");
            using var reader = new StreamReader(resourceStream, Encoding.UTF8);
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new PrivateSetterContractResolver()
            };
            var restaurants = JsonConvert.DeserializeObject<ICollection<Restaurant>>(reader.ReadToEnd(), settings);
            if (restaurants != null && restaurants.Any()) {
                var categories = new List<Category>();
                var menuItems = new List<MenuItem>();
                var categoryInitialId = 1;
                foreach (var restaurant in restaurants) {
                    if (restaurant.Categories.Any()) {
                        foreach (var restaurantCategory in restaurant.Categories) {
                            restaurantCategory.SetPrivatePropertyValue(nameof(Category.RestaurantId), restaurant.Id);
                            restaurantCategory.SetProperty(nameof(Entity.Id), categoryInitialId);
                            categories.Add(restaurantCategory);
                            if (restaurantCategory.MenuItems.Any()) {
                                foreach (var restaurantCategoryMenuItem in restaurantCategory.MenuItems) {
                                    restaurantCategoryMenuItem.SetPrivatePropertyValue(nameof(MenuItem.CategoryId), categoryInitialId);
                                    menuItems.Add(restaurantCategoryMenuItem);
                                }
                                restaurantCategory.MenuItems.Clear();
                            }

                            categoryInitialId++;
                        }
                        restaurant.Categories.Clear();
                    }
                }
                modelBuilder.Entity<Restaurant>().HasData(restaurants);
                modelBuilder.Entity<Category>().HasData(categories);
                modelBuilder.Entity<MenuItem>().HasData(menuItems);
            }


            #endregion

            #region Client
            modelBuilder.Entity<Client>().HasData(new { Id = 1, Name = "Test1" }, new { Id = 2, Name = "Test2" });
            #endregion
        }

        private static void SetPrivatePropertyValue<T>(this object obj, string propName, T val)
        {
            var t = obj.GetType();
            if (t.GetProperty(propName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance) == null)
                throw new ArgumentOutOfRangeException("propName", string.Format("Property {0} was not found in Type {1}", propName, obj.GetType().FullName));
            t.InvokeMember(propName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty | BindingFlags.Instance, null, obj, new object[] { val });
        }
        public static void SetProperty<T>(this object instance, string propertyName, T val)
        {
            var type = instance.GetType();
            var prop = type?.BaseType?.GetProperty(propertyName);
            prop?.SetValue(instance, val, null);
        }
    }
}