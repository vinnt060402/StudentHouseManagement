using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class InitHeheDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPriceOfQuantity",
                table: "BookingDetailOfService");

            migrationBuilder.DropColumn(
                name: "TotalPriceOfQuantity",
                table: "BookingDetailOfPakcage");

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 796, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "390c35cb-9716-4246-987c-3538220f0a90");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "b0e29307-89ea-43c8-8a5f-32c503488da2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "dc24b557-32f9-40a0-8cfe-cf5b76a62813");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7c1c88d-2948-467c-b357-f7cef88f3dce", "AQAAAAEAACcQAAAAEI26yIcxwZYvkKjqowuDeoMJarDs4Ygqvx/3owV8ABN8tBKZpkhW3AgHUbIEToIJPg==", "4f96c396-3e11-46c7-82f2-1bc94a160e8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76efe9d1-18d4-427f-9d8f-7ba5a829b587", "AQAAAAEAACcQAAAAEJUO3/21Dn9TWDF1bAGO1FwXMmNS0ht1n8E4K9eh8PKcZeRlA8x2F6paf79rtrhG3Q==", "fa0f3bd6-678c-4845-9283-a4f0dd10ca30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6937e16-ca15-4ca5-a422-506cacdefddd", "AQAAAAEAACcQAAAAEEpk4z0qeyQIjQymVxCSOL9sSE6KO10m4xkIzHoOz3U78SMdDEzp9fMixz2PLhHOZQ==", "be183d0a-1844-47e1-a696-49aa4dd4cef5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b1cc4f5-bb4a-4a41-92c4-369cac0a6832", "AQAAAAEAACcQAAAAEBALWTZfL/hzNFNov7veoMNag/eqb22kagLEEJEmN5oOY6Ltoe/un/2vhoifyuys5g==", "10840212-4f7e-4f67-a95e-1981265cd7c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "942473f9-02fa-4185-9a3e-1c0903d593b0", "AQAAAAEAACcQAAAAEAuzrGBEqROCfNQBtHGuJmfvazrw1Pr5l9Ay8dk2AeqHUcW5kes/ehoCV7jNU/PPrw==", "0dc321ed-2826-4041-8d71-c811dce4364b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae9a8b6-b909-41d1-b6dc-daaf1ae7621d", "AQAAAAEAACcQAAAAENH9M6Cc2kvxHl5Dl8dfkaflCRYka+NyrbkVoxBef6zp4uADefdYVI2dG5VsFP9ZeA==", "c5ab612b-c2ca-413a-926f-31a24293c3f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aebdc28-c5c1-4a35-93eb-acc44aeb2c87", "AQAAAAEAACcQAAAAEK0UyW6QHhW9LomGao1fcBhTxLcVdGD/BIUpBQpm5mFWNOpqj4Mv/BHG8H613qkcSA==", "f05f948d-bccc-4d79-a488-8c50e15c3f4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfecfe2-2d4e-4ac7-a3ee-69f4b42b4883", "AQAAAAEAACcQAAAAEHqTeA5Yekqwdwh+3ifcp5vt7VVQv8Lb6/XHSwqkBOMM/Mx/w56HIWykQRJguiLZlA==", "1fd6744d-48d0-4b47-b0ad-34c96de2c5c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfb40aee-be3f-4114-a1a0-96284c272ea5", "AQAAAAEAACcQAAAAEFONG057b7meHAkwmC4ZiSAt1LlrL2zxzPMH5BWP3Wl8Y/x1eLtqk4rUYEsyFokFOQ==", "787f317f-a724-4c11-8c07-d3afdd399c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "072a2711-11ab-4cc7-832a-5afce04faaaf", "AQAAAAEAACcQAAAAEN/YFUjjTvjw1JehFMJ7pymHc+QTJF8LNxKFEyUbjPNISfe8N0ap81S24MPSL6DUmA==", "77a27cd2-e7aa-48e8-bc2e-1266ebdc91d8" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3898), new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3889), new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 13, 44, 12, 860, DateTimeKind.Local).AddTicks(3876));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalPriceOfQuantity",
                table: "BookingDetailOfService",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPriceOfQuantity",
                table: "BookingDetailOfPakcage",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 561, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "fe6f7bf2-4e35-4002-8532-221f0cd78f0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "3c65797f-b225-4a22-b825-21a644467e58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "3cedd742-ca37-409e-9cb2-0b983f96db76");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38cb7b69-b342-4137-9f9b-d94c71590bf3", "AQAAAAEAACcQAAAAEAVMZXCzMn9LRMu8mz9mZ8We7S2a/R9l9MYBj22smOdeqGrH+0xsZY8i+AH8YaEaeg==", "897035a1-ffce-4cf3-b406-1503d1abf3e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "134b4429-2974-4952-981e-9d0596f6f880", "AQAAAAEAACcQAAAAEFvNwTmb8nFzqaGml74mmBgQ2KrQwJQmuw2FatNc8AWHHxV/68kd8jqnGmL6HpOK1g==", "5201303b-27eb-49c8-9088-28a13a887735" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "905745d9-764d-4107-a99d-0c0d17ac4a7e", "AQAAAAEAACcQAAAAEJH39W6ZNnSpuZWp0GG8TylqKYd74Axvd3gkE+FcBF50G0cuen8qqIxYmCFrZsv7Dw==", "e69f6bf1-5848-4357-a0fb-c01441888a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab8cab5b-6cce-4f8a-838e-4a380a46f32b", "AQAAAAEAACcQAAAAEGBF93PotKbe53VDFRvyCyyVm8u2qkqCGKAN/laxb6kpdXnJJ3WEXLtpycubT8Ma8w==", "a43ebb83-8ca2-4a16-b690-1409e0677910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a6431bc-b007-498e-841b-cfa531be1e0b", "AQAAAAEAACcQAAAAEM0aI6qj0RGvDOFDdrdRIoLIMS8uL6nIzPjbVeKsewzJMh3r/gH/Vke1oywfVNGGkA==", "7ead33e8-19b6-4425-9565-dbade6f763d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc0984d0-76ac-4bb1-a48e-27a942144218", "AQAAAAEAACcQAAAAEHphRkk0TrQu2xIahhdSuHYVfh63BPZBQ7B6+e/Oo+0HEfihSwUDvxVV26LlD4ZLpA==", "7d5dcf80-add7-4105-a82f-54e2211d8312" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "408bd43d-f1fa-4ce1-949d-a1d425ed1068", "AQAAAAEAACcQAAAAELZVUU0cNUoG4K4TqqXGH/RZZTNIcJm1lkG6vnsYx3fbBC9KSGjEFufAIkoutIzAJA==", "3ee63bbe-3efb-4745-9f8b-82ac4b584d52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2f5d87a-e357-4f74-8754-7127439b7d85", "AQAAAAEAACcQAAAAEDCxjXB345NMQ+LcaHPJag2C3kGyRdQKqyCobE0/PMJGNK1HvLD14zz+7z1WRDSb7w==", "bc73a53b-a8a2-40f8-bee4-3040b974bd89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7959f11-b588-4809-bd46-ae9805935a43", "AQAAAAEAACcQAAAAEKusGk3hI/5MbreCeH3sm6sMrMrZYIifwXqB+RsW/VT0VmLJg5q6e0MPv0grnh9+5w==", "abf3d919-fd25-47fa-8266-544e626a5fe9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e8adb0c-774d-4845-a6f2-d13f0bccae01", "AQAAAAEAACcQAAAAEOcUw2Wybv6sU3IMKrUKSoLUWa9mGcfMV2K97tsyoFqu/pkWoJiL0pR5pLDRzyKNuw==", "07c0275b-4dcf-4772-9e01-7db1a4a6dc60" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 640, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(581), new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(578), new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 23, 1, 38, 15, 641, DateTimeKind.Local).AddTicks(559));
        }
    }
}
