using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VideoGames",
                columns: new[] { "Id", "Developer", "Platform", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Nintendo", "Nintendo Switch", "Nintendo", "The Legend of Zelda: Breath of the Wild" },
                    { 2, "Santa Monica Studio", "PlayStation 4", "Sony Interactive Entertainment", "God of War" },
                    { 3, "Rockstar Games", "PlayStation 4, Xbox One, PC", "Rockstar Games", "Red Dead Redemption 2" },
                    { 4, "CD Projekt Red", "PlayStation 4, Xbox One, PC, Nintendo Switch", "CD Projekt", "The Witcher 3: Wild Hunt" },
                    { 5, "Mojang Studios", "PC, Console, Mobile", "Mojang Studios", "Minecraft" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VideoGames",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
