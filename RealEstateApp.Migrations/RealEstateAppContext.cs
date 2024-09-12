using Microsoft.EntityFrameworkCore;
using RealEstateApp.Model.Data;

namespace RealEstateApp.Migrations
{
	public class RealEstateAppContext : DbContext
	{
		public RealEstateAppContext(DbContextOptions<RealEstateAppContext> options) : base(options) { }

		DbSet<User> Users { get; set; }
		DbSet<Rent> Rents { get; set; }
		DbSet<RentLog> RentLogs { get; set; }
		DbSet<Purchase> Purchases { get; set; }
		DbSet<PurchaseLog> PurchaseLogs { get; set; }
		DbSet<Picture> Pictures { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
