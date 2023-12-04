using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    /// <inheritdoc />
    public partial class AddLinkColorImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkImageColor",
                table: "ColorProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkImageColor",
                table: "ColorProduct");
        }
    }
}
