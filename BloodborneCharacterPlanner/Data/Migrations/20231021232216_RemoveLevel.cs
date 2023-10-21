using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodborneCharacterPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "CharacterSet");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "CharacterSet",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
