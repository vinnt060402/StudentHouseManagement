using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class _2910 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReportWork_AttendReportId",
                table: "ReportWork");

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

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackRating",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackName",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackImage",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackDescription",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FeedBackStatus",
                table: "FeedBack",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 53, 957, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("81f9a432-7e27-4b3e-a354-dfaf3f1c164c"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("9388a4e7-ae81-40d4-834c-463cfccb6f53"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Apartment",
                keyColumn: "Id",
                keyValue: new Guid("ee8bd315-0201-46db-bcab-b1292f97e91d"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "0e2dc6ac-eda8-4fc8-a7c1-ff65dedd3927");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "0b75157d-b213-472f-95a8-23224a7eba98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "d47a42b3-7a39-4ab1-a5d7-bfb709786356");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0870372d-a0a5-4391-b31e-a70628c2567b", "AQAAAAEAACcQAAAAEMF8y/Yr/al86aHFijpCyRoRQvYTbS/S6h2FM17QEiOCKExIG2loqU0Hrg9JdkvACQ==", "5d15689d-a932-4b75-a6ed-e5df7627597d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f488d1e-2211-485a-965a-05b4da0e89d3", "AQAAAAEAACcQAAAAEJ/zphKgBm5h7vKRhSKTf2HoN2IhjdDXsAnq2L7j8UzlI6Zk0iNC+Caq0Bp0mChiZQ==", "6447ae02-7fa1-4302-8a32-1a48af50cbae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e78bac97-5462-483d-a217-54563d7c9971", "AQAAAAEAACcQAAAAELVZlW+v7M7mUe8lIRp4I+qvumyBHP4+M4TMUsLS13s/9Vgih6ajgpG+m+Y3uHgiXg==", "1a917a6f-4ac5-43fa-af00-a2234b785d33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49584df2-e116-49e0-a87d-2d83d67ebd97", "AQAAAAEAACcQAAAAEIRaChqxRjY13athkMaVmFBedK5fOsFFjR5pC587FrSZOjjgeLSWjebzAggSTEjjtA==", "a3702fd6-b0ce-47a5-a627-4470daf42ef0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9ae2d1b-08c2-485c-8321-cd70c1186c04", "AQAAAAEAACcQAAAAEDxqlugeF3kyvJudO2ov1ZXIpZEafDleMkvXOltYLDXpLGDuxnUGQxV6TTewXScbIQ==", "b71a9ca8-4ddb-4030-8286-fd7fe11126c8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7c1d2e-6836-4392-9c03-dd693230be93", "AQAAAAEAACcQAAAAEEdW583lZagLyuTtpH/+S3Io6R9ZpPqTOEHYi0/mqwkuXmBo9gnmjTbJTDPvz3Oqfg==", "7fc19432-039f-45f5-9d37-dfc6b6c09849" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23278479-9515-447d-864f-4ed5faf708ce", "AQAAAAEAACcQAAAAEIBp0IqG+0o81jLht/osXiEA7C4YhWZoeBaH5KSdinRIbSOjv462XDzER+XrmzA+nA==", "aae18ee9-eae9-41ef-a68b-575aa30de595" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c30ca50-3b9f-4046-b162-5153d1a544f1", "AQAAAAEAACcQAAAAENqCS13x0OSFo9S9CgAXKh8fWX9gomg10X220eClnkck9QSjADIn87HIbuuFSQ1nrw==", "0110e044-88d8-44f0-a536-9f5d7af2ad48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8f52ea6-15f8-4129-9827-5d964a452b5d", "AQAAAAEAACcQAAAAEGXIRPRSQ2Aqk9PsCbg9yKJbm1jkGyviZxCPy4A/btuJYRgQjffHzED8xqvHrPmcAg==", "7bb29150-d4a2-4caf-851d-902d671083d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3139519-25b7-4057-9a51-33ead53e9148", "AQAAAAEAACcQAAAAEJ2tQC39uBvB0D6okYvKgjdFyhcI7QmE3IDvCv5p4JGiX56X0pSISmhK+l9uajaLog==", "1a4df741-f495-4d01-bfe2-6ec1ea41128a" });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("046b87c6-e4b5-4f08-9951-9ebf4bc20993"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("275b2720-420d-4b33-835a-4651d92f1390"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9109), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("742a0cf9-14ae-47ac-963b-03a096ef80a2"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9118), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("ccba7e84-40ed-4d32-b98f-e3e5181a924f"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9126), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9127) });

            migrationBuilder.UpdateData(
                table: "AttendReport",
                keyColumn: "Id",
                keyValue: new Guid("d9a5af9c-ce76-43ab-9fc4-46442e495f59"),
                columns: new[] { "Created", "DateDoPackage" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9104), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("256fa734-309c-44a9-af6a-8a97866fbff5"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9263), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("3533264c-3bdd-4744-9023-481f5ec99cd6"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9273), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("85d3da16-8f33-4c96-9792-1e6e17d3ecc8"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9266), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("8c5bccd4-56b6-4b76-8d5b-888872a8b71f"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9257), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("a39735c8-440d-440f-9a5f-932164975749"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9270), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Booking",
                keyColumn: "Id",
                keyValue: new Guid("ce7fdf8d-c130-4e5c-b2f4-6199153a5926"),
                columns: new[] { "Created", "StartDate" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9276), new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("1f4d83e2-3713-4fff-9fc5-5373c20cc2cc"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("2408cc34-d225-448e-979e-014d1ec860a3"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("a2a79fb8-a2f5-4f98-9b36-22eeb1a1215c"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("be08997c-61a5-4859-98a2-459c93dca574"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "BookingDetail",
                keyColumn: "Id",
                keyValue: new Guid("cd4de656-dbfe-4797-8f8d-130ded6a6774"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.InsertData(
                table: "BookingDetailStaff",
                columns: new[] { "Id", "BookingDetailId", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StaffId" },
                values: new object[,]
                {
                    { new Guid("13b8c3dc-e612-4afa-babe-5a32a7af1816"), new Guid("2408cc34-d225-448e-979e-014d1ec860a3"), null, new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9608), false, null, null, new Guid("a8ded7dd-683f-4231-8c47-560375560eea") },
                    { new Guid("8aea7101-728a-4274-a4d6-34e75778645c"), new Guid("be08997c-61a5-4859-98a2-459c93dca574"), null, new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9597), false, null, null, new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479") },
                    { new Guid("9175de86-5589-4ff2-b982-4ba2610e98b9"), new Guid("035c6d92-8fb5-4635-8acf-1821e7296dae"), null, new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9605), false, null, null, new Guid("c085539d-76bd-4fe8-9444-12c21de6610b") }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9732));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("0730329f-ebcb-484d-8dd0-e32bb3de78a4"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("2372f547-375e-4f88-a726-37643180c585"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("53838b2b-a19f-422a-8f62-6363476c21da"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("6863f4fb-eef5-4f26-8fcf-8736aa8ade95"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "FeedBack",
                keyColumn: "Id",
                keyValue: new Guid("fc2e4d71-9e75-40d9-972c-a36ecad80887"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("4da4e6ad-3328-4f03-964e-c31e1a8421f3"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("649ce925-0cd1-4cb2-9fb2-4c6ae8ff521e"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("68e3bf2b-2bd7-4428-ac39-148f1a186cba"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("b17c9d4c-b164-4097-8d5f-03d2246da758"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("c0e52326-c1c2-4c58-a5d9-d6a768e0c7a9"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("d0e4fc80-5e14-4f54-b3d3-90fff85df063"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: new Guid("ee75ea18-f6a7-4025-84b7-588ab1c6bf2d"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 17, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("95786a5f-3068-4628-ad2f-2bcc70de8661"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("b7a93559-d76d-40f3-973e-b550dbc8ad74"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d036463d-887e-4a3c-aaab-4fce577e43db"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("d42d5044-1e4e-4c77-8e6e-0fae60ad1d17"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "PackageService",
                keyColumn: "Id",
                keyValue: new Guid("fc2c6cbb-1d78-48e4-be82-fc2870275030"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("07760009-74e9-49dc-a286-3885fc816596"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e49e2e39-8eca-42f5-8cfc-5deade7e331b"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("e587848f-e7c9-4d8d-830c-eddb838cdc25"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("006aeb5a-7574-40ca-a73e-da840eceb810"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("0dbd39f5-cd9b-4e7f-8d53-851014a4efa0"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2429516b-5620-4838-912f-f4826f5d28bd"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("2bb177e5-2180-4ce0-bbf2-af5bc9eeefcc"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("34303ccb-2c3e-4cee-84f3-b3352d67d790"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3a60f12a-8c9a-4985-a215-0c55438f363b"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("3b0ab201-058e-4314-8b5c-df3c7d831ddc"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("62f16917-b22a-4b17-b93d-5a9f35c5b8f4"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("6db6d0cf-a3a4-4c12-8f0d-41c4ff579ae6"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("83326cb5-b249-4ba3-aa98-87752a99df53"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("8725e1c4-e76b-4563-916b-a668516237e2"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("9ffbfc1a-45d7-42d1-b216-00f328fe1638"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("bd3db160-9064-458b-9974-aeaa876d1ef4"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Region",
                keyColumn: "Id",
                keyValue: new Guid("fc4cfb1b-063e-4f31-b25f-b0853a401350"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("120e1aaa-eed0-445f-943a-20bc12f4b883"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("991b3ff2-962f-439a-aec6-051d522a8904"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "ReportWork",
                keyColumn: "Id",
                keyValue: new Guid("bd3d72cc-551a-4abf-b358-d6d980bddb67"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("16209d12-4e67-41e5-b419-f3285b8958e6"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("1e064aca-ef1a-4705-9931-a49a807765fd"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("29140864-8e89-41b6-8fd7-a440800e6e00"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("30743744-754b-4a87-b828-6186ccc7ece6"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("4fcc0684-ad33-433f-9338-d9e949b6f0d8"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("6bbd52b8-a4b7-407e-baba-a4f4fca65d24"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("7635d149-2a74-4562-b779-c81056594bfb"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("9d3a81b8-a470-4f46-861e-772d55d73668"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("a9a16dcf-6c63-4392-9ec2-be727fcd6081"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("e430fcfb-de6a-4c64-a6ca-b607e1357843"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fa87282b-0c28-4dc7-831d-e1d8f8026270"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("fbda5a61-c0e1-4039-97a5-841fb84ec5ce"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1219), new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1215), new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 10, 29, 14, 59, 54, 18, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.CreateIndex(
                name: "IX_ReportWork_AttendReportId",
                table: "ReportWork",
                column: "AttendReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ReportWork_AttendReportId",
                table: "ReportWork");

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("13b8c3dc-e612-4afa-babe-5a32a7af1816"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("8aea7101-728a-4274-a4d6-34e75778645c"));

            migrationBuilder.DeleteData(
                table: "BookingDetailStaff",
                keyColumn: "Id",
                keyValue: new Guid("9175de86-5589-4ff2-b982-4ba2610e98b9"));

            migrationBuilder.DropColumn(
                name: "FeedBackStatus",
                table: "FeedBack");

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackRating",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackName",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackImage",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FeedBackDescription",
                table: "FeedBack",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ReportWork_AttendReportId",
                table: "ReportWork",
                column: "AttendReportId",
                unique: true);
        }
    }
}
