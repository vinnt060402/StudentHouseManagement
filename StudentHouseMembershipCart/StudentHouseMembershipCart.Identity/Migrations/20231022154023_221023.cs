using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _221023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("20bc0668-eaab-4770-b1f1-fd0621f718e9"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("66ad6f5e-55a8-48df-bd0b-8ffcc96cb920"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("ae7ae9fe-7794-406b-b714-80d223b96577"));

            migrationBuilder.DropColumn(
                name: "WorkingDay",
                table: "ReportWork");

            migrationBuilder.AddColumn<string>(
                name: "AlternativeReason",
                table: "ReportWork",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ReportByStaffId",
                table: "ReportWork",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StaffSubstitableId",
                table: "ReportWork",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkingDayExpect",
                table: "ReportWork",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkingDayReport",
                table: "ReportWork",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkingStatus",
                table: "ReportWork",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 172, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "9df7b578-fd83-44d3-8cf1-788103cce1f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "d9617159-7305-4592-8684-3e7352aa8338");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "55ac6feb-9754-420b-863e-851fc9fa7103");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34354a8b-b007-4bb8-aada-a3b8e6d509d7", "AQAAAAEAACcQAAAAEALGHC3BLQK1Rb8yUVoG5t2qDScODKm3ETHFbR4/Wt4QEC8VSuChNS8JCYP8s/N9Ew==", "c4cbde74-d988-4cea-a8a6-1d5cba43cec6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9e36cfc-aa47-45a8-ae10-acb57885b74d", "AQAAAAEAACcQAAAAEKeRqgeH/bJM0EkTpBByzYBFnEkkvYFYzhRILHL1nO5gtxI9txbVPS49vsmKFJEnHQ==", "9f76b712-9ff1-4a18-9a49-9084fed1490d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3646c11e-ab7a-421e-bfec-cb619dde76f4", "AQAAAAEAACcQAAAAEJjqcaC08Pe4utUtRNNxMqJ0RTB/4FxQxknn3JQv252HubkR6+frCcyFZXfJzOTswA==", "c50fa933-db5c-4a23-a1fc-946d746b91fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d4a1f4b-0acb-49e1-88d1-140bcd5faf57", "AQAAAAEAACcQAAAAEGVylGBrzR1nYTn3JsvZrnepSc+zgnZzMISk8fbQyp43xvcPjcCFNM1HQsQp4LTaiQ==", "b14f57c7-6d32-46a6-89f1-cc90f1c4d5db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01893b35-8e4b-473c-88c7-f6e7f86b7b79", "AQAAAAEAACcQAAAAEBrKtGGX5xiRBEVjDtUr/YEpQl6i+ptvtnWQCQ6CTAn1GnQJTX0/s4irOgh3t3f45Q==", "12f58e9c-c442-4c26-b0fd-6eed61028854" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa27136f-17e6-4509-b743-0db657f3da1d", "AQAAAAEAACcQAAAAEImAeMhYHFX4LVmlpj6ulQYHVm/XyT9Khdv7KG2JX7WFbGxUu0dpd71+KkcfqHmCSw==", "29b4f45a-fcae-4783-bc40-4f7e656e0307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64fb07c1-df88-44a4-bbc0-edae386213e5", "AQAAAAEAACcQAAAAEA6ah9eeuX/stPDLpsd34EqYmM0IvdFUCN+qb30vnRYNXqA6Kw6G+R1cXAZaPMCagw==", "f4a697bd-010d-47ae-af35-99a319bd8648" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4b5b1c-8a0e-49fd-94fd-35645167e143", "AQAAAAEAACcQAAAAEK0HnUC3yrf807gFQcA3Mbt6J+L5QooTXO8wDv+55tbsIGZn7T7/DXD0Ouy4kSt1LA==", "3caaa271-a4f4-41ff-8ab8-60d61bea9262" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71eca77a-03d0-4808-a0f4-93ea2126f3b5", "AQAAAAEAACcQAAAAECbI75QupkX/f0175FD8CKbLxJKOcsuE0e6Jun6wO4CMNUXm/tZD12gsIjin3jck3A==", "04c4a963-5e3c-471c-82c0-48a3570966b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4589bd7-6da0-4cbd-a8df-af8affcaef79", "AQAAAAEAACcQAAAAEEWQj8e3uTTUtLFIBS/cUjLRJZv3IqywV6ub/aHq9aGx8Uk3CFap9aGhWJPUeVq+rw==", "0562b6f2-3299-429c-9be2-77c479146cce" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4200), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4194), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4219), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4066), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4438), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4372), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4529), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4537), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("c4d40d47-5405-4db1-8b46-916d53ae5004"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(6854), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("e6faa65d-2740-4735-9030-8b43f1e8cc9f"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(6845), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("ebcb9163-880d-4e23-891e-060a396ca553"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(6830), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7619));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("07760009-74e9-49dc-a286-3885fc816596"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e49e2e39-8eca-42f5-8cfc-5deade7e331b"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e587848f-e7c9-4d8d-830c-eddb838cdc25"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(9042), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(9038), new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 22, 22, 40, 21, 252, DateTimeKind.Local).AddTicks(9022));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("c4d40d47-5405-4db1-8b46-916d53ae5004"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("e6faa65d-2740-4735-9030-8b43f1e8cc9f"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("ebcb9163-880d-4e23-891e-060a396ca553"));

            migrationBuilder.DropColumn(
                name: "AlternativeReason",
                table: "ReportWork");

            migrationBuilder.DropColumn(
                name: "ReportByStaffId",
                table: "ReportWork");

            migrationBuilder.DropColumn(
                name: "StaffSubstitableId",
                table: "ReportWork");

            migrationBuilder.DropColumn(
                name: "WorkingDayExpect",
                table: "ReportWork");

            migrationBuilder.DropColumn(
                name: "WorkingDayReport",
                table: "ReportWork");

            migrationBuilder.DropColumn(
                name: "WorkingStatus",
                table: "ReportWork");

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkingDay",
                table: "ReportWork",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 30, 957, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "53e59e54-3794-4969-bc43-ba16fdf685dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "adf87e67-2ae7-47ef-9155-c04de815a7a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "6a763f20-4151-4ade-bd49-d9f2322554b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9b491ca-393a-4ab9-84e3-42197b2ada9d", "AQAAAAEAACcQAAAAEArFpn2nZLoxjWSxFsi7bpyV3lO3++yJtduAjP/dwdN1PsXv0VgK/Ogo5DlGGZtq5Q==", "bc480acb-196f-4a5f-bf45-8e865cada2ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a2737b0-5a52-415a-80ba-2afdeb1e4235", "AQAAAAEAACcQAAAAEHdmg4B0dlJdV8hWs3imq/qXHA16Xd9nvDxj5xobyaJil7yO1U3A7xM9YmHzH5eRYA==", "623a3838-c403-44da-b049-a29275201971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c56e2d2-f893-49f7-8486-63530a2edb9a", "AQAAAAEAACcQAAAAEJRoUpA8WR0eeMb5wnJK+qR4fritrnHPhoU5zwx4KXuYBL5SVeqFi0Beesgye7f0PA==", "9328d620-d2c7-4b96-aaf1-9dd3efd1abaa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dcdd569-13ac-47d0-b380-6ee993d0fddd", "AQAAAAEAACcQAAAAEEYh3iySf4uAqwWOrXnHZ9cQfDdtGd/WPpc8tChVNrapB+iptDU1uzP2zp+b81grfw==", "307e07e3-1fba-4c14-97eb-b4de511003c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790715be-3c85-4b69-83ed-5b6416ff4888", "AQAAAAEAACcQAAAAEIwmGcWwQYOAjld3LBh7IWysdCSATkXNr9coz9qvYy6gGICVUUuTx71t6qdGKejjyA==", "ba207498-99f1-4145-aff2-fb06ad62c7c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b4cb049-cdb7-44b2-93e9-9ec89dc11114", "AQAAAAEAACcQAAAAEJ8W1F4jUKuZwBj8oO1t53dt87groas3VTwBrnHAg8NBq4SpYJE2dOvXEp5RlAxwpw==", "82d07e82-d7d5-4d6b-84cb-7f610bd664d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e99b5a0c-1b15-4b74-a86d-80247d9ec24a", "AQAAAAEAACcQAAAAEGbNLdVDevIa8+qzf0/I9lUh4/AzIvbfw4avY5Qie9ocRYlIRk8pybecz/Fcix3b7Q==", "1f1b8140-5feb-4307-b6c5-7a40612468b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6a2ca70-f411-4fda-be00-bcd84f0eb28c", "AQAAAAEAACcQAAAAEAwqv6oMeuKBSMMsvunJg9BFzxXxQeqEkWiWa5UomVq4wv00QKZUQi7YB1ND/CH6xA==", "3a0e7e73-d007-4e6e-8759-36586da11c66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc55613f-99e7-4333-a6c6-1ca62cd7b4f3", "AQAAAAEAACcQAAAAEBxSEFxTLWZZiNvs6rCgB5mIKp8rym7BBciyTYPa2OyKQBzEegbSUk+/Xc0vmIMA3A==", "b1750358-ab17-44c9-820f-da20c3446c4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3752e90-6777-44bd-9935-85310a22df56", "AQAAAAEAACcQAAAAENMy5zYkiV9Xjdq8VHJowOSLuwnLcSBjeJXD5yyaeBKlJHjf0Xap8fsqnLbbmzlpAQ==", "a94031e2-79b8-4352-af1a-a05ec68c90db" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9921), new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9802), new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9926), new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9930), new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9778), new DateTime(2023, 10, 18, 22, 58, 31, 33, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(93), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(107), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(97), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(91) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(100), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(109), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("20bc0668-eaab-4770-b1f1-fd0621f718e9"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(542), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("66ad6f5e-55a8-48df-bd0b-8ffcc96cb920"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(550), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("ae7ae9fe-7794-406b-b714-80d223b96577"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(547), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("07760009-74e9-49dc-a286-3885fc816596"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e49e2e39-8eca-42f5-8cfc-5deade7e331b"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e587848f-e7c9-4d8d-830c-eddb838cdc25"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2452), new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 58, 31, 34, DateTimeKind.Local).AddTicks(2436));
        }
    }
}
