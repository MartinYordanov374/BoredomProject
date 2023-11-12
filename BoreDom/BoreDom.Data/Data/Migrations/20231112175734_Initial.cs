using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoreDom.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PictureID",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ProfilePictures",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Picture = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfilePictures", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PictureID",
                table: "AspNetUsers",
                column: "PictureID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ProfilePictures_PictureID",
                table: "AspNetUsers",
                column: "PictureID",
                principalTable: "ProfilePictures",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ProfilePictures_PictureID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProfilePictures");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PictureID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PictureID",
                table: "AspNetUsers");
        }
    }
}
