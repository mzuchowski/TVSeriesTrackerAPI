using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVSeriesTracker.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class DirectorEntityUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesComment_Movies_MovieId",
                table: "MoviesComment");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesComment_Users_UserId",
                table: "MoviesComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesComment",
                table: "MoviesComment");

            migrationBuilder.RenameTable(
                name: "MoviesComment",
                newName: "MoviesComments");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesComment_UserId",
                table: "MoviesComments",
                newName: "IX_MoviesComments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesComment_MovieId",
                table: "MoviesComments",
                newName: "IX_MoviesComments_MovieId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 17, 16, 7, 47, 318, DateTimeKind.Local).AddTicks(3003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 884, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "MoviesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 11, 17, 16, 7, 47, 307, DateTimeKind.Local).AddTicks(7472),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 871, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesComments",
                table: "MoviesComments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DirectorBiographies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectorId = table.Column<int>(type: "int", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    InactivatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactivated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorBiographies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DirectorBiographies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 11, 17, 16, 7, 47, 343, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 11, 17, 16, 7, 47, 343, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 11, 17, 16, 7, 47, 343, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.CreateIndex(
                name: "IX_DirectorBiographies_DirectorId",
                table: "DirectorBiographies",
                column: "DirectorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesComments_Movies_MovieId",
                table: "MoviesComments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesComments_Users_UserId",
                table: "MoviesComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesComments_Movies_MovieId",
                table: "MoviesComments");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesComments_Users_UserId",
                table: "MoviesComments");

            migrationBuilder.DropTable(
                name: "DirectorBiographies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesComments",
                table: "MoviesComments");

            migrationBuilder.RenameTable(
                name: "MoviesComments",
                newName: "MoviesComment");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesComments_UserId",
                table: "MoviesComment",
                newName: "IX_MoviesComment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MoviesComments_MovieId",
                table: "MoviesComment",
                newName: "IX_MoviesComment_MovieId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "SeriesComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 884, DateTimeKind.Local).AddTicks(290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 17, 16, 7, 47, 318, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added",
                table: "MoviesComment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 6, 12, 18, 24, 31, 871, DateTimeKind.Local).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 11, 17, 16, 7, 47, 307, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesComment",
                table: "MoviesComment",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesComment_Movies_MovieId",
                table: "MoviesComment",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesComment_Users_UserId",
                table: "MoviesComment",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
