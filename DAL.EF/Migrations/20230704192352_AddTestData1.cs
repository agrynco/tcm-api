using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddTestData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrainComponents",
                columns: new[] { "Id", "CanAssignQuantity", "Name", "Number" },
                values: new object[,]
                {
                    { 20, false, "Flooring", "FLR456" },
                    { 21, true, "Mirror", "MRR789" },
                    { 22, false, "Horn", "HRN321" },
                    { 23, false, "Coupler", "CPL654" },
                    { 24, true, "Hinge", "HNG987" },
                    { 25, true, "Ladder", "LDR456" },
                    { 26, false, "Paint", "PNT789" },
                    { 27, true, "Decal", "DCL321" },
                    { 28, true, "Gauge", "GGS654" },
                    { 29, false, "Battery", "BTR987" },
                    { 30, false, "Radiator", "RDR456" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
