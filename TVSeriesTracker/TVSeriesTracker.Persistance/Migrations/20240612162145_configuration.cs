using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVSeriesTracker.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterName_LastName",
                table: "Writers",
                newName: "LastnametName");

            migrationBuilder.RenameColumn(
                name: "WriterName_FirstName",
                table: "Writers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_Title",
                table: "Seriess",
                newName: "Tile");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_SourceId",
                table: "Seriess",
                newName: "SourceId");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_Runtime",
                table: "Seriess",
                newName: "Runtime");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_PremiereYear",
                table: "Seriess",
                newName: "PremiereYear");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_Language",
                table: "Seriess",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_Description",
                table: "Seriess",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "SeriesProperies_CountryOfProduction",
                table: "Seriess",
                newName: "CountryOfProduction");

            migrationBuilder.RenameColumn(
                name: "CommentContent_CommentText",
                table: "SeriesComments",
                newName: "CommentContent");

            migrationBuilder.RenameColumn(
                name: "CommentContent_Added",
                table: "SeriesComments",
                newName: "Added");

            migrationBuilder.RenameColumn(
                name: "CommentContent_CommentText",
                table: "MoviesComment",
                newName: "CommentContent");

            migrationBuilder.RenameColumn(
                name: "CommentContent_Added",
                table: "MoviesComment",
                newName: "Added");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_Title",
                table: "Movies",
                newName: "Tile");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_SourceId",
                table: "Movies",
                newName: "SourceId");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_Runtime",
                table: "Movies",
                newName: "Runtime");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_PremiereYear",
                table: "Movies",
                newName: "PremiereYear");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_Language",
                table: "Movies",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_Description",
                table: "Movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "MovieProperties_CountryOfProduction",
                table: "Movies",
                newName: "CountryOfProduction");

            migrationBuilder.RenameColumn(
                name: "DirectorName_LastName",
                table: "Directors",
                newName: "LastnametName");

            migrationBuilder.RenameColumn(
                name: "DirectorName_FirstName",
                table: "Directors",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "Nick",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 70, DateTimeKind.Local).AddTicks(1377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "MoviesComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 57, DateTimeKind.Local).AddTicks(4455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastnametName",
                table: "Writers",
                newName: "WriterName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Writers",
                newName: "WriterName_FirstName");

            migrationBuilder.RenameColumn(
                name: "Tile",
                table: "Seriess",
                newName: "SeriesProperies_Title");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Seriess",
                newName: "SeriesProperies_SourceId");

            migrationBuilder.RenameColumn(
                name: "Runtime",
                table: "Seriess",
                newName: "SeriesProperies_Runtime");

            migrationBuilder.RenameColumn(
                name: "PremiereYear",
                table: "Seriess",
                newName: "SeriesProperies_PremiereYear");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Seriess",
                newName: "SeriesProperies_Language");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Seriess",
                newName: "SeriesProperies_Description");

            migrationBuilder.RenameColumn(
                name: "CountryOfProduction",
                table: "Seriess",
                newName: "SeriesProperies_CountryOfProduction");

            migrationBuilder.RenameColumn(
                name: "CommentContent",
                table: "SeriesComments",
                newName: "CommentContent_CommentText");

            migrationBuilder.RenameColumn(
                name: "Added",
                table: "SeriesComments",
                newName: "CommentContent_Added");

            migrationBuilder.RenameColumn(
                name: "CommentContent",
                table: "MoviesComment",
                newName: "CommentContent_CommentText");

            migrationBuilder.RenameColumn(
                name: "Added",
                table: "MoviesComment",
                newName: "CommentContent_Added");

            migrationBuilder.RenameColumn(
                name: "Tile",
                table: "Movies",
                newName: "MovieProperties_Title");

            migrationBuilder.RenameColumn(
                name: "SourceId",
                table: "Movies",
                newName: "MovieProperties_SourceId");

            migrationBuilder.RenameColumn(
                name: "Runtime",
                table: "Movies",
                newName: "MovieProperties_Runtime");

            migrationBuilder.RenameColumn(
                name: "PremiereYear",
                table: "Movies",
                newName: "MovieProperties_PremiereYear");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "Movies",
                newName: "MovieProperties_Language");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "MovieProperties_Description");

            migrationBuilder.RenameColumn(
                name: "CountryOfProduction",
                table: "Movies",
                newName: "MovieProperties_CountryOfProduction");

            migrationBuilder.RenameColumn(
                name: "LastnametName",
                table: "Directors",
                newName: "DirectorName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Directors",
                newName: "DirectorName_FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "Nick",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentContent_Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 70, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommentContent_Added",
                table: "MoviesComment",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 21, 45, 57, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 11, 20, 18, 34, 180, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 6, 11, 20, 18, 34, 180, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 6, 11, 20, 18, 34, 180, DateTimeKind.Local).AddTicks(2155));
        }
    }
}
