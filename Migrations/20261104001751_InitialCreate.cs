using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace listAndDetails.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Generation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Developer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Developer", "Generation", "Platform", "Region", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "The first Pokemon games released in Japan.", "Game Freak", "1", "Game Boy", "Kanto", new DateTime(1996, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Red and Green" },
                    { 2, "An updated version of Pokemon Red and Green released in Japan.", "Game Freak", "1", "Game Boy", "Kanto", new DateTime(1996, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Blue" },
                    { 3, "A special edition of Pokemon Red and Blue featuring Pikachu as the starter Pokemon.", "Game Freak", "1", "Game Boy", "Kanto", new DateTime(1998, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Yellow" },
                    { 4, "The second generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "2", "Game Boy Color", "Johto", new DateTime(1999, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Gold and Silver" },
                    { 5, "An updated version of Pokemon Gold and Silver with additional features.", "Game Freak", "2", "Game Boy Color", "Johto", new DateTime(2000, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Crystal" },
                    { 6, "The third generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "3", "Game Boy Advance", "Hoenn", new DateTime(2002, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Ruby and Sapphire" },
                    { 7, "An updated version of Pokemon Ruby and Sapphire with additional features.", "Game Freak", "3", "Game Boy Advance", "Hoenn", new DateTime(2004, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Emerald" },
                    { 8, "The fourth generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "4", "Nintendo DS", "Sinnoh", new DateTime(2006, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Diamond and Pearl" },
                    { 9, "An updated version of Pokemon Diamond and Pearl with additional features.", "Game Freak", "4", "Nintendo DS", "Sinnoh", new DateTime(2008, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Platinum" },
                    { 10, "The fifth generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "5", "Nintendo DS", "Unova", new DateTime(2010, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Black and White" },
                    { 11, "An updated version of Pokemon Black and White with additional features.", "Game Freak", "5", "Nintendo DS", "Unova", new DateTime(2012, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Black 2 and White 2" },
                    { 12, "The sixth generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "6", "Nintendo 3DS", "Kalos", new DateTime(2013, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon X and Y" },
                    { 13, "An updated version of Pokemon Ruby and Sapphire with additional features.", "Game Freak", "6", "Nintendo 3DS", "Hoenn", new DateTime(2014, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Omega Ruby and Alpha Sapphire" },
                    { 14, "The seventh generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "7", "Nintendo 3DS", "Alola", new DateTime(2016, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Sun and Moon" },
                    { 15, "An updated version of Pokemon Sun and Moon with additional features.", "Game Freak", "7", "Nintendo 3DS", "Alola", new DateTime(2017, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Ultra Sun and Ultra Moon" },
                    { 16, "A reimagining of Pokemon Yellow with updated graphics and gameplay.", "Game Freak", "7", "Nintendo Switch", "Kanto", new DateTime(2018, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Let's Go, Pikachu! and Let's Go, Eevee!" },
                    { 17, "The eighth generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "8", "Nintendo Switch", "Galar", new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Sword and Shield" },
                    { 18, "A remaster of Pokemon Diamond and Pearl with updated graphics and gameplay.", "ILCA", "8", "Nintendo Switch", "Sinnoh", new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Brilliant Diamond and Shining Pearl" },
                    { 19, "A prequel to Pokemon Diamond and Pearl set in the Hisui region.", "Game Freak", "8", "Nintendo Switch", "Hisui", new DateTime(2022, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Legends: Arceus" },
                    { 20, "The ninth generation of Pokemon games introducing new Pokemon and features.", "Game Freak", "9", "Nintendo Switch", "Paldea", new DateTime(2022, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Scarlet and Violet" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
