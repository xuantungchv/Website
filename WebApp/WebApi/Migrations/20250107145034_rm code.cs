using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    /// <inheritdoc />
    public partial class rmcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ClassInfos_ClassInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ClassInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClassInfoId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ClassInfoId",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ClassInfoId",
                table: "AspNetUsers",
                column: "ClassInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ClassInfos_ClassInfoId",
                table: "AspNetUsers",
                column: "ClassInfoId",
                principalTable: "ClassInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
