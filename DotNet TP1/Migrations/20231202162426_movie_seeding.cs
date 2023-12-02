using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DotNet_TP1.Migrations
{
    /// <inheritdoc />
    public partial class movie_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6a3d1534-1fd4-4a8b-9dbd-452f90da8e18"), "GenreFromJsonFile3" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Id", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, new Guid("84ca0bcd-082c-49cb-aa77-ea2f1f5f8285"), "Movie1" },
                    { 2, new Guid("79e6f638-d7e7-4f63-8365-f172cb925381"), "Movie2" },
                    { 4, new Guid("79e6f638-d7e7-4f63-8365-f172cb925381"), "Movie4" },
                    { 5, new Guid("84ca0bcd-082c-49cb-aa77-ea2f1f5f8285"), "Movie5" },
                    { 3, new Guid("6a3d1534-1fd4-4a8b-9dbd-452f90da8e18"), "Movie3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "genres",
                keyColumn: "Id",
                keyValue: new Guid("6a3d1534-1fd4-4a8b-9dbd-452f90da8e18"));
        }
    }
}
