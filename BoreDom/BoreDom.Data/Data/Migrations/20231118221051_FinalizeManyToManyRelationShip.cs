using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoreDom.Data.Migrations
{
    public partial class FinalizeManyToManyRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_Followers_AspNetUsers_FollowerID",
                table: "Followers",
                column: "FollowerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Followers_AspNetUsers_FollowerID",
                table: "Followers");
        }
    }
}
