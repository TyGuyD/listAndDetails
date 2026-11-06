using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace listAndDetails.Migrations
{
    /// <inheritdoc />
    public partial class PopulateReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Reviews",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "GameId", "Rating", "ReviewerName" },
                values: new object[,]
                {
                    { 1, "Good. Gorgeous details, but it has too much water.", 13, 7.7999999999999998, "IGN" },
                    { 2, "These games have stood the test of time beautifully. Likely the best games in the series!", 10, 9.5, "Tyler" },
                    { 3, "A familiar but enjoyable adventure. Emerald offers plenty of content, although much of it feels recycled from Ruby and Sapphire.", 7, 7.5, "GameSpot" },
                    { 4, "An excellent enhanced version of Diamond and Pearl, with meaningful improvements and plenty of additional content.", 9, 9.0, "Nintendo Life" },
                    { 5, "An outstanding sequel that builds on its predecessors with an expanded world, new features, and an impressive amount of content.", 11, 9.5999999999999996, "IGN" },
                    { 6, "The familiar battling remains enjoyable, but the story and some of the new additions don't quite reach the same heights.", 11, 6.5, "GameSpot" },
                    { 7, "A colorful and enjoyable return to Hoenn, with improved visuals, Mega Evolution, and plenty of multiplayer possibilities.", 13, 8.0, "GameSpot" },
                    { 8, "A fantastic remake that brings Hoenn to life with impressive visuals and worthwhile additions.", 13, 9.0, "Nintendo Life" },
                    { 9, "A refreshing generation that reexamines familiar mechanics and introduces some of the biggest changes the series has seen.", 14, 8.5, "Game Informer" },
                    { 10, "A charming new region that balances familiarity with meaningful changes, welcoming both longtime fans and newcomers.", 14, 8.0, "GamesRadar+" },
                    { 11, "A definitive edition of Sun and Moon, offering small improvements, new activities, and additional content.", 15, 8.0, "EGM" },
                    { 12, "A worthwhile return to Alola, with improved pacing and charming details, although the story can become complicated.", 15, 8.0, "GameSpot" },
                    { 13, "A delightful reimagining of the original games that introduces smart changes while preserving their nostalgic appeal.", 16, 8.0, "GameSpot" },
                    { 14, "A heartwarming return to Kanto with colorful visuals, adorable partner Pokemon, and an enjoyable catching system.", 16, 8.3000000000000007, "IGN" },
                    { 15, "A strong new generation that streamlines familiar mechanics and focuses on the enjoyable fundamentals of Pokemon.", 17, 9.0, "GameSpot" },
                    { 16, "An entertaining introduction to the HD generation, with enjoyable battles and an appealing new region.", 17, 8.0, "Nintendo Life" },
                    { 17, "A nostalgic return to Sinnoh that preserves the enjoyment of catching, training, and exploring.", 18, 8.5, "Game Informer" },
                    { 18, "A comfortable return to Sinnoh with some welcome modern improvements, although it doesn't do enough to distinguish itself.", 18, 7.0, "GameSpot" },
                    { 19, "A disappointing remake that sticks too closely to the originals and misses opportunities to improve the experience.", 18, 6.0, "Nintendo Life" },
                    { 20, "A bold new direction for the franchise that finally delivers the open-world Pokemon experience many fans have wanted.", 19, 9.0, "Nintendo Life" },
                    { 21, "A significant reinvention of the series, with an addictive catching system and a refreshing approach to exploration.", 19, 8.0, "GameSpot" },
                    { 22, "A promising reinvention of the formula, although its environments and presentation leave something to be desired.", 19, 7.0, "IGN" },
                    { 23, "An enjoyable new direction for the franchise, with engaging real-time battles and an interesting setting.", 21, 8.0, "IGN" },
                    { 24, "An interesting evolution of Pokemon battles, although the restricted setting and repetitive activities hold it back.", 21, 7.0, "GameSpot" },
                    { 25, "The new battle system has potential, but the limited setting and visual presentation make the experience less impressive.", 21, 6.0, "Nintendo Life" },
                    { 26, "A fun new take on the franchise that makes its real-time battles and urban setting stand out.", 21, 8.0, "Game Informer" },
                    { 27, "An interesting evolution of the series, though its smaller setting and uneven exploration limit its ambitions.", 21, 6.0, "Eurogamer" },
                    { 28, "It's amazing how much was accomplished with such limited hardware. A classic that deserves its reputation.", 1, 9.0, "Alex" },
                    { 29, "Being able to revisit Kanto after completing Johto is still one of my favorite moments in the franchise.", 4, 9.5, "Morgan" },
                    { 30, "The Battle Frontier is everything I want from a Pokemon post-game. I could spend hundreds of hours here.", 7, 10.0, "Tyler" },
                    { 31, "The transition into 3D was fantastic. Exploring Kalos and discovering Mega Evolution made this generation memorable.", 12, 9.0, "Jordan" },
                    { 32, "The open world is fantastic and the story surprised me. Performance issues are unfortunate, but I still had a great time.", 20, 8.5, "Sam" },
                    { 33, "I love the direction this series is heading. The new battle system makes encounters much more exciting.", 21, 9.5, "Tyler" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
