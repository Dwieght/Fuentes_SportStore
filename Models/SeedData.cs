using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace Fuentes_SportsStore.Models
{
	public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			StoreDbContext context = app.ApplicationServices
				.CreateScope().ServiceProvider
				.GetRequiredService<StoreDbContext>();

			if(context.Database.GetPendingMigrations().Any()) 
			{
				context.Database.Migrate();
			}
			if(!context.Products.Any()) 
			{
				context.Products.AddRange(
				new Product
				{
					Name = "Kayak",
					Description = "A boat for one person",
					Category = "Watersports",
					Price = 275
				},
				new Product
				{
					Name = "Life Jacket",
					Description = "Protective and Fashionable",
					Category = "Watersports",
					Price = 49.95m
				},
				new Product
				{
					Name = "Soccerball",
					Description = "FIFA-approved size and weight",
					Category = "Soccer",
					Price = 19.50m
				},
				new Product
				{
					Name = "Corner Flags",
					Description = "Give your playing field a professional touch",
					Category = "Soccer",
					Price = 34.95m
				},
				new Product
				{
					Name = "Bling-Bling King",
					Description = "Gold-plated",
					Category = "Chess",
					Price = 1325
				},
				new Product
				{
					Name = "Bling-Bling Queen",
					Description = "Gold-plated",
					Category = "Chess",
					Price = 1225
				}
				);
				context.SaveChanges();
			}
		}
	}
}
