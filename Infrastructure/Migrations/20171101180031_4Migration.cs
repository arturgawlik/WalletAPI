using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infrastructure.Migrations
{
    public partial class _4Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallets_Users_UserId",
                table: "Wallets");

            migrationBuilder.DropIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Wallets");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Wallets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallets_Users_UserId",
                table: "Wallets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
