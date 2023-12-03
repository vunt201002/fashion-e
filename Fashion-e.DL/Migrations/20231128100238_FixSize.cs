using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    /// <inheritdoc />
    public partial class FixSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "SizeProduct",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "SizeProduct");
        }
    }
}
