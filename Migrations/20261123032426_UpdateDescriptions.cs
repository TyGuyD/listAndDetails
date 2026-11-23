using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace listAndDetails.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescriptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewerName",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The original Pokemon role-playing games introduce the series' core mechanics of catching, training, and battling Pokemon. Players travel across Kanto to collect eight Gym Badges, challenge the Pokemon League, and encounter the criminal organization Team Rocket.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Pokemon Blue is an updated version of the original Red and Green releases, featuring revised Pokemon artwork and other changes. It follows the same Kanto adventure, in which players collect Gym Badges, complete their Pokedex, and challenge the Pokemon League.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Pokemon Yellow is a special edition inspired by the Pokemon animated series. Pikachu accompanies the player outside its Pokeball, while several characters and events reflect elements of the anime, including encounters with Jessie and James.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Pokemon Gold and Silver introduce the Johto region and 100 new Pokemon, along with breeding, held items, and a day-and-night cycle. After becoming Champion, players can travel to Kanto and challenge its Gym Leaders as well.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Pokemon Crystal is an enhanced version of Gold and Silver with animated Pokemon sprites and additional story events involving the Legendary Pokemon Suicune. It also allows players to choose a female protagonist for the first time in the main series.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Pokemon Ruby and Sapphire introduce the Hoenn region and 135 new Pokemon, along with abilities, natures, double battles, and contests. The story centers on the conflict between Team Magma and Team Aqua, whose plans threaten the balance of the region's environment.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Pokemon Emerald expands the Hoenn story by featuring both Team Magma and Team Aqua, with Rayquaza playing a central role in resolving their conflict. Its major post-game addition is the Battle Frontier, which offers several specialized facilities for challenging battles.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Pokemon Diamond and Pearl introduce the Sinnoh region and 107 new Pokemon. The games add online trading and battling through Nintendo Wi-Fi Connection, while the story follows the player's journey to the Pokemon League and their confrontation with Team Galactic.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Pokemon Platinum revisits Sinnoh with an expanded story involving Giratina and the Distortion World, a mysterious dimension where normal physical rules do not apply. It also introduces additional characters, revised locations, and a Battle Frontier based on the facility from Pokemon Emerald.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Pokemon Black and White take place in Unova, a region inspired by the New York metropolitan area, and introduce 156 new Pokemon. Their story focuses on Team Plasma and raises questions about whether Pokemon should continue to be used for battling alongside the player's journey to become Champion.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Pokemon Black 2 and White 2 are direct sequels set two years after the events of Black and White. Players revisit a changed Unova, explore new areas, encounter returning characters, and face a revived Team Plasma with a different agenda.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Pokemon X and Y introduce the Kalos region and mark the main series' transition to fully 3D environments and character models. The games add Mega Evolution, character customization, and the Fairy type, while their story involves the ancient history of Kalos and Team Flare.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Pokemon Omega Ruby and Alpha Sapphire remake the original Hoenn games with 3D environments, updated battle mechanics, and Mega Evolution. They also include the Delta Episode, an additional story involving Rayquaza, Deoxys, and a threat approaching the planet.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Pokemon Sun and Moon take place in Alola, a tropical region made up of four main islands and a smaller artificial island. The traditional Gym challenge is replaced by island trials, while the story introduces Z-Moves, regional Pokemon forms, and the mysterious Ultra Beasts.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Pokemon Ultra Sun and Ultra Moon revisit Alola with an expanded storyline centered on Necrozma and its connection to the Ultra Beasts. The games add new locations, activities, and post-game content, including the ability to travel through Ultra Wormholes to other worlds.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Pokemon Let's Go, Pikachu! and Let's Go, Eevee! revisit the Kanto region with gameplay influenced by Pokemon Yellow and Pokemon GO. Wild Pokemon are caught using motion-based or button controls rather than traditional battles, while trainer battles and Gym challenges retain familiar series mechanics.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Pokemon Sword and Shield introduce the Galar region, inspired by Great Britain, and feature a Pokemon League organized around a series of public Gym battles. The games add Dynamax and Gigantamax transformations, as well as the Wild Area, a large environment where players can explore and encounter Pokemon in varying weather conditions.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Pokemon Brilliant Diamond and Shining Pearl are remakes of the original Diamond and Pearl, recreating the Sinnoh adventure with updated graphics and a chibi-style overworld. They retain much of the original structure while incorporating features such as the Grand Underground, updated Pokemon storage, and modernized online functions.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Pokemon Legends: Arceus takes place in the Hisui region, an earlier version of Sinnoh, when people and Pokemon have not yet learned to live closely together. Players work for the Galaxy Expedition Team to research Pokemon, complete the first regional Pokedex, and investigate mysterious phenomena involving powerful Pokemon.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Pokemon Scarlet and Violet take place in Paldea, an open-world region where players can explore in a largely unrestricted order. The adventure is divided into three storylines involving Gym challenges, the mysterious Titan Pokemon, and Team Star, while the Terastal phenomenon changes Pokemon's types during battle.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Pokemon Legends: Z-A takes place entirely within Lumiose City in the Kalos region, where an urban redevelopment project aims to create a city shared by people and Pokemon. Battles use real-time movement and attacks, and Mega Evolution returns as a central part of the gameplay.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReviewerName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The first Pokemon games released in Japan.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "An updated version of Pokemon Red and Green released in Japan.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "A special edition of Pokemon Red and Blue featuring Pikachu as the starter Pokemon.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The second generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "An updated version of Pokemon Gold and Silver with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "The third generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "An updated version of Pokemon Ruby and Sapphire with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "The fourth generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "An updated version of Pokemon Diamond and Pearl with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "The fifth generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "An updated version of Pokemon Black and White with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "The sixth generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "An updated version of Pokemon Ruby and Sapphire with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "The seventh generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "An updated version of Pokemon Sun and Moon with additional features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "A reimagining of Pokemon Yellow with updated graphics and gameplay.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "The eighth generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "A remaster of Pokemon Diamond and Pearl with updated graphics and gameplay.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "A prequel to Pokemon Diamond and Pearl set in the Hisui region.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "The ninth generation of Pokemon games introducing new Pokemon and features.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "A new entry in the Pokemon Legends series set in Lumiose City, featuring an urban redevelopment project and a real-time battle system.");
        }
    }
}
