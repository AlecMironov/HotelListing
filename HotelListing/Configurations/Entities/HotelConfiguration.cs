using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
	public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
	{
		public void Configure(EntityTypeBuilder<Hotel> builder)
		{
			builder.HasData(
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
	}
}
