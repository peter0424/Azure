﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginApplication.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Booking",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserId",
                table: "Booking",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_UserId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Booking");
        }
    }
}
