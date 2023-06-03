using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnetodev.Migrations
{
    /// <inheritdoc />
    public partial class wage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "EntityNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "length",
                table: "EntityNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "wage",
                table: "EntityNames",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "EntityNames");

            migrationBuilder.DropColumn(
                name: "length",
                table: "EntityNames");

            migrationBuilder.DropColumn(
                name: "wage",
                table: "EntityNames");
        }
    }
}
