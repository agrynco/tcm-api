using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "TrainComponents");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TrainComponents");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TrainComponentRelations");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TrainComponentRelations");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "TrainComponentContexts");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "TrainComponentContexts");

            migrationBuilder.InsertData(
                table: "TrainComponentContexts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Main" });

            migrationBuilder.InsertData(
                table: "TrainComponents",
                columns: new[] { "Id", "CanAssignQuantity", "Name", "Number" },
                values: new object[,]
                {
                    { 1, false, "EngineNumber", "ENG123" },
                    { 2, false, "Passenger CarNumber", "PAS456" },
                    { 3, false, "Freight CarNumber", "FRT789" },
                    { 4, true, "WheelNumber", "WHL101" },
                    { 5, true, "SeatNumber", "STS234" },
                    { 6, true, "WindowNumber", "WIN567" },
                    { 7, true, "DoorNumber", "DR123" },
                    { 8, true, "Control PanelNumber", "CTL987" },
                    { 9, true, "LightNumber", "LGT456" },
                    { 10, true, "BrakeNumber", "BRK789" },
                    { 11, true, "BoltNumber", "BLT321" },
                    { 12, true, "NutNumber", "NUT654" },
                    { 13, false, "Engine HoodNumber", "EH789" },
                    { 14, false, "AxleNumber", "AX456" },
                    { 15, false, "PistonNumber", "PST789" },
                    { 16, true, "HandrailNumber", "HND234" },
                    { 17, true, "StepNumber", "STP567" },
                    { 18, false, "RoofNumber", "RF123" },
                    { 19, false, "Air ConditionerNumber", "AC789" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainComponentContexts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TrainComponents",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TrainComponents",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "TrainComponents",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TrainComponentRelations",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "TrainComponentRelations",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TrainComponentContexts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "TrainComponentContexts",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
