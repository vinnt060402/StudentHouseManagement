using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Infrastucture.Migrations
{
    public partial class fourthDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0073ae3e-6374-4c66-9a7d-f2e1d411d3b2"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 54, 51, 833, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("5e6e3ac9-d41c-46f1-a4a4-e91ecec521fd"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 54, 51, 833, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("87791989-38cc-4a41-9526-2052bc34258e"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5196cae-9e27-434e-bfd3-2c9db9205eef"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b778f89a-a306-42a4-84fd-1be8f795dc1a"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(316), new DateTime(2023, 9, 25, 20, 54, 51, 834, DateTimeKind.Local).AddTicks(314) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0073ae3e-6374-4c66-9a7d-f2e1d411d3b2"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("5e6e3ac9-d41c-46f1-a4a4-e91ecec521fd"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("87791989-38cc-4a41-9526-2052bc34258e"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b5196cae-9e27-434e-bfd3-2c9db9205eef"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b778f89a-a306-42a4-84fd-1be8f795dc1a"),
                column: "Created",
                value: new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3980), new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3973) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3959), new DateTime(2023, 9, 25, 20, 52, 29, 768, DateTimeKind.Local).AddTicks(3958) });
        }
    }
}
