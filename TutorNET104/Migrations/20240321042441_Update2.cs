using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TutorNET104.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Product_SanPhamId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_SanPhamId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "SanPhamId",
                table: "OrderDetails");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_IdSP",
                table: "OrderDetails",
                column: "IdSP");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Product_IdSP",
                table: "OrderDetails",
                column: "IdSP",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Product_IdSP",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_IdSP",
                table: "OrderDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "SanPhamId",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SanPhamId",
                table: "OrderDetails",
                column: "SanPhamId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Product_SanPhamId",
                table: "OrderDetails",
                column: "SanPhamId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
