using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class FixedComponentRelations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 6,
                column: "TrainComponentParentId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 7,
                column: "TrainComponentParentId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 6,
                column: "TrainComponentParentId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 7,
                column: "TrainComponentParentId",
                value: 5);
        }
    }
}
