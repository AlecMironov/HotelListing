using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
	public class DatabaseContext : IdentityDbContext<ApiUser>
	{
		public DatabaseContext(DbContextOptions options)
			: base(options)
		{ 
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<Country>().HasData(
				new Country
				{
					Id = 1,
					Name = "Jamaica",
					ShortName = "JM"
				},
				new Country
				{
					Id = 2,
					Name = "Bahamas",
					ShortName = "BS"
				},
				new Country
				{
					Id = 3,
					Name = "Cayman Island",
					ShortName = "CI"
				}
			);

			builder.Entity<Hotel>().HasData(
				new Hotel
				{
					Id = 1,
					Name = "Sandals Resorts and Spa",
					Address = "Negril",
					CountryId = 1,
					Raiting = 4.5
				},
				new Hotel
				{
					Id = 2,
					Name = "Comfort Suites",
					Address = "George Town",
					CountryId = 3,
					Raiting = 4.3
				},
				new Hotel
				{
					Id = 3,
					Name = "Grand Palladium",
					Address = "Nassau",
					CountryId = 2,
					Raiting = 4.0
				}
			);
		}

		public DbSet<Country> Countries { get; set; }

		public DbSet<Hotel> Hotels { get; set; }
	}
}
