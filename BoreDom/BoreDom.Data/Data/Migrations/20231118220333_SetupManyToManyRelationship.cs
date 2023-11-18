using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoreDom.Data.Migrations
{
    public partial class SetupManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Followers",
                columns: table => new
                {
                    FollowerID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FollowedID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Followers", x => new { x.FollowerID, x.FollowedID });
                    table.ForeignKey(
                        name: "FK_Followers_AspNetUsers_FollowedID",
                        column: x => x.FollowedID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Followers_FollowedID",
                table: "Followers",
                column: "FollowedID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Followers");
        }
    }
}
