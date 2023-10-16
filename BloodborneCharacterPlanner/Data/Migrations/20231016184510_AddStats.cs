using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloodborneCharacterPlanner.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Arcane",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Bloodtinge",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Endurance",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Skill",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Strength",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitality",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arcane",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Bloodtinge",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Endurance",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Skill",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Strength",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "Vitality",
                table: "Character");
        }
    }
}
