using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomManagement.Migrations
{
    public partial class SeedingDataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Flag", "Name" },
                values: new object[] { 1, null, "101" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Flag", "Name" },
                values: new object[] { 2, null, "201" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Flag", "Name" },
                values: new object[] { 3, null, "301" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "From", "RoomId", "To" },
                values: new object[] { 1, new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "From", "RoomId", "To" },
                values: new object[] { 2, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "From", "RoomId", "To" },
                values: new object[] { 3, new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
