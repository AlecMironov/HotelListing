using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
	public partial class AddedDefaultRoles : Migration
	{
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.InsertData(
				table: "AspNetRoles",
				columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
				values: new object[] { "ff6fe652-1ca9-4f12-9ca0-3e2fb1d009f9", "d5221c10-7dff-479b-8401-058f936532f3", "User", "USER" });

			migrationBuilder.InsertData(
				table: "AspNetRoles",
				columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
				values: new object[] { "9909b81a-046b-4333-be7e-744e16818830", "77b8ee43-6aa0-4383-8b69-d37b1ccfb8ba", "Administrator", "ADMINISTRATOR" });
		}

		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DeleteData(
				table: "AspNetRoles",
				keyColumn: "Id",
				keyValue: "9909b81a-046b-4333-be7e-744e16818830");

			migrationBuilder.DeleteData(
				table: "AspNetRoles",
				keyColumn: "Id",
				keyValue: "ff6fe652-1ca9-4f12-9ca0-3e2fb1d009f9");
		}
	}
}
