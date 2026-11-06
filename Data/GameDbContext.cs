using Microsoft.EntityFrameworkCore;

namespace Game.Models;

public class GameDbContext : DbContext
{
    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

    public DbSet<Game> Games { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>().HasData(
            new Game { Id = 1, Title = "Pokemon Red and Green", ReleaseDate = new DateTime(1996, 2, 27), Generation = "1", Region = "Kanto", Developer = "Game Freak", Director = "Satoshi Tajiri", Platform = "Game Boy", Description = "The first Pokemon games released in Japan." },
            new Game { Id = 2, Title = "Pokemon Blue", ReleaseDate = new DateTime(1996, 10, 15), Generation = "1", Region = "Kanto", Developer = "Game Freak", Director = "Satoshi Tajiri", Platform = "Game Boy", Description = "An updated version of Pokemon Red and Green released in Japan." },
            new Game { Id = 3, Title = "Pokemon Yellow", ReleaseDate = new DateTime(1998, 9, 12), Generation = "1", Region = "Kanto", Developer = "Game Freak", Director = "Satoshi Tajiri", Platform = "Game Boy", Description = "A special edition of Pokemon Red and Blue featuring Pikachu as the starter Pokemon." },
            new Game { Id = 4, Title = "Pokemon Gold and Silver", ReleaseDate = new DateTime(1999, 11, 21), Generation = "2", Region = "Johto", Developer = "Game Freak", Director = "Satoshi Tajiri", Platform = "Game Boy Color", Description = "The second generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 5, Title = "Pokemon Crystal", ReleaseDate = new DateTime(2000, 12, 14), Generation = "2", Region = "Johto", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Game Boy Color", Description = "An updated version of Pokemon Gold and Silver with additional features." },
            new Game { Id = 6, Title = "Pokemon Ruby and Sapphire", ReleaseDate = new DateTime(2002, 11, 21), Generation = "3", Region = "Hoenn", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Game Boy Advance", Description = "The third generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 7, Title = "Pokemon Emerald", ReleaseDate = new DateTime(2004, 9, 16), Generation = "3", Region = "Hoenn", Developer = "Game Freak", Director = "Shigeki Morimoto", Platform = "Game Boy Advance", Description = "An updated version of Pokemon Ruby and Sapphire with additional features." },
            new Game { Id = 8, Title = "Pokemon Diamond and Pearl", ReleaseDate = new DateTime(2006, 9, 28), Generation = "4", Region = "Sinnoh", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Nintendo DS", Description = "The fourth generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 9, Title = "Pokemon Platinum", ReleaseDate = new DateTime(2008, 9, 13), Generation = "4", Region = "Sinnoh", Developer = "Game Freak", Director = "Takeshi Kawachimaru", Platform = "Nintendo DS", Description = "An updated version of Pokemon Diamond and Pearl with additional features." },
            new Game { Id = 10, Title = "Pokemon Black and White", ReleaseDate = new DateTime(2010, 9, 18), Generation = "5", Region = "Unova", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Nintendo DS", Description = "The fifth generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 11, Title = "Pokemon Black 2 and White 2", ReleaseDate = new DateTime(2012, 6, 7), Generation = "5", Region = "Unova", Developer = "Game Freak", Director = "Takao Unno", Platform = "Nintendo DS", Description = "An updated version of Pokemon Black and White with additional features." },
            new Game { Id = 12, Title = "Pokemon X and Y", ReleaseDate = new DateTime(2013, 10, 12), Generation = "6", Region = "Kalos", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Nintendo 3DS", Description = "The sixth generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 13, Title = "Pokemon Omega Ruby and Alpha Sapphire", ReleaseDate = new DateTime(2014, 11, 21), Generation = "6", Region = "Hoenn", Developer = "Game Freak", Director = "Shigeru Ohmori", Platform = "Nintendo 3DS", Description = "An updated version of Pokemon Ruby and Sapphire with additional features." },
            new Game { Id = 14, Title = "Pokemon Sun and Moon", ReleaseDate = new DateTime(2016, 11, 18), Generation = "7", Region = "Alola", Developer = "Game Freak", Director = "Shigeru Ohmori", Platform = "Nintendo 3DS", Description = "The seventh generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 15, Title = "Pokemon Ultra Sun and Ultra Moon", ReleaseDate = new DateTime(2017, 11, 17), Generation = "7", Region = "Alola", Developer = "Game Freak", Director = "Kazumasa Iwao", Platform = "Nintendo 3DS", Description = "An updated version of Pokemon Sun and Moon with additional features." },
            new Game { Id = 16, Title = "Pokemon Let's Go, Pikachu! and Let's Go, Eevee!", ReleaseDate = new DateTime(2018, 11, 16), Generation = "7", Region = "Kanto", Developer = "Game Freak", Director = "Junichi Masuda", Platform = "Nintendo Switch", Description = "A reimagining of Pokemon Yellow with updated graphics and gameplay." },
            new Game { Id = 17, Title = "Pokemon Sword and Shield", ReleaseDate = new DateTime(2019, 11, 15), Generation = "8", Region = "Galar", Developer = "Game Freak", Director = "Shigeru Ohmori", Platform = "Nintendo Switch", Description = "The eighth generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 18, Title = "Pokemon Brilliant Diamond and Shining Pearl", ReleaseDate = new DateTime(2021, 11, 19), Generation = "8", Region = "Sinnoh", Developer = "ILCA", Director = "Junichi Masuda, Yuichi Ueda", Platform = "Nintendo Switch", Description = "A remaster of Pokemon Diamond and Pearl with updated graphics and gameplay." },
            new Game { Id = 19, Title = "Pokemon Legends: Arceus", ReleaseDate = new DateTime(2022, 1, 28), Generation = "8", Region = "Hisui", Developer = "Game Freak", Director = "Kazumasa Iwao", Platform = "Nintendo Switch", Description = "A prequel to Pokemon Diamond and Pearl set in the Hisui region." },
            new Game { Id = 20, Title = "Pokemon Scarlet and Violet", ReleaseDate = new DateTime(2022, 11, 18), Generation = "9", Region = "Paldea", Developer = "Game Freak", Director = "Shigeru Ohmori", Platform = "Nintendo Switch", Description = "The ninth generation of Pokemon games introducing new Pokemon and features." },
            new Game { Id = 21, Title = "Pokemon Legends: Z-A", ReleaseDate = new DateTime(2025, 10, 16), Generation = "9", Region = "Kalos", Developer = "Game Freak", Director = "Haruka Tochigi", Platform = "Nintendo Switch, Nintendo Switch 2", Description = "A new entry in the Pokemon Legends series set in Lumiose City, featuring an urban redevelopment project and a real-time battle system." }
        );

        modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, GameId = 13, ReviewerName = "IGN", Rating = 7.8, Comment = "Good. Gorgeous details, but it has too much water." },
            new Review { Id = 2, GameId = 10, ReviewerName = "Tyler", Rating = 9.5, Comment = "These games have stood the test of time beautifully. Likely the best games in the series!" },
            new Review { Id = 3, GameId = 7, ReviewerName = "GameSpot", Rating = 7.5, Comment = "A familiar but enjoyable adventure. Emerald offers plenty of content, although much of it feels recycled from Ruby and Sapphire." },
            new Review { Id = 4, GameId = 9, ReviewerName = "Nintendo Life", Rating = 9.0, Comment = "An excellent enhanced version of Diamond and Pearl, with meaningful improvements and plenty of additional content." },
            new Review { Id = 5, GameId = 11, ReviewerName = "IGN", Rating = 9.6, Comment = "An outstanding sequel that builds on its predecessors with an expanded world, new features, and an impressive amount of content." },
            new Review { Id = 6, GameId = 11, ReviewerName = "GameSpot", Rating = 6.5, Comment = "The familiar battling remains enjoyable, but the story and some of the new additions don't quite reach the same heights." },
            new Review { Id = 7, GameId = 13, ReviewerName = "GameSpot", Rating = 8.0, Comment = "A colorful and enjoyable return to Hoenn, with improved visuals, Mega Evolution, and plenty of multiplayer possibilities." },
            new Review { Id = 8, GameId = 13, ReviewerName = "Nintendo Life", Rating = 9.0, Comment = "A fantastic remake that brings Hoenn to life with impressive visuals and worthwhile additions." },
            new Review { Id = 9, GameId = 14, ReviewerName = "Game Informer", Rating = 8.5, Comment = "A refreshing generation that reexamines familiar mechanics and introduces some of the biggest changes the series has seen." },
            new Review { Id = 10, GameId = 14, ReviewerName = "GamesRadar+", Rating = 8.0, Comment = "A charming new region that balances familiarity with meaningful changes, welcoming both longtime fans and newcomers." },
            new Review { Id = 11, GameId = 15, ReviewerName = "EGM", Rating = 8.0, Comment = "A definitive edition of Sun and Moon, offering small improvements, new activities, and additional content." },
            new Review { Id = 12, GameId = 15, ReviewerName = "GameSpot", Rating = 8.0, Comment = "A worthwhile return to Alola, with improved pacing and charming details, although the story can become complicated." },
            new Review { Id = 13, GameId = 16, ReviewerName = "GameSpot", Rating = 8.0, Comment = "A delightful reimagining of the original games that introduces smart changes while preserving their nostalgic appeal." },
            new Review { Id = 14, GameId = 16, ReviewerName = "IGN", Rating = 8.3, Comment = "A heartwarming return to Kanto with colorful visuals, adorable partner Pokemon, and an enjoyable catching system." },
            new Review { Id = 15, GameId = 17, ReviewerName = "GameSpot", Rating = 9.0, Comment = "A strong new generation that streamlines familiar mechanics and focuses on the enjoyable fundamentals of Pokemon." },
            new Review { Id = 16, GameId = 17, ReviewerName = "Nintendo Life", Rating = 8.0, Comment = "An entertaining introduction to the HD generation, with enjoyable battles and an appealing new region." },
            new Review { Id = 17, GameId = 18, ReviewerName = "Game Informer", Rating = 8.5, Comment = "A nostalgic return to Sinnoh that preserves the enjoyment of catching, training, and exploring." },
            new Review { Id = 18, GameId = 18, ReviewerName = "GameSpot", Rating = 7.0, Comment = "A comfortable return to Sinnoh with some welcome modern improvements, although it doesn't do enough to distinguish itself." },
            new Review { Id = 19, GameId = 18, ReviewerName = "Nintendo Life", Rating = 6.0, Comment = "A disappointing remake that sticks too closely to the originals and misses opportunities to improve the experience." },
            new Review { Id = 20, GameId = 19, ReviewerName = "Nintendo Life", Rating = 9.0, Comment = "A bold new direction for the franchise that finally delivers the open-world Pokemon experience many fans have wanted." },
            new Review { Id = 21, GameId = 19, ReviewerName = "GameSpot", Rating = 8.0, Comment = "A significant reinvention of the series, with an addictive catching system and a refreshing approach to exploration." },
            new Review { Id = 22, GameId = 19, ReviewerName = "IGN", Rating = 7.0, Comment = "A promising reinvention of the formula, although its environments and presentation leave something to be desired." },
            new Review { Id = 23, GameId = 21, ReviewerName = "IGN", Rating = 8.0, Comment = "An enjoyable new direction for the franchise, with engaging real-time battles and an interesting setting." },
            new Review { Id = 24, GameId = 21, ReviewerName = "GameSpot", Rating = 7.0, Comment = "An interesting evolution of Pokemon battles, although the restricted setting and repetitive activities hold it back." },
            new Review { Id = 25, GameId = 21, ReviewerName = "Nintendo Life", Rating = 6.0, Comment = "The new battle system has potential, but the limited setting and visual presentation make the experience less impressive." },
            new Review { Id = 26, GameId = 21, ReviewerName = "Game Informer", Rating = 8.0, Comment = "A fun new take on the franchise that makes its real-time battles and urban setting stand out." },
            new Review { Id = 27, GameId = 21, ReviewerName = "Eurogamer", Rating = 6.0, Comment = "An interesting evolution of the series, though its smaller setting and uneven exploration limit its ambitions." },
            new Review { Id = 28, GameId = 1, ReviewerName = "Alex", Rating = 9.0, Comment = "It's amazing how much was accomplished with such limited hardware. A classic that deserves its reputation." },
            new Review { Id = 29, GameId = 4, ReviewerName = "Morgan", Rating = 9.5, Comment = "Being able to revisit Kanto after completing Johto is still one of my favorite moments in the franchise." },
            new Review { Id = 30, GameId = 7, ReviewerName = "Tyler", Rating = 10.0, Comment = "The Battle Frontier is everything I want from a Pokemon post-game. I could spend hundreds of hours here." },
            new Review { Id = 31, GameId = 12, ReviewerName = "Jordan", Rating = 9.0, Comment = "The transition into 3D was fantastic. Exploring Kalos and discovering Mega Evolution made this generation memorable." },
            new Review { Id = 32, GameId = 20, ReviewerName = "Sam", Rating = 8.5, Comment = "The open world is fantastic and the story surprised me. Performance issues are unfortunate, but I still had a great time." },
            new Review { Id = 33, GameId = 21, ReviewerName = "Tyler", Rating = 9.5, Comment = "I love the direction this series is heading. The new battle system makes encounters much more exciting." }
        );
    }
}