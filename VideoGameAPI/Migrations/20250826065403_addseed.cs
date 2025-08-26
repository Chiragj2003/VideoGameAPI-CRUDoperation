using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class addseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 6, "Epic Games", "PC, Console, Mobile", "Epic Games", "Fortnite" },
                    { 7, "Innersloth", "PC, Mobile, Console", "Innersloth", "Among Us" },
                    { 8, "Nintendo", "Nintendo Switch", "Nintendo", "Animal Crossing: New Horizons" },
                    { 9, "FromSoftware", "PC, PlayStation, Xbox", "Bandai Namco", "Elden Ring" },
                    { 10, "Supergiant Games", "PC, Console", "Supergiant Games", "Hades" },
                    { 11, "Nintendo", "Nintendo Switch", "Nintendo", "Super Mario Odyssey" },
                    { 12, "Respawn Entertainment", "PC, Console", "Electronic Arts", "Apex Legends" },
                    { 13, "Infinity Ward", "PC, Console", "Activision", "Call of Duty: Modern Warfare II" },
                    { 14, "Portkey Games", "PC, Console", "Warner Bros. Games", "Hogwarts Legacy" },
                    { 15, "EA Sports", "PC, Console", "Electronic Arts", "FIFA 23" },
                    { 16, "Capcom", "PC, Console", "Capcom", "Resident Evil 4 Remake" },
                    { 17, "Insomniac Games", "PlayStation", "Sony Interactive Entertainment", "Marvel's Spider-Man" },
                    { 18, "ConcernedApe", "PC, Console, Mobile", "ConcernedApe", "Stardew Valley" },
                    { 19, "Riot Games", "PC", "Riot Games", "League of Legends" },
                    { 20, "Riot Games", "PC", "Riot Games", "Valorant" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
