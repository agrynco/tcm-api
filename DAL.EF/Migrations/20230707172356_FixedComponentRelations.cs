using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.EF.Migrations
{
    /// <inheritdoc />
    public partial class FixedComponentRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrainComponentParentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrainComponentParentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrainComponentParentId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 2,
                column: "TrainComponentParentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 3,
                column: "TrainComponentParentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TrainComponentRelations",
                keyColumn: "Id",
                keyValue: 4,
                column: "TrainComponentParentId",
                value: 1);
        }
    }
}
