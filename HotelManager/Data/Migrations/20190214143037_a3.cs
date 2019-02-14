using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManager.Data.Migrations
{
    public partial class a3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Room",
                newName: "RoomTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Room_RoomTypeId",
                table: "Room",
                newName: "IX_Room_RoomTypeID");

            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "Room",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Room",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomType_RoomTypeID",
                table: "Room",
                column: "RoomTypeID",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomType_RoomTypeID",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Room");

            migrationBuilder.RenameColumn(
                name: "RoomTypeID",
                table: "Room",
                newName: "RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Room_RoomTypeID",
                table: "Room",
                newName: "IX_Room_RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomType_RoomTypeId",
                table: "Room",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
