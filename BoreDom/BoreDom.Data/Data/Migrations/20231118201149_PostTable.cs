using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoreDom.Data.Migrations
{
    public partial class PostTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PosterID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_PosterID",
                        column: x => x.PosterID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Posts_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Posts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ParentID",
                table: "Posts",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PosterID",
                table: "Posts",
                column: "PosterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
