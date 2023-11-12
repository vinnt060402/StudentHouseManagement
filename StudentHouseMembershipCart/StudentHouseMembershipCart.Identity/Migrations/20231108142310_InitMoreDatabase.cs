using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class InitMoreDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("441f8556-e3e9-4db4-8d2b-67feeb32464a"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("7448f3f0-b4cd-4fb7-862a-495c7dd441b2"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("c093b4b6-3efc-4146-9b1a-362a46a654ec"));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 736, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "8d1d93e3-1ab0-441d-825c-6a96376854ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "cbe391a2-e83e-4ed1-99a2-15ac76b327ca");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "fffffed7-95d6-474a-9d68-35a53fe76187");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85d973f5-07a3-4979-afc8-c4ed6d823a76", "AQAAAAEAACcQAAAAEE4TgWF0DDO9Sr0ppdD+yFoQ5f1qQLqCy4zg6tJj4G5y5qR1QdYhLAtlX5QW8+FlRA==", "2380332a-e5f3-4cee-80e5-d83ad0d9ba0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347db8b9-8e32-4002-997c-48dbdc824806", "AQAAAAEAACcQAAAAEGuvEYMLJTcXIWsG3LliE8AqFRDoTBURt89bURwO4Y5KKKut0CShTOkhS6hNp3nRSQ==", "9fcff7d4-6b3c-4324-9486-9ebcb0565048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c10767-b2ed-4d43-8809-79e43b7c502e", "AQAAAAEAACcQAAAAENgIU/qxPKC5iC//4Onb6iB4NqNoxDhjg9MqGXcDsgydWO1mo4emz44XHJdKM8TzLQ==", "799fb528-791d-4c48-af5f-06e76209c7e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f0b7fe2-288b-4e6d-b450-a4c47f0782ff", "AQAAAAEAACcQAAAAENgnkP++PmnsY0OCDk/NQyJyapIxKnMb+UpbOW5ZJlQVsRXUHHllATKWiEsViOXiAA==", "7cbddc18-2a24-45cf-85b6-bdc57f0b1085" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47d4d616-ff9f-4809-87ff-418a136bf64c", "AQAAAAEAACcQAAAAEHmEoap2g1/exml82wphJJPBLtxcmxClC7wdQO4GjpM76NdwWkm8RD2PjyfDORlG5w==", "5ab375c6-a75a-47b2-9a82-9a21698382fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cd937e9e-16d0-453a-ba74-175c97e5a6c7", "AQAAAAEAACcQAAAAEJOUDVfC+3Y2TscCDqBJVYfUn98COHjq/Sjgw9W0SqPBdEFGPXWqSw4evzUauYdlbw==", "05ee3f55-0b64-48c3-aae7-64cdea7d5ee7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4471fdf8-c688-4adc-9f0f-5f4ee2dc2e14", "AQAAAAEAACcQAAAAEOxIsLmhD6UQ8/hR/TFCHrOw2+cqxKWw/kys+vHw2BYlg+bhi8c/BCDnG6V+ay+irg==", "1bffb42f-8995-424d-ae9e-b7a2949e6183" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa7b8959-0f8f-4516-8535-bf89a4e911b5", "AQAAAAEAACcQAAAAEKLdHLn0nSxPY3GkdhX/T1qg2ZtWHn2rzYeJgPb8yeO3dU+XPV9by2c4QPvCrZK4eg==", "a670f5ca-6ebf-493d-8f7c-eceb7c47f4f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a439ecd2-da0b-4e1a-a334-37da6aa98a70", "AQAAAAEAACcQAAAAEEUZFjgiLDs+17+LuRKFflA7SCauFtD0oQ5GHoXh16QII+7l1dLRb9V+TvDg6/x4wA==", "d00feb79-e4f0-43d8-b0b0-a30b05d4cb3d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8425098-db4e-4f7b-8640-440fa6e6bf2d", "AQAAAAEAACcQAAAAEEbDCb02RZ4MAQhTZYLuFYGARUbsxucrrZVT6JHek/vPMs+7VMIaz4ehxm1rIpfgww==", "6d67fcb0-c2f2-433a-9543-97c6fad204bc" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6566), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6573), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6574) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6577), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6554), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6557) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6747), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6759), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6751), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6742), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6754), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6762), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("2d3971cc-4714-4e03-89b5-e55a37bbd815"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7040), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("3a665008-8d47-4f38-9753-e1235d96c6a8"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7037), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("a929e752-2677-4b87-8433-1f6a8d453389"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7032), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7461), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "Rửa xe....." });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7458), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "hỗ trợ tài chính ....." });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                columns: new[] { "Created", "Image" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7454), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7470), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "Vận chuyển ....." });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7464), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "Giặt đồ ....." });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7466), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "Dọn vệ sinh ....." });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7443), "https://res.cloudinary.com/dqqqgyqjl/image/upload/v1698421423/opuaf4ugi3y5iutu6vvp.jpg?fbclid=IwAR3rtgIeRmGXgoilgjIh0hupzfpXJCv_rArlNgBqTMkgRYwPL9wV0HJ9rEU", "Sửa chữa ....." });

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("07760009-74e9-49dc-a286-3885fc816596"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e49e2e39-8eca-42f5-8cfc-5deade7e331b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e587848f-e7c9-4d8d-830c-eddb838cdc25"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8729), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8723), new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 21, 23, 8, 797, DateTimeKind.Local).AddTicks(8711));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("2d3971cc-4714-4e03-89b5-e55a37bbd815"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("3a665008-8d47-4f38-9753-e1235d96c6a8"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("a929e752-2677-4b87-8433-1f6a8d453389"));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 763, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "a47c2a66-7414-4cd7-b3b2-387952fd62d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "d944d3cc-7237-4281-a4b7-6c0faad9c264");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "948909f9-df50-4477-b4c0-3a303b77ac1e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cb25fa2-5673-4144-aaa0-2096a4590de9", "AQAAAAEAACcQAAAAEPjPdyGFnPQ9/vny/hcm3f1TJdWxHOmiLhTL9Ski+uEhJv7T0jOvF+Qlqx1xgsUnvw==", "0726ad31-b381-4089-b183-1e5f3d6da75d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f91c13f8-8c7f-4b4d-8e4b-3201cc1c7cd6", "AQAAAAEAACcQAAAAEB3RPz7plPJuvq7Di6fhIL9zfd9l72fnNWIwoTPeOYX2aEBE6qaC4EHcwIq66rcqhA==", "fcd23776-9ce0-48e4-a497-9f012133561c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf393241-0d53-4ad0-92a8-0cc4f71232b7", "AQAAAAEAACcQAAAAEG6DCDiqz614OxOjrvnGS3CXGy2q35ROB+HCFGZQTJ0vN1H/ukjbpsKBE9bYchdqzQ==", "92b1ef6f-b88d-4935-b444-95c0ea3d682c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b561ddd3-f216-48cb-a959-cc47fcf5575b", "AQAAAAEAACcQAAAAEEuYhyh+mmefkgJm99zVd1TJr/q7STJBkRcD192EnfDXgvgTjymtyz38rdfBWPOMMg==", "57947f46-2c64-4936-b4cb-4ffb52d1640e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4aa6cde-5c8a-43d0-b1c7-769a3f13411e", "AQAAAAEAACcQAAAAEDYEQR7qQs8pwdRsvMQeIueIBhG1sx8xtk/mJSq4mklei/13zzUPIZgoiRl1aVTbGQ==", "95bad86e-82f7-4510-a42c-3640d80eee28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7df7e8-da0d-4e8c-b3e9-99dfb41c6c4b", "AQAAAAEAACcQAAAAEONR7mi5OyKl2WFYeZHObAD/rti6b5eVAGyvHmz2L74HwDLm2HYO+8VCa8Dl6WBYhA==", "1f770002-90e3-44ba-833e-4c0f73915f75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9617612-c586-455a-805b-bfc18d063ea6", "AQAAAAEAACcQAAAAEDCWoptNp3fkTxeFSXDoIchFv97Z85GNpXoE+yKEZfi3+M5m+ZIyX1mTYbpx5YPQ8A==", "68caca1c-1a87-4d94-b9fb-f13a1c714abd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a88bb1e4-bd21-4dbd-9c53-468cada4178d", "AQAAAAEAACcQAAAAEBi2UF4o0hRVucUjFiwX6LlIuYGBv8E9hescsMeH9YPRtXWmeVXX+tQc+QRXVpRjWA==", "2bd943dd-3e7d-4dd2-9cdf-0ce8a80a5285" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "638bb9cf-76ef-4b1c-961a-2e71c2623fc5", "AQAAAAEAACcQAAAAEALjMra6/S7C1QlpwMz4xTzUgZSE+/s3CgVqVlgjcQ0XMN11f7XNF/u0yRrfu6YKHA==", "c4f2c792-6b34-47e3-bff7-996b7a03617d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08c7b48-b773-4dfd-bc33-c5b184692de3", "AQAAAAEAACcQAAAAEJ6wlvHwsUgppf2wiQsDDejvF8XoeRbAYuXJoossOzgCTGvf0vBAjSkaqq2yEInfBg==", "c631563c-5ba6-49fe-afb8-98b76a8ce76d" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9441), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9437), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9457), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9458) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9429), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9665), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9706), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9670), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9612), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9702), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9711), new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9959));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 845, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("441f8556-e3e9-4db4-8d2b-67feeb32464a"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1069), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("7448f3f0-b4cd-4fb7-862a-495c7dd441b2"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1053), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("c093b4b6-3efc-4146-9b1a-362a46a654ec"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1073), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2040), null, null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2036), null, null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                columns: new[] { "Created", "Image" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2032), null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2049), null, null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2043), null, null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2046), null, null });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                columns: new[] { "Created", "Image", "PackageDescription" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2013), null, null });

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2218));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("07760009-74e9-49dc-a286-3885fc816596"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e49e2e39-8eca-42f5-8cfc-5deade7e331b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e587848f-e7c9-4d8d-830c-eddb838cdc25"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3817), new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3809), new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3807) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 8, 16, 12, 36, 846, DateTimeKind.Local).AddTicks(3790));
        }
    }
}
