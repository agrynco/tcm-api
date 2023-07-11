using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreTrainComponentRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TrainComponentRelations",
                columns: new[] { "Id", "ContextId", "Quantity", "TrainComponentId", "TrainComponentParentId" },
                values: new object[,]
                {
                    { 5, 1, null, 3, null },
                    { 6, 1, 1, 18, 5 },
                    { 7, 1, 1, 19, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
