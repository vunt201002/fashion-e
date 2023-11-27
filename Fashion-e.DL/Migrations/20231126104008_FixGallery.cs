using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    /// <inheritdoc />
    public partial class FixGallery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsThumbnail",
                table: "Gellery",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsThumbnail",
                table: "Gellery");
        }
    }
}
