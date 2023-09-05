using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemoApp.Migrations
{
    /// <inheritdoc />
    public partial class CustomerSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customers",
                columns: new[] { "Id", "ContactNo", "Name" },
                values: new object[,]
                {
                    { 1L, "6543210", "Michael Curry" },
                    { 2L, "0654321", "Stephen Jordan" },
                    { 3L, "1065432", "Kobe Durant" },
                    { 4L, "2106543", "Kevin Bryant" },
                    { 5L, "3210654", "Derrick Nowitzki" },
                    { 6L, "4321065", "Dirk Rose" },
                    { 7L, "5432106", "Jordan Green" },
                    { 8L, "1234560", "Jeff Clarkson" },
                    { 9L, "234501", "Ben Tatum" },
                    { 10L, "345012", "Jason Simmons" },
                    { 11L, "450123", "Luka Kidd" },
                    { 12L, "501234", "Jason Doncic" },
                    { 13L, "01235", "Kyrie George" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "customers",
                keyColumn: "Id",
                keyValue: 13L);
        }
    }
}
