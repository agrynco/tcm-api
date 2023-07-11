using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedSomeTrainComponentRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrainComponentRelations",
                columns: new[] { "Id", "ContextId", "Quantity", "TrainComponentId", "TrainComponentParentId" },
                values: new object[,]
                {
                    { 1, 1, null, 2, null },
                    { 2, 1, 4, 4, 1 },
                    { 3, 1, 4, 7, 1 },
                    { 4, 1, 1, 8, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
