﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMA_DB.Migrations
{
    public partial class Dima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Seat_SeatID1",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_SeatID1",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "SeatID1",
                table: "Staff");

            migrationBuilder.AddColumn<long>(
                name: "SeatID",
                table: "Repertoire",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repertoire_SeatID",
                table: "Repertoire",
                column: "SeatID");

            migrationBuilder.AddForeignKey(
                name: "FK_Repertoire_Seat_SeatID",
                table: "Repertoire",
                column: "SeatID",
                principalTable: "Seat",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repertoire_Seat_SeatID",
                table: "Repertoire");

            migrationBuilder.DropIndex(
                name: "IX_Repertoire_SeatID",
                table: "Repertoire");

            migrationBuilder.DropColumn(
                name: "SeatID",
                table: "Repertoire");

            migrationBuilder.AddColumn<long>(
                name: "SeatID1",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staff_SeatID1",
                table: "Staff",
                column: "SeatID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Seat_SeatID1",
                table: "Staff",
                column: "SeatID1",
                principalTable: "Seat",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
