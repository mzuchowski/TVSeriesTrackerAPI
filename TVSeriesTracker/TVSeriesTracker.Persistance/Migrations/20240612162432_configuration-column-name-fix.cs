using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVSeriesTracker.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configurationcolumnnamefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastnametName",
                table: "Writers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "LastnametName",
                table: "Directors",
                newName: "LastName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 884, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 70, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "MoviesComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 871, DateTimeKind.Local).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 57, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 24, 31, 900, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 24, 31, 900, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 24, 31, 900, DateTimeKind.Local).AddTicks(5981));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Writers",
                newName: "LastnametName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Directors",
                newName: "LastnametName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 70, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 884, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "MoviesComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 57, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 871, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 21, 45, 98, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 21, 45, 98, DateTimeKind.Local).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 6, 12, 18, 21, 45, 98, DateTimeKind.Local).AddTicks(2209));
        }
    }
}
