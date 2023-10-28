using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_Booking_BookingId",
                table: "PaymentMethod");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethod_BookingId",
                table: "PaymentMethod");

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("1cfe8640-ca68-4c3b-9e4b-903c79a6d52f"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("87c79e71-4599-4da8-a459-45ee502b016f"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("b9bacc80-35c2-4dc3-be95-6c18fb86d07d"));

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "PaymentMethod");

            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentHistory_Booking_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Booking",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentHistory_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 361, DateTimeKind.Local).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "c6f4547d-3d80-404a-b5e2-b3eeda7a9026");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "82866773-2df8-4231-9c04-4cf43d6e8fa4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "42dae34e-9a0d-4ea7-9283-624585558c92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7cf7fbb-1eea-412b-9085-99f492cc9b83", "AQAAAAEAACcQAAAAEIwXDLu033cjcpldvjWpI3xJrS8xQ5xoFnUvvAE1iS0fyk9I+GaODCGZeqtdbxHPeA==", "7c4b628c-1bac-431d-a2c4-de00baed52c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1535441-0cfd-4431-9aa5-7c04a07f56d7", "AQAAAAEAACcQAAAAEHyEuxl9PnVXReiHVqYHOTct9U1tAVW4bbdVSv2ZXRIclIvfy4RIUR6tdMkaeH6MUQ==", "207b3ba8-86cb-43c1-8ffa-8dd4d87da0e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90a79f9d-68d1-4fad-82d2-dc4948da2b10", "AQAAAAEAACcQAAAAEPfgJYV/s3q8cWzrbqkWA3331ITyc9eRteqDinQsRJfOJrmvumlk+W/rnuYgmEvfLw==", "e0c40f84-cb17-488b-bf0b-63b8c2bca6e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dee1563-da13-4ae6-93c5-708353e4f362", "AQAAAAEAACcQAAAAEHJaev+Nhz98c+y1tmnxUce1jmutknfVc9T6BSFvuLXonvN0Kip0V604xDD5I8BhaQ==", "e502256e-de81-4858-b30f-0a50de555dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33de81b-139e-409a-bad3-d8bcf2c66a71", "AQAAAAEAACcQAAAAEKE5qDD0T13fhbKEKi19NRR6s+5zjQkbN2NYZdxGR8PBGUFXyYLdj/DAeQmumVIs/Q==", "457bcbd8-7b04-4696-b784-01aebad70dc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45defba1-6c0f-410a-b92f-169b4a5963b4", "AQAAAAEAACcQAAAAEOdd5cKW23mCambKtFmlVvbexX7dFbIxYOYrm3jNBZWCkSJB970AJV2j5FD7XNB5/Q==", "164cfef6-06d1-4419-add8-a9b1a88ae585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6bd16bc-b7c9-448c-9b23-d5370a9225f1", "AQAAAAEAACcQAAAAENhqVmi7AVF1gU8m1i0XU+pj4nMtx5FykNZr6FZ9IYMrdmozQW+FDX+kW1hU7xg73w==", "8e4e2a6f-9b91-498f-ae72-8529dd31e2b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cfb8aa5b-0719-471d-b588-2a6d80e10763", "AQAAAAEAACcQAAAAEGmoAy423KlTfTQc8wSqaA1t7rpLYx6NlpR+a498i+h+ydkPndVKh0E3L8GQRX4UmQ==", "2603a5b2-0459-4693-b58b-10d10b487cda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2ea7d27-b35a-4438-a7bd-b1ee7a185c44", "AQAAAAEAACcQAAAAEMNeDrWcv7fUXBPhRhdpYkc+6tdyHnISc49/lCVeKrirLMDo03C3NxgyQ6vFfl8xOw==", "f03f5704-d8f6-49ec-ad7a-5976413ee59b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f811ed7-1e2a-46da-9a13-0f436c2db25e", "AQAAAAEAACcQAAAAEMmocOPoo/Gy8Bht4whokywY6zDswTI10t9I9/kq0YmEDIAU3oh15gx8svIcnYO80A==", "6d48ddb9-e011-4529-a8ce-7cd8d3ed05b0" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4547), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4541), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4561), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4566), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4534), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4787), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4799), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4779), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("5d895d6c-8cc9-49a3-af20-fc30fa66f8ed"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5381), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("69a3cdcd-d1c8-4bb0-a604-b8d7c18542d8"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5375), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("87f066f2-6f8c-4122-a47d-0e079ab1d533"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5388), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(7000), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6992), new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 18, 22, 57, 59, 437, DateTimeKind.Local).AddTicks(6979));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_BookingId",
                table: "PaymentHistory",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentHistory_PaymentMethodId",
                table: "PaymentHistory",
                column: "PaymentMethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentHistory");

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("5d895d6c-8cc9-49a3-af20-fc30fa66f8ed"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("69a3cdcd-d1c8-4bb0-a604-b8d7c18542d8"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("87f066f2-6f8c-4122-a47d-0e079ab1d533"));

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "PaymentMethod",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 872, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "2e186782-adfd-4b76-b393-6eecfa4683d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "8181d143-8221-4a9c-a6c2-bfbe9646b398");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "334559e2-96d6-40ab-95c8-a6b633626238");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61277a8c-5f86-4d6f-9a7e-18d5722ab0f5", "AQAAAAEAACcQAAAAECmAoA6xfp5VTIsoLLwZFNw3EGjGAi0zPnMiYcjQrxIJgRDNLCmpU/FDKxZ6uSftdg==", "98bf5c4a-bf90-4c68-9cf3-118f747eecef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d254c9d5-c898-4862-8103-c55ddb428ca6", "AQAAAAEAACcQAAAAEIVkTKBBcapsGgDjfcJ30v8ucPsGbYVNbzn8hNZ64IA+ppM5hByVZTaCWkttT1sTOw==", "86c916f1-cdf6-44f3-b55e-38773ecc6277" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07fd21e2-b5c5-4708-a43f-af814917f813", "AQAAAAEAACcQAAAAEImvWKHlItvdIkCROEE3s3GERnN9BenDlYs6oEDd9K6BLoZvFALGNZ9Kzqajid5Nnw==", "3315693f-a693-44bd-a091-5a32ab1abe84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e37721a-a492-43a6-842d-5d43165bfc2e", "AQAAAAEAACcQAAAAEJnJGy2ROj1qfcqjhVB0IsMbRKqGWtdnopaFr3OtcNEU6vsLviuQ1aA2neEok1xVDg==", "17fd2b68-e341-4a87-b5a1-b338a55c5f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d47a24f5-da51-4eab-aae4-1475d45fa340", "AQAAAAEAACcQAAAAEIAkuAmBavIUWwZT+T5Z49X6i6Z4eAYh3U2lYyZYhkNvbQZ7cE5L7e4l9PlNifx75A==", "cd82ffee-ceb3-4b42-bccb-0e2303965a94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bb62bc7-ec21-41c6-96b6-171d95e69023", "AQAAAAEAACcQAAAAEOlm7z/1eCoh2FToLqCAYfZsOtGQ+L/jk603y+ymgF5mOekKrfAeowZGRJq9daXWaQ==", "bbbcae14-afbb-45d6-b50d-cc90ae1bf49f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80066227-af3e-4574-8fd3-74b5e2ffd2c7", "AQAAAAEAACcQAAAAEOHCfrlXhrYfhFlJFV4pw2nFXk8wPkYVKs3swK8GGmjvEnhXfsA7LyLxx0lkPHjINw==", "085c716f-feac-4c81-8ed6-c290cacd6e77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eae6813d-577e-4c01-ae89-758e2b4a1a87", "AQAAAAEAACcQAAAAENVo63Wlkuv7GIylU4E5No+nW3t5KPmLwB2wyWXL/FQ4MkM+HDqhc9bp6s+neIad5w==", "57ef5d9d-1691-430e-88be-77fdf01d1ae2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975b22ef-a1ea-4831-b007-b26cee6b540b", "AQAAAAEAACcQAAAAEIT/WOR9oKnVOVngu2QpapXNP3uWkiXbtxwbyctvgmb5Y5YkAwyDDM/Vh/wmOb7QEg==", "b24d101c-0879-4b5a-8b20-783e381fe3b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10fb5df9-4c2e-49b9-a0d9-6a3dddd478b7", "AQAAAAEAACcQAAAAEMQYPk+UkXUuL+vAOQsV6tQ6lcuwdJq7og1Dq31ZkyVQq0jwm+bvyU/CXrHEyq7Z6Q==", "180cbbf1-53c7-42b6-b5a2-066af22d7591" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4830), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4826), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4820), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5141), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("1cfe8640-ca68-4c3b-9e4b-903c79a6d52f"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5571), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("87c79e71-4599-4da8-a459-45ee502b016f"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5563), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("b9bacc80-35c2-4dc3-be95-6c18fb86d07d"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5568), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6381));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7183), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7180), new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 49, 26, 937, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_BookingId",
                table: "PaymentMethod",
                column: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_Booking_BookingId",
                table: "PaymentMethod",
                column: "BookingId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
