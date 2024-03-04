using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetEMG2.Migrations
{
    /// <inheritdoc />
    public partial class AgainUpdateCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4808a39c-7371-4863-b521-84446c267334", "8b6f4005-1cb7-46c2-8f7b-2207f5dd1196" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f082a5f8-f8a7-4d82-a653-33b2f3df19a7", "b0d0afdb-bf62-4e93-9902-021af513f340" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4808a39c-7371-4863-b521-84446c267334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f082a5f8-f8a7-4d82-a653-33b2f3df19a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b6f4005-1cb7-46c2-8f7b-2207f5dd1196");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b0d0afdb-bf62-4e93-9902-021af513f340");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4808a39c-7371-4863-b521-84446c267334", null, "User", "USER" },
                    { "f082a5f8-f8a7-4d82-a653-33b2f3df19a7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b6f4005-1cb7-46c2-8f7b-2207f5dd1196", 0, "a9204744-8cb2-4ad7-8068-7149bb500059", "user1@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFq+WAHjLz+gn3rD8lCku1SVBaifsOBeiDvlpB995MvA38UtKjbQYYD7lZB/JcN9Pg==", null, false, "38e60289-ff63-44f4-8d3d-0b2a6836b989", false, "user1" },
                    { "b0d0afdb-bf62-4e93-9902-021af513f340", 0, "b26aa767-4aea-4513-8619-fb81de773e59", "admin@example.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENEXkw9VIrsAVnTduBGLdfDUNMfQNLUxsR7qSHkTDUrf0YJNl7loDSu5gYJnGpl9yQ==", null, false, "bf1af2cd-c197-4bca-a845-485de422227c", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4808a39c-7371-4863-b521-84446c267334", "8b6f4005-1cb7-46c2-8f7b-2207f5dd1196" },
                    { "f082a5f8-f8a7-4d82-a653-33b2f3df19a7", "b0d0afdb-bf62-4e93-9902-021af513f340" }
                });
        }
    }
}
