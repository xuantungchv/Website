using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ifrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NameOfTeacher",
                table: "ClassInfos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameOfTeacher",
                table: "ClassInfos");
        }
    }
}
