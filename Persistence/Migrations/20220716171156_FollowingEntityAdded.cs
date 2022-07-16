using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class FollowingEntityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowings_AspNetUsers_ObserverId1",
                table: "UserFollowings");

            migrationBuilder.DropIndex(
                name: "IX_UserFollowings_ObserverId1",
                table: "UserFollowings");

            migrationBuilder.DropColumn(
                name: "ObserverId1",
                table: "UserFollowings");

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowings_TargetId",
                table: "UserFollowings",
                column: "TargetId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowings_AspNetUsers_TargetId",
                table: "UserFollowings",
                column: "TargetId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFollowings_AspNetUsers_TargetId",
                table: "UserFollowings");

            migrationBuilder.DropIndex(
                name: "IX_UserFollowings_TargetId",
                table: "UserFollowings");

            migrationBuilder.AddColumn<string>(
                name: "ObserverId1",
                table: "UserFollowings",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFollowings_ObserverId1",
                table: "UserFollowings",
                column: "ObserverId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFollowings_AspNetUsers_ObserverId1",
                table: "UserFollowings",
                column: "ObserverId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
