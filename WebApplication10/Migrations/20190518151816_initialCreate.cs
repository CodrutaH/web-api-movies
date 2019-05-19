using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "Movies",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Title = table.Column<string>(nullable: true),
        //            Description = table.Column<string>(nullable: true),
        //            Genre = table.Column<string>(nullable: true),
        //            Duration = table.Column<int>(nullable: false),
        //            Year = table.Column<int>(nullable: false),
        //            Director = table.Column<string>(nullable: true),
        //            Date = table.Column<DateTime>(nullable: false),
        //            Rating = table.Column<int>(nullable: false),
        //            Watched = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Movies", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Comments",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            Text = table.Column<string>(nullable: true),
        //            Important = table.Column<bool>(nullable: false),
        //            MovieId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Comments", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Comments_Movies_MovieId",
        //                column: x => x.MovieId,
        //                principalTable: "Movies",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Comments_MovieId",
        //        table: "Comments",
        //        column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
