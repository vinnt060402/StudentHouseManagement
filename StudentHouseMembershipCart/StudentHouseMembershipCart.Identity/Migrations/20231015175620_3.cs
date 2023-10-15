using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryStaff");

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("5e977813-d696-46e3-a767-76c3070cfb86"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("7f0bceb1-a1b9-405b-a0d6-1d933a2bb846"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("f86cb7d0-8912-471d-9a3a-85284fa372fb"));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 218, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "b4097b42-e22a-4b47-9d84-6b90ad8c1044");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "7d07af2d-873b-430a-80d1-38671255124a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "6aa50dd3-1387-4840-8fbe-dfe8671a37b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39afc473-babd-43ab-bd2c-13fc71087706", "AQAAAAEAACcQAAAAEEJGFC8Hqsw/1YOi20Hg9DQjQRkuLzxV4nIvcD5UQZ46+gqQQGWHIuANU59HDLDBKw==", "0f26985e-f269-4f33-af53-5f542a0663bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2c260a6-d507-46a1-b453-1004cf776cb1", "AQAAAAEAACcQAAAAEGW27ic+IfUOMaw5dCgbqCfoUjwEQKsONREB1ivNRmH/FcleqrfSwmm6iFXbEzYttg==", "c2e412ae-94d8-4f88-bba7-ab71655d6665" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3e51d3c-d5a1-4506-9b6b-b8936bf934a7", "AQAAAAEAACcQAAAAELix6JUwPpdEfFQemKP340D7JBWocnIC4UJbdQl71V6JCs/UFr0m0JnUotVj4IetgQ==", "0e5c5680-5d46-433a-b45e-ebe16bf042e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f91fd2e-ce76-4740-841d-a0a15fd69c02", "AQAAAAEAACcQAAAAENexdqqn/k79Sush4zIHQnZ14d6zewAouV0O3RLYSyO0vONzbndDH/rZefpWA16yJg==", "b2c1ac0c-57c8-4454-970b-11535701b4b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3889f471-01ad-49b5-8445-e610c066c2cf", "AQAAAAEAACcQAAAAEEdpdF9V+LAcVWeF0NG5i9uQwtvDSmKaKrF1C1no0LrKUEBgqkwLYTIu+SQNs6KpVw==", "3b4c2ce4-2afe-40a5-a237-203ea9956509" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9919412-f008-44b2-b7a5-80924a885e05", "AQAAAAEAACcQAAAAEHK2Ant/P3yiKw4dyaw3DOJTxnf4DdUF5ZuN9E7jVbiPn2suzlL1hUmkui+Q3GWzNw==", "9fec55b2-90c5-4825-8c2e-6f1d12433608" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48d51421-669b-418f-8de3-ea52a1449dee", "AQAAAAEAACcQAAAAEMDGa6+k5VFvpB3toAOkoZiCP/pK5lEzPS4bP4Vjql7K9bnVfRVvsaCwkLeuvmWEjw==", "0470b777-a063-4735-9f25-88561b291c77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85ad1dc5-0232-40d1-91f8-091de572909e", "AQAAAAEAACcQAAAAELHrJuqLRXrqcPxzIzY1o6bnxyRMrnbnpunOOL6e/Z1OyBzQzQtBBUqvVLWL6d8Shw==", "902ae5a7-bff7-4b38-a4e2-4eff0106777a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "324162c2-c845-4a78-baac-6ff42dd3812c", "AQAAAAEAACcQAAAAENV630Q3ybFZnDVvkDv+ncX4+5e0cSXFC0ujcu5ds4aD+3sl3K+4/7npS//rCKfLhA==", "4b5af212-0f41-4d4c-b0c9-cebade27f0e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38d494ce-b170-49c2-b97c-53f2ee49ffaa", "AQAAAAEAACcQAAAAEAYvRiKaB/tshRmhzJWcuxn3ihmqKrF6KoRCxpUxKYn0IHp/a1PGR4nZY5Q/o8V0Kw==", "c19373ae-8fce-4c2c-ae41-a53a088e95a5" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7796), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7791), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8096), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8105), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8099), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8102), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8109), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("0d4fca14-05d7-4d58-aa81-a53878f1dbc0"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8436), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("0dadafe5-5135-4332-a0e8-2731e23f4497"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8431), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("3935626a-42b6-4d31-b71b-66d3e8e57e73"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8439), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9935), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 56, 19, 285, DateTimeKind.Local).AddTicks(9916));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("0d4fca14-05d7-4d58-aa81-a53878f1dbc0"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("0dadafe5-5135-4332-a0e8-2731e23f4497"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("3935626a-42b6-4d31-b71b-66d3e8e57e73"));

            migrationBuilder.CreateTable(
                name: "CategoryStaff",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStaff", x => new { x.CategoryId, x.StaffId });
                    table.ForeignKey(
                        name: "FK_CategoryStaff_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryStaff_Staff_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staff",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 26, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "d24af068-756e-4951-aebb-d639b5ec807d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "aa4c5ae2-5037-4ed4-99a5-085cf95834f9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "d22e9a3d-609e-4e7c-89a4-46b7963a0aae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93a7fee8-4a9c-41b7-b848-81ff9c86720d", "AQAAAAEAACcQAAAAEHWjuo6noJvRyQJJ++NqZXpveu1zKdRfB1pzTrjwLVqMWqS8NCx4/gK7HwVspFS8tw==", "a77da773-561a-4cf0-be32-b2fb28cc5e11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "276ee41a-161e-4e9b-906d-1b9634a10d84", "AQAAAAEAACcQAAAAEOY0A0O3+nLNRGmGrQ6U/PuDgdJWrYmMTm969/l98kDbyjtKW465XZu2FNCGamBiGw==", "bb7150f3-4933-4ae1-a27f-a9850eb3b155" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab9bfa09-5fd1-4cb0-909e-29a637eabb0b", "AQAAAAEAACcQAAAAEDj2kmt6l8cO8Xu2hZUuDqqks5zJYyu3mTcwtVmE7e/0ljriMAY9TeNT0A1+9Wp3MQ==", "2d9f7784-8926-409a-85b5-47bffcec69e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe20097d-73b8-470e-8bd2-5840f9d2c378", "AQAAAAEAACcQAAAAELuUWcgJbvMEtwR4/bQLgodt1wxVPqa6bJ+sbW5gCPNx2ZpQYKVvtyaGtwRMLO39dA==", "198b299d-d671-416d-90be-d929f6b42269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2952919a-f1cb-4413-9a4e-5832568733d3", "AQAAAAEAACcQAAAAEN2DFcuwZFUEcgkBBr43hRyVD9lWRuRPPshluJ+S/EiBErt9JdXabG0p0ZoKdRjusA==", "89a90ed9-2680-478b-9a4e-0d02daad5e46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcad87dc-d874-4934-90f2-0bba4b970b12", "AQAAAAEAACcQAAAAEPbSDv+g6y8p3GKVlASSy+qXx24EO7n5+5d3UsHNN2o7969c3JF+1P26wMmibhcloA==", "b762f99b-3a8c-4e01-89b4-3b90bba13190" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8d8edd5-5642-40f3-bf8d-37e1f05811d4", "AQAAAAEAACcQAAAAEG3dbwQOk7EWMe/r4fBcj+e6SggCqWFzD2wq2WW8ZKnCPOxN+gBL/gcTIS/qiPgkZg==", "b1c31883-f190-4656-a916-84aaccb29b3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c159897f-44dd-43bf-92e0-bda4f2538469", "AQAAAAEAACcQAAAAEMeV0OlUvsaj2arUB0KaN2Qyz0sRJqCPja2tr4p3NDtSQEoLZMe2b9gGFkTsBN4wag==", "4a884a1d-6777-49ed-8d7a-ef3cc64b9b9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85cecd44-13ba-42a0-adaa-43f0186adbbf", "AQAAAAEAACcQAAAAEAO9F6vOd3ZuSkBhyEWM41LpzNOaXW6JcFfgTNxeAefUAzacZTcvueKwHh3K4L8bqQ==", "e202e69a-d17e-453a-8174-4d467209080a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "310c0ad1-dd46-4b02-a96d-1ab325bfa75c", "AQAAAAEAACcQAAAAEKeIGDlLAO05NCYy+LPgHDEyFdUwDa2/1VCQZ80/dHS9mCJu90y3N1HuvGOUUCWjeQ==", "898fb68c-9982-4fb0-823d-6a1835b7f251" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8808), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8805), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8811), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8821), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8798), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8966), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8968) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8977), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8970), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8961), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8974), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8980), new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("5e977813-d696-46e3-a767-76c3070cfb86"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9298), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("7f0bceb1-a1b9-405b-a0d6-1d933a2bb846"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9295), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("f86cb7d0-8912-471d-9a3a-85284fa372fb"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9291), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9465));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 90, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(59));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(841), new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(838), new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 52, 23, 91, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.CreateIndex(
                name: "IX_CategoryStaff_StaffId",
                table: "CategoryStaff",
                column: "StaffId");
        }
    }
}
