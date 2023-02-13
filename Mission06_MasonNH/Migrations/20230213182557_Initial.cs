﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_MasonNH.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Comedy", "Akiva Schaffer", false, null, null, "PG-13", "Hot Rod", 2007 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Family", "Tom McGrath", false, null, null, "PG", "Megamind", 2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Family", "Brad Bird", false, null, null, "PG", "The Incredibles", 2004 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
