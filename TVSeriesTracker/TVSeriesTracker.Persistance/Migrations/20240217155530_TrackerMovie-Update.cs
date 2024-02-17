using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TVSeriesTracker.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class TrackerMovieUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Movies_MovieId",
                table: "TrackedMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Trackers_TrackerId",
                table: "TrackedMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Users_UserId",
                table: "TrackedMovies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "TrackedMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TrackerId",
                table: "TrackedMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "TrackedMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Movies_MovieId",
                table: "TrackedMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Trackers_TrackerId",
                table: "TrackedMovies",
                column: "TrackerId",
                principalTable: "Trackers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Users_UserId",
                table: "TrackedMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Movies_MovieId",
                table: "TrackedMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Trackers_TrackerId",
                table: "TrackedMovies");

            migrationBuilder.DropForeignKey(
                name: "FK_TrackedMovies_Users_UserId",
                table: "TrackedMovies");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "TrackedMovies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TrackerId",
                table: "TrackedMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "TrackedMovies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Movies_MovieId",
                table: "TrackedMovies",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Trackers_TrackerId",
                table: "TrackedMovies",
                column: "TrackerId",
                principalTable: "Trackers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrackedMovies_Users_UserId",
                table: "TrackedMovies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
