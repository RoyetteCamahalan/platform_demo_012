using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatformDemoApp.Migrations
{
    /// <inheritdoc />
    public partial class OrderSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "Amount", "CustomerId", "OrderNo" },
                values: new object[,]
                {
                    { 1L, 100m, 1L, "001" },
                    { 2L, 200m, 1L, "002" },
                    { 3L, 300m, 1L, "003" },
                    { 4L, 400m, 1L, "004" },
                    { 5L, 500m, 2L, "005" },
                    { 6L, 600m, 2L, "006" },
                    { 7L, 700m, 3L, "007" },
                    { 8L, 800m, 3L, "008" },
                    { 9L, 900m, 3L, "009" },
                    { 10L, 1000m, 4L, "010" },
                    { 11L, 1100m, 4L, "011" },
                    { 12L, 1200m, 5L, "012" },
                    { 13L, 1300m, 5L, "013" },
                    { 14L, 1400m, 8L, "014" },
                    { 15L, 1500m, 8L, "015" },
                    { 16L, 1600m, 11L, "016" },
                    { 17L, 1700m, 11L, "017" },
                    { 18L, 1800m, 12L, "018" },
                    { 19L, 1900m, 13L, "019" },
                    { 20L, 2000m, 6L, "020" },
                    { 21L, 2100m, 6L, "021" },
                    { 22L, 2200m, 6L, "022" },
                    { 23L, 2300m, 6L, "023" },
                    { 24L, 2400m, 6L, "024" },
                    { 25L, 2500m, 6L, "025" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 25L);
        }
    }
}
