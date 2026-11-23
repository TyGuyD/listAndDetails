# GameDex

A Pokedex-style catalog of Pokemon games. 
GameDex lets users browse the registry, open a game for complete details, and submit community reviews. 
Built for .NET Web Development at WCTC.

## What it does

- Browse registered Pokemon games in a responsive game index
- Open a game to see its release information, region, platform, developer, director, generation, description, and reviews
- Add, edit, and delete games
- Submit a rating and written review for a game

## The three things I improved

1. Website now has improved, unique styling. Every page follows a consistent Pokedex-inspired theme. Styling also adapted to work well across multiple devices and screen sizes. 
2. The game index now presents entries as readable registry cards instead of a plain table.
3. Game descriptions are now much more detailed and meaningful than what was seeded in the database previously. 

## Built with

ASP.NET Core MVC (.NET 10), Entity Framework Core, SQL Server, Bootstrap,
and custom CSS.

## Running it locally

The connection string is stored in user secrets, not in this repository:

    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "<your connection string>"
    dotnet ef database update
    dotnet watch