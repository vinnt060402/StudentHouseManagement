using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class InitMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 54, 59, 644, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "032e22dd-1e7e-4791-b141-caa57f22aba7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "9990f82d-a3d5-4812-9932-773a6a30672b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "f402fd26-331e-40c7-a2a3-609996dc60a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b32d48-a11a-4e95-b77b-90e090a486c2", "AQAAAAEAACcQAAAAEOT7iBkclLxUkD4QiOQD1dbbKsLAz91zEic1OzxBNTZ3ZuwtGC9t1jjTiR7y7/vq4A==", "30476ffd-45d7-4f1d-b93d-08678623ce49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0df6c77d-ce82-45c1-98f7-fe499bf02d8e", "AQAAAAEAACcQAAAAEG++CZYQ+T2q6FAbNJxNVN6TAcK7JEGGnaMrtHHsTjYuZBQP+wnmybwsJGBc6COXMw==", "1d822b3f-d2f4-48af-b111-285b86c41a75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f235f56-5225-4233-97f1-ac37b2b5f2f7", "AQAAAAEAACcQAAAAEMyLUiTVbzG+PDRWbwkSje1kTUsOzuoap6amx2glixY5e2ArByugZmhrKXsUI0fdUQ==", "e844e583-83be-4292-a766-0af7d3f0750d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc6c2372-0b87-44c5-9255-47b33a1b5770", "AQAAAAEAACcQAAAAEG5a1Ep/sM5UoHeupRhiNvTrnLQ1a71agE9oGBYE1Hk1lWVzMtzfKD9nQ78olKHkFA==", "90d59afb-8e92-4243-a447-f8de6c41bc76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5412a8ff-21e2-4a07-a5c9-0953073d108d", "AQAAAAEAACcQAAAAED9T+bPYt3y6WZ5TL+PiwdxMVlmNmAw4kUiic9vNYg49e8TZLWqxMZDxq9x1rvoEfw==", "db1d6de1-8272-425c-871a-4787e877852a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fce7035d-38f9-4170-8d00-1bdac076137e", "AQAAAAEAACcQAAAAENRXrcI03PmJEIAHDQm7N0NFyHIRi61lMEZOp7I3nxpDBlvuE/2mZzvdvhb3Ovmeag==", "231d072b-8448-4425-9a86-d57233367d6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "781836e0-9614-4919-9463-e8fb95621a51", "AQAAAAEAACcQAAAAEFkFawmxECPDZyHsbQDkfl5IyRhEcmcH4q+7vtJ79Sj4/7qIFtTDi9HYb7YBWhBdMQ==", "9fd59020-44ab-4c37-93e4-09cc1c74eaa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0cbdec7-f95a-426d-a1dd-0d407068f241", "AQAAAAEAACcQAAAAELjF2Qo9ZpmtNr/z+n0pEgwv+Eni/DaD2bxctXN1TF773PapnrG72CY0/8auTpAHKQ==", "812de10f-4fa8-46cb-8fe4-5bf06cb6b18a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "550e9fe2-43ee-4e5e-b1b6-89344306c923", "AQAAAAEAACcQAAAAEFdZ3o0ZA6AoOHQZkS8uy3uqHMz0uxiVVvjYaegAd+WJNxMgP0D8oW+4Qr9vVaxbuw==", "76ea003e-1822-451b-93f2-3d99c7762f7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b4724f0-72fb-4e25-9db2-a2f30996db03", "AQAAAAEAACcQAAAAEFKTcERnS+vNVee4VLexb7Hj6C69xBBM+OrjfWQRrkBGHaAC1//GW4dv857f/czOfA==", "2c451dae-956c-4a80-8b18-a68c6939fbf6" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("21291667-7546-4825-9bad-840d648900a3"), "dọn vệ sinh nhà cửa", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4781), null, false, null, null },
                    { new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"), "Shipping", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4776), null, false, null, null },
                    { new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"), "hỗ trợ tài chính", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4779), null, false, null, null },
                    { new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"), "Rửa xe", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4669), null, false, null, null },
                    { new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"), "Nấu ăn cho em", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4773), null, false, null, null },
                    { new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"), "Giặt đồ", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4785), null, false, null, null },
                    { new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"), "Bảo trì và sửa chữa", null, new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4783), null, false, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5184), new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 54, 59, 728, DateTimeKind.Local).AddTicks(5170));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 10, 17, 11, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "79bb17fc-503d-4eb2-a8b5-cb9a4bd811e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "69a0c716-f71f-4352-b72d-d5c445586673");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "5f7b6c26-c87f-4a44-85c9-e68c87217018");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "481230e2-a960-43b3-914b-3e2582080363", "AQAAAAEAACcQAAAAEAG2UFHFVRsBnLmUaLlpInSBXP51YotdxBZ8U1N3ATI6sLMESrmfcqa78gPaW9y4OA==", "5075bf37-9071-4762-b5dc-be0c6d158584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21ba8286-f383-4f62-9d95-379561277e4c", "AQAAAAEAACcQAAAAEHTGjQojEgQERkJmrJpjMzty/HCkG3Okzbh5xZugx/hKddOqHVNos1qt9sNfAf1dRQ==", "89a0254e-5b17-4422-937e-a79a9e2792e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f872b994-580b-4cbf-97d0-1e38f22b689c", "AQAAAAEAACcQAAAAEK5Xl85V2pja2ZpB8AqAVGYFXcF8vhvuPewzBuOByo7XyfbtwdYqaAig2cU7jTxIJg==", "c12a1b1a-bdc0-46d2-a0a1-9bc32767e23f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d82bd16-d2c1-449a-895c-653cd4f30b21", "AQAAAAEAACcQAAAAEG+GVckM1+jvo6ckZzgM0v9ipFr57O5ym18D3fJVDFdHCdcjlmRfZGSrog31fmbkvA==", "5f8d3a6e-2699-4c48-a5e3-30765ba4d34a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34e9da6e-c004-4ece-9937-488dc6e5fde5", "AQAAAAEAACcQAAAAEAwP4WD8WdPhzkLa5SLjnZNmDYO9XZvBZo3KQrJAHltWMqj950Hl/NvTESIyMnXJsQ==", "75d81da9-f837-4996-8bb9-8dd425df0078" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfa50544-88bf-4532-b640-d29c8f50bebf", "AQAAAAEAACcQAAAAEBAHMuwhDQMyFA7PeZAxCHTaAmpPrCigKIV15Xa301Hz9bg77yyoYpmw0A2BOE8PFw==", "476aca64-bdea-41a6-882e-1750a218e941" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ffd3bbe-229b-4ec6-93ed-c4deb6b45b5b", "AQAAAAEAACcQAAAAEFOBabw/R7yUlDXI0WaSo1Wn4qFoJn9Ft4K8dOyrWgv0PsEJp4gaVsqGzvxNXd3ENA==", "1eea645b-e2b2-4d53-9d83-186da88499c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a84e6e1-eaf9-483e-b524-00e30b9850ef", "AQAAAAEAACcQAAAAEMuzjHjpW4qT7tcL+N1iMoUn0eITm4qmMRFXHY6a6C3nD5sq14LWEzT4/Z7wCEHZhQ==", "d5e8d56a-76bf-4b77-b5f8-18c8b166046e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa151d10-07ca-4b0a-9501-a87649cf6e17", "AQAAAAEAACcQAAAAEFE0T05t4TdMD0nx93lfdtV97BP7CTuSO/MVjIvUoiEQhFskOuJ87Z11XZRUQHiKFA==", "1e316836-ac05-4e50-89f7-0bf7151429f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7becc896-823a-4a54-a22b-bb855043faa9", "AQAAAAEAACcQAAAAEFx+2x5c3qGP2wTvaPVbjM8SYiEi6C+ME8TowcVwD5v7hUcmeGk/LD5asVgUuULJBA==", "1ee2a550-4b8e-4902-9f44-56bb5f11b072" });

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6577), new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6570), new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 22, 23, 10, 17, 88, DateTimeKind.Local).AddTicks(6555));
        }
    }
}
