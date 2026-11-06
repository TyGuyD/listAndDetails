using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace listAndDetails.Migrations
{
    /// <inheritdoc />
    public partial class AddGameDirectors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Games",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "Director",
                value: "Satoshi Tajiri");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "Director",
                value: "Satoshi Tajiri");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "Director",
                value: "Satoshi Tajiri");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "Director",
                value: "Satoshi Tajiri");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7,
                column: "Director",
                value: "Shigeki Morimoto");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9,
                column: "Director",
                value: "Takeshi Kawachimaru");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 11,
                column: "Director",
                value: "Takao Unno");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 12,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 13,
                column: "Director",
                value: "Shigeru Ohmori");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 14,
                column: "Director",
                value: "Shigeru Ohmori");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 15,
                column: "Director",
                value: "Kazumasa Iwao");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 16,
                column: "Director",
                value: "Junichi Masuda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 17,
                column: "Director",
                value: "Shigeru Ohmori");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 18,
                column: "Director",
                value: "Junichi Masuda, Yuichi Ueda");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 19,
                column: "Director",
                value: "Kazumasa Iwao");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 20,
                column: "Director",
                value: "Shigeru Ohmori");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Developer", "Director", "Generation", "Platform", "Region", "ReleaseDate", "Title" },
                values: new object[] { 21, "A new entry in the Pokemon Legends series set in Lumiose City, featuring an urban redevelopment project and a real-time battle system.", "Game Freak", "Haruka Tochigi", "9", "Nintendo Switch, Nintendo Switch 2", "Kalos", new DateTime(2025, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pokemon Legends: Z-A" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Games");
        }
    }
}
