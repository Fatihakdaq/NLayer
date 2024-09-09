using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "ReservationUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReservationUsers_RoomId",
                table: "ReservationUsers",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReservationUsers_Room_RoomId",
                table: "ReservationUsers",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "RoomId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReservationUsers_Room_RoomId",
                table: "ReservationUsers");

            migrationBuilder.DropIndex(
                name: "IX_ReservationUsers_RoomId",
                table: "ReservationUsers");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "ReservationUsers");
        }
    }
}
