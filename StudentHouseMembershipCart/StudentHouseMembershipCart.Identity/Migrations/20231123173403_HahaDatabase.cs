using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class HahaDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: new Guid("90ca347f-831f-4b75-98bb-ae825b3efc15"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 394, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "c8d0cc77-7f0b-42c8-95fe-1a910dd141f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "47ab3937-73aa-49f9-81c7-a84715578a3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "de8d9a09-a3be-419a-8b0e-d3b26eddaa9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02495f7a-834a-443d-81c2-61901d82ae26", "AQAAAAEAACcQAAAAEFAjsorotWJn4r57yBbLJvxpTW8EnPhjXR05ajbwQ0NZEIKl19lxpp5H/1AhedTo7Q==", "ddba5679-4182-42ff-9766-3a21b015d405" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bf96dfd-2a31-42aa-806a-5822be4919da", "AQAAAAEAACcQAAAAEC9rgxx0QMNsZewjCdmY7m6wliHMUiihteP1kcjuXoBEhmMoG1gCTR7Q915Q5ZRjsQ==", "148e260b-a774-403f-8bf4-8c3ac7c6a62e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "617d5fa0-5e5e-4189-94ac-50e314be566c", "AQAAAAEAACcQAAAAEEqK1YQNpLiJi5uGEqgJ1Rp9Hbsw2LVPyDn09QWoENpm8bE9H+SRkbLiej3ttZa9Nw==", "2621bbda-8fec-4df2-a229-bb5aa897953c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5c0b8f-b878-4f7a-9f4e-32b56621d2de", "AQAAAAEAACcQAAAAEPL2WKzuX+NXkZ7By8FybKs2dgIMANacH1N5DOvK29VzdcSt8tyAhHbVZ3AJqT2hbw==", "ac513201-b86b-4743-8b3c-5196dc77edfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81ed9319-69b9-4f20-b143-156e00598456", "AQAAAAEAACcQAAAAEFDPPiG3YwEftmiNMEXsim303PHM89XE0Ix2aRQARXiS0F+CD+gE17ATRbWef2w2lw==", "9a57fa3d-780e-44fa-9df5-f1b9017438b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab08085d-3459-45ba-be88-3dfdcac521a6", "AQAAAAEAACcQAAAAEAFTz6mwPTaRpIgNYvV2nqhz+8hMB3w6eyKUFVn1rIYsz0gZjtaq8QQlAarsME8GvQ==", "bff91d11-7445-40e6-9693-8d1feee5c63d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e897a22-ee53-4cbe-bf0b-a24e39d4863d", "AQAAAAEAACcQAAAAEM/crPwiWlTajCttrNeOdEk9SZSKr5cRIRqDI3zd0H7sFA3YqNW44Qmz1mLsRRFyBg==", "82f32c06-4c95-40d2-9aa2-da5b2717ace1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "96a252c1-c7ac-4214-b12a-b406801b0b95", "AQAAAAEAACcQAAAAEP1zxEGWOd5PyxgEEbvEHFQJCMmIOOTLhM2hZuILvnTR69aB8klXPdsDAlghPWjvYw==", "02b263eb-b532-4e00-9aea-54f38433ccaf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e70334e-7199-47c8-bd21-3cc64291a663", "AQAAAAEAACcQAAAAEJGx8u1IcG8jk+KLUtg9SFnyRL5hxGI3AJJzXt429NxTzmhGQfE+tM7jez0gMyGqXA==", "601f7fa3-6628-4fe2-a3bf-136670274700" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f35a418-f323-4b0d-b198-d730964e41ec", "AQAAAAEAACcQAAAAEASFtDb2S6HhIg01UxalW++IAr886rpzygdyYOw3fUrzv77OctXcu2sv/4Ww+HtXHw==", "a27b757a-dec1-4ce6-9536-47e86d4d8cfb" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("21291667-7546-4825-9bad-840d648900a3"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("375a894d-e8e5-4a84-a0b8-09f907992b46"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8940e7f6-fd91-4402-a515-b9d55448c522"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("8abb3dda-208b-4397-93c0-3a5269a90e3d"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("9df988f5-0382-4939-8eee-09d47b182bbb"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("a3ccb973-d6c4-4ef4-ae4b-36a97429a0b0"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ba0f3f23-9425-44ad-9d73-a7608381fd5f"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 465, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("a8ded7dd-683f-4231-8c47-560375560eea"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("c085539d-76bd-4fe8-9444-12c21de6610b"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: new Guid("d36a73ed-78ae-46af-befd-7b90cbcfc479"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("46f50a4a-327e-47f1-a43c-d31b6b39b939"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(547), new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                columns: new[] { "Birthday", "Created" },
                values: new object[] { new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(540), new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719420"),
                column: "Created",
                value: new DateTime(2023, 11, 24, 0, 34, 2, 466, DateTimeKind.Local).AddTicks(520));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
