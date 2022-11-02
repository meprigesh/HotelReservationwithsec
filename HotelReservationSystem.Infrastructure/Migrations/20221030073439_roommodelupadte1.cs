using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelReservationSystem.Infrastructure.Migrations
{
    public partial class roommodelupadte1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_RoomType_RoomTypeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_RoomType_RoomTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.RenameTable(
                name: "RoomType",
                newName: "RoomTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_RoomTypes_RoomTypeId",
                table: "Bookings",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_RoomTypes_RoomTypeId",
                table: "Customers",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_RoomTypes_RoomTypeId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_RoomTypes_RoomTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_RoomTypeId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes");

            migrationBuilder.RenameTable(
                name: "RoomTypes",
                newName: "RoomType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_RoomType_RoomTypeId",
                table: "Bookings",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_RoomType_RoomTypeId",
                table: "Customers",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "RoomTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
