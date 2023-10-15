using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("243069df-d4d5-43bf-97c0-3ecb4fb981d1"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("4d3dc143-5241-495c-8759-0ee7ddf5bbda"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("aa750d01-8c01-45f5-ab48-aa67266eea1e"));

            migrationBuilder.CreateTable(
                name: "StaffCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StaffCategory_Staff_StaffId",
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
                name: "IX_StaffCategory_CategoryId",
                table: "StaffCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffCategory_StaffId",
                table: "StaffCategory",
                column: "StaffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffCategory");

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
                value: new DateTime(2023, 10, 16, 0, 21, 26, 986, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "32de03e2-d9df-4d5d-82bb-f587d187bab7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "0fa301a8-dec2-4a01-b878-885d7312b190");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "06a65517-d0ce-4f55-a6a6-7755ccc851f7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396c294e-0b5f-4e9e-9d24-995a010a1a11", "AQAAAAEAACcQAAAAEJXV0ZaaBlli12BcDkpR7USkSAcQ+Q2J4kJ1coWQ1e6zJsfN8PhIuUyhRir94i3IkA==", "f90e3aa8-41ed-4488-b612-57b51da6e5c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b62e8b6e-ffa5-48ea-a72f-254c2d2a67ab", "AQAAAAEAACcQAAAAEAOTjI5Jqy0Oqz10HZm5MLqhUmt4HawSMa6xvp3C9mrj1MuoPmyz82C+WXFeYdP5Rg==", "7254eabc-6de9-44a8-84c4-413beff8bfad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a22cf1d4-4aee-4f13-bfac-4309239f123d", "AQAAAAEAACcQAAAAENSwPrqcx1b3S0vXP3CoaLoR9pTJRjjqSRlEVeKfM1wB17Y3tkybAc51flV7vqP1fg==", "c6207fd7-6bbe-4688-b72d-6d4e7120abc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b45e1f2-dc98-4030-bd3d-52ea8a40ed5a", "AQAAAAEAACcQAAAAELXWWezOKLtHnKpHAWm1E8TNLgtj6kaNr3UVbl1+chZ94aF4tcopbBMa7+2uF2cWGg==", "b3342784-e35a-452e-a75c-3cd0da2790f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee58aee0-5da3-4a52-9842-97ff709f9a30", "AQAAAAEAACcQAAAAEINHHKLjQH6vB/vAE+/i7aIReQhJ76jISvqb8TJ8ZyMLp6ZbBXNmcMZkllhxLoNq+A==", "204d5c99-2f3a-4720-836c-2f392e8f9e4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "530424e7-d7b1-4681-b904-13cd5e6b5260", "AQAAAAEAACcQAAAAEEaeExy7Z9/N2cIdDPi04wmi4ghnP56wNHyRlJQJs6ph5s0YoHe2k4kT5uI0qA66/Q==", "27772c2e-de1c-4639-90c7-f737d7fc39db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb63cb60-5b85-4a28-ba9f-b9d3649b21a2", "AQAAAAEAACcQAAAAEJ0qf885hCbApqKkp97MOym7Jaf37Ad6w1Y6zWwrCQuwhgqlLpA3T9K4eaKF1846xA==", "f16bdbf6-9cc8-4403-9ddd-b5f138097c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "438960a1-fa62-4c44-9a2d-d412c34ed0bb", "AQAAAAEAACcQAAAAEO8fQnwD0vD3D7cxhmpp3zVQeVtCpeyzZs7MWymGkl+iRHc3a+K8EjHafHWDxehRfA==", "8ea41cae-a460-4973-a29c-ff38cc77a06d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78179bc7-e255-4cbd-b0d3-d84a29c40d8f", "AQAAAAEAACcQAAAAECAx+ANEhMwCoHzhfO+QDvztexE0YoHgcEtHKfpWM28Q8PQDlcg0rYLrGLHWiBosVw==", "7dc92a80-dc66-402b-a8a1-1fb016a6b0e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c69f0a0-86b9-406c-af89-d6929fe91adc", "AQAAAAEAACcQAAAAEG4bKMFY1i+LTiXhzHLcTcX0tMoXwv77Otuw+2KITlFI6cFcxLelpRdXQAhe8S/7ew==", "4d614a22-736c-4c39-889d-02442dd89015" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3704), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3698), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3708), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3712), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3691), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3840), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3850), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3844), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3830), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3847), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3853), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("243069df-d4d5-43bf-97c0-3ecb4fb981d1"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4265), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("4d3dc143-5241-495c-8759-0ee7ddf5bbda"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4263), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("aa750d01-8c01-45f5-ab48-aa67266eea1e"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4258), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5824), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 0, 21, 27, 49, DateTimeKind.Local).AddTicks(5806));
        }
    }
}
