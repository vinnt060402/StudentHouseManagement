using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "PackageDescription",
                table: "Package",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 797, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "bde3c4df-8c34-4e6d-99e0-ce08cb8443e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "a1dc37fb-28dd-48ac-9e06-9e23b6ab0d4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "865c9df4-8617-49d6-8bf9-36cfd6b9896b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb18ec90-85b2-4910-aaad-8d43e7aa4fb0", "AQAAAAEAACcQAAAAENtUXLe4Cal2LftrsLe0Hh3qLgjUObPLhWBb+u+pwQ4VwfBfs+5qPetKHCHKnmgRQA==", "3dbe999c-1129-4cc7-abeb-8f16d9e1ff32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4b42ca8-842c-4877-b995-23fccf66f5f1", "AQAAAAEAACcQAAAAEISSBGPdjM3yEZfslnNB22lQL4qHsl3SsgWb9JTJ0zmsNpyP4+ZETa0pifdJhjM1PA==", "7b500a86-2f96-4db1-bed3-d1c68175dce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89efe66e-0931-40a2-9a1d-bc3697610048", "AQAAAAEAACcQAAAAEEkgSM9LMUmUoo8yOHrhdFlcDQOh7rT+ZP4mSZHqZ8rlHJWuDwD7diFYybdZvau1Aw==", "061fe70e-8291-4137-829e-bec89024e189" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7aa2201-586a-4a7d-bc35-b48f0e91ed93", "AQAAAAEAACcQAAAAELS7BEz2uUcHdoQ0mbjbVHDIhVCelRt5/+zqYo5I8h62dz8Q4CTl6U2ET3UDZTPcHg==", "4f309864-83e7-49fb-8a49-91e8d05f3b6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "057a6fa2-91ee-4bfe-8eab-b02656b4b1e4", "AQAAAAEAACcQAAAAEMgjwGNhBaib2KzqeHFDTe2+0XCfPQ27ZlhAiKn4rFFbDy9rwx5fruvTaEmpSpAUTA==", "9e662482-0c74-41c1-bf25-812b2a484cae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1773e20f-b680-428d-85e3-2d1546800087", "AQAAAAEAACcQAAAAEP261Ga+oFKZ5zpvc4N7l6Puiaru5z1m+OD5ND47YOSgvPbzXwhwz3gxdmWPPV8Uhw==", "73dfae1e-4782-4bb0-a97b-17ffbd73aa43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaf6df8c-1f8f-466e-8efd-853d5b96cf62", "AQAAAAEAACcQAAAAEAIX/Ne/8whJuFhCUrtXYubixIVPhvTPm9KuMsCDuxD/1tgkum0tcDzryTAC3HgVOA==", "128f54b2-f28e-4295-8ec4-e88bbfa3a96a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b408ee0b-f789-4c39-b6bb-c5544cc4adf7", "AQAAAAEAACcQAAAAEMyJiQEVP71vQ6/ktX3GpMtNyGF7CtoRDFkcmr3ZedkKQqSix6TfDPSrhcen0xfZXA==", "480ae93c-0f9c-4a04-8193-779d99aa753a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a927932c-3e96-4d36-9bfd-6acc3760e74f", "AQAAAAEAACcQAAAAEI+tlpWtDae45wA7/EwJM92Voispv6ZKNrRYF9sZVvavfzIpLMY7sdlbOxe1wGYgAg==", "5f594465-11d0-401f-b305-ed3b228cab2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "819bf092-42f0-41bf-b883-2faa5dbc4478", "AQAAAAEAACcQAAAAECyjkWcSQt2QP8oqt/+XFrdKBW+3Opt8XYytTPAwzyvM4aEyhM3Xi1rrmCqM9as8QA==", "f9c26da5-4025-4b9e-997d-37b7575a0028" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3150), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3145), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3158), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3161), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3128), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3536), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3551), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3540), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3529), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3543), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3554), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("80199a1f-6e55-42f8-87da-8c7721b9f0e8"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4025), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") },
                    { new Guid("c2f81bf3-7212-4d26-a1b8-f0d8be9868d8"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4015), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("db6adee5-e6a4-452f-9757-85444e23f5dc"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4030), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4590));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5857), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5855), new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 16, 1, 22, 5, 860, DateTimeKind.Local).AddTicks(5838));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("80199a1f-6e55-42f8-87da-8c7721b9f0e8"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("c2f81bf3-7212-4d26-a1b8-f0d8be9868d8"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("db6adee5-e6a4-452f-9757-85444e23f5dc"));

            migrationBuilder.DropColumn(
                name: "PackageDescription",
                table: "Package");

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
    }
}
