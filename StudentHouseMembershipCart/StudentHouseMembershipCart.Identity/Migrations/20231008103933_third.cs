using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "96bb1aba-f1bc-44b6-910f-3dd334ab1234");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "753b89fb-a320-498e-b26e-ce5ec4d8ae81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "343d65e2-bbdb-4688-ba05-5ad19465e2a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a20aa1c5-fde9-416c-a851-18a9a888d322", "AQAAAAEAACcQAAAAEHK61C+OtJrhkw0ZGO8QJRYY17se2c1BwwhKx/44kjn70cZcPMcN4SLZelbYoFPJ2Q==", "63b004b0-641f-44b5-ad51-b7caf4103cc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba9a9f71-98b8-46ab-b1e3-22e5295b2bb7", "AQAAAAEAACcQAAAAEK9PCupiI236ZtCKZEWbEvkCPD8kFCtOv7MyVzTqtCR1uHgdmqPfUq+9P2wP9WJxig==", "52d232f5-6924-40ea-b0df-d8e168692993" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c567bca-9fc9-47c9-aa18-6fbd32510ab9", "AQAAAAEAACcQAAAAEMxky1p0gLICgR49a7tqFcYiaLVxCPoGeVd9uZB8pDatDFSMyqAW0DAq+tp/4DgCsw==", "8d5f2250-83b8-4fb1-98e1-7c06e8e9f525" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE1",
                column: "ConcurrencyStamp",
                value: "d284b368-3522-4c26-be36-4b58832f34a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "173fec33-f96b-44b1-a844-40d948ab99a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "d0bff522-4846-4582-96aa-554e84a8b154");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8936e0d-5ea6-4dff-ae83-3903ec5137ee", "AQAAAAEAACcQAAAAEHygipgfgpn2h8l431HiZTNB8d+ocFLIfbd61yMOfKa1K8SNkBGYq4pTxuBFKL0YbA==", "74fa06f6-c8d3-4e9b-ad48-9a2e6c8b8218" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f1b04ac-1aa5-449c-b0cc-d64f932d387f", "AQAAAAEAACcQAAAAEDq7T/LJ66hSrV+/J9mbwoTu4RHzHfdeP/Su3aYa1Id/xK86/hQVDvIUUlUoOq0MsA==", "a8ed45dd-338c-4486-8630-9e646d21ce28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15141fce-1f21-4111-937c-f827e67ac1cb", "AQAAAAEAACcQAAAAEBDcrH/e7n7EgHPk1m31Wo5Bm8MippWDf1Svf9VmRVkvj4foLx23YlK7h/1R7bkDbQ==", "46ddf862-f2c7-4101-836e-14223dce7c46" });
        }
    }
}
