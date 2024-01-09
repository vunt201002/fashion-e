using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    /// <inheritdoc />
    public partial class ChangeOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_EmployeeId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Order",
                newName: "PackagedId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_EmployeeId",
                table: "Order",
                newName: "IX_Order_PackagedId");

            migrationBuilder.AddColumn<Guid>(
                name: "ConfirmId",
                table: "Order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DeliverdId",
                table: "Order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Order_ConfirmId",
                table: "Order",
                column: "ConfirmId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliverdId",
                table: "Order",
                column: "DeliverdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_ConfirmId",
                table: "Order",
                column: "ConfirmId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_DeliverdId",
                table: "Order",
                column: "DeliverdId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_PackagedId",
                table: "Order",
                column: "PackagedId",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_ConfirmId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_DeliverdId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employee_PackagedId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ConfirmId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_DeliverdId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ConfirmId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliverdId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "PackagedId",
                table: "Order",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PackagedId",
                table: "Order",
                newName: "IX_Order_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employee_EmployeeId",
                table: "Order",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
