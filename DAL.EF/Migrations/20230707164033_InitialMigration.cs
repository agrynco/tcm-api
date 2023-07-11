using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainComponentContexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainComponentContexts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainComponentRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ContextId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    TrainComponentId = table.Column<int>(type: "int", nullable: false),
                    TrainComponentParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainComponentRelations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrainComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CanAssignQuantity = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainComponents", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "TrainComponentContexts",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Main" });

            migrationBuilder.InsertData(
                table: "TrainComponents",
                columns: new[] { "Id", "CanAssignQuantity", "Name", "Number" },
                values: new object[,]
                {
                    { 1, false, "Engine", "ENG123" },
                    { 2, false, "Passenger Car", "PAS456" },
                    { 3, false, "Freight Car", "FRT789" },
                    { 4, true, "Wheel", "WHL101" },
                    { 5, true, "Seat", "STS234" },
                    { 6, true, "Window", "WIN567" },
                    { 7, true, "Door", "DR123" },
                    { 8, true, "Control Panel", "CTL987" },
                    { 9, true, "Light", "LGT456" },
                    { 10, true, "Brake", "BRK789" },
                    { 11, true, "Bolt", "BLT321" },
                    { 12, true, "Nut", "NUT654" },
                    { 13, false, "Engine Hood", "EH789" },
                    { 14, false, "Axle", "AX456" },
                    { 15, false, "Piston", "PST789" },
                    { 16, true, "Handrail", "HND234" },
                    { 17, true, "Step", "STP567" },
                    { 18, false, "Roof", "RF123" },
                    { 19, false, "Air Conditioner", "AC789" },
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

            migrationBuilder.CreateIndex(
                name: "IX_TrainComponentContexts_Name",
                table: "TrainComponentContexts",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainComponentRelations_Id_TrainComponentId_TrainComponentPa~",
                table: "TrainComponentRelations",
                columns: new[] { "Id", "TrainComponentId", "TrainComponentParentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainComponents_Name",
                table: "TrainComponents",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TrainComponents_Number",
                table: "TrainComponents",
                column: "Number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainComponentContexts");

            migrationBuilder.DropTable(
                name: "TrainComponentRelations");

            migrationBuilder.DropTable(
                name: "TrainComponents");
        }
    }
}
