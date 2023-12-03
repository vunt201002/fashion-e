using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGalleryColor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ColorId",
                table: "Gellery",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Gellery");
        }
    }
}
