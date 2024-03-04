using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetEMG2.Migrations
{
    /// <inheritdoc />
    public partial class AgainUpdateCar2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dbe8345-1630-4c60-bb11-4984c26d8cf4", "028aba63-a724-47df-9048-572717918957" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ef6450-d136-47cf-bec2-b072a31c7893", "0f0d6451-6f0b-49f2-90c0-cfa8c26647bb" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dbe8345-1630-4c60-bb11-4984c26d8cf4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80ef6450-d136-47cf-bec2-b072a31c7893");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "028aba63-a724-47df-9048-572717918957");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f0d6451-6f0b-49f2-90c0-cfa8c26647bb");

            migrationBuilder.AlterColumn<string>(
                name: "photo",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a056bfa-92f6-4c7c-863d-d82a1e4f2cb7", null, "Admin", "ADMIN" },
                    { "b2cb6c4b-cf37-4815-af38-25752fcf5e78", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50f39d87-1591-4fb6-9121-29fed9f27f53", 0, "a5fac968-9c3c-4d58-a12f-4b3ca789fe36", "admin@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMJgk/T/BLVXidvBVgG9OOWP9kVSFEOS9IULqNJGqMr0Fix2ZvTANPp3GPuFKEIlMQ==", null, false, "20997b35-8dd7-4bd3-ac67-677d7f711038", false, "admin" },
                    { "9ef9aca4-432c-49d0-8fa1-2d3b8663ddba", 0, "175f9006-8e26-4227-91e6-77258c137a85", "user1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENRJCEC7ULCsG7lB24wgEL1vDvY3kX9DvXZqahNVaTI9SryfBp8E2qrTingdx7zv1w==", null, false, "45ab0f94-58a5-4df8-95bd-498f602d3ebc", false, "user1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2a056bfa-92f6-4c7c-863d-d82a1e4f2cb7", "50f39d87-1591-4fb6-9121-29fed9f27f53" },
                    { "b2cb6c4b-cf37-4815-af38-25752fcf5e78", "9ef9aca4-432c-49d0-8fa1-2d3b8663ddba" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2a056bfa-92f6-4c7c-863d-d82a1e4f2cb7", "50f39d87-1591-4fb6-9121-29fed9f27f53" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b2cb6c4b-cf37-4815-af38-25752fcf5e78", "9ef9aca4-432c-49d0-8fa1-2d3b8663ddba" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a056bfa-92f6-4c7c-863d-d82a1e4f2cb7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2cb6c4b-cf37-4815-af38-25752fcf5e78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50f39d87-1591-4fb6-9121-29fed9f27f53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ef9aca4-432c-49d0-8fa1-2d3b8663ddba");

            migrationBuilder.AlterColumn<string>(
                name: "photo",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3dbe8345-1630-4c60-bb11-4984c26d8cf4", null, "User", "USER" },
                    { "80ef6450-d136-47cf-bec2-b072a31c7893", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "028aba63-a724-47df-9048-572717918957", 0, "d47200c0-67c2-4098-b407-266a85addd19", "user1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDAMBQYntxdVXeXtk2mgo5fnLQryOBIlfwd4I0ineJNuucFTyhUYTW95D1bQMGU3DA==", null, false, "4c860907-f9e7-43e5-b53e-64b063995277", false, "user1" },
                    { "0f0d6451-6f0b-49f2-90c0-cfa8c26647bb", 0, "11e586c9-5f49-4c6e-afcb-436d8a4ae62f", "admin@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHw13A7FbOvKND2N5uj7SZpgI4yg0tZdrQfEGgNJ/RyILm0QEoBqXwA6u8Vn2B5xyQ==", null, false, "ac23cc67-fb63-4b5a-bc4f-cb2f125b89aa", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3dbe8345-1630-4c60-bb11-4984c26d8cf4", "028aba63-a724-47df-9048-572717918957" },
                    { "80ef6450-d136-47cf-bec2-b072a31c7893", "0f0d6451-6f0b-49f2-90c0-cfa8c26647bb" }
                });
        }
    }
}
