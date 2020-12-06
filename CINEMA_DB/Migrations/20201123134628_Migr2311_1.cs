using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMA_DB.Migrations
{
    public partial class Migr2311_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SeatID1",
                table: "Staff",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RepID",
                table: "Seat",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RepID",
                table: "Seat");
        }
    }
}
