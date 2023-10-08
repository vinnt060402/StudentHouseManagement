using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentHouseMembershipCart.Identity.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "d3ecbdea-59d1-439c-a5e7-61771e1e4d0f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE2",
                column: "ConcurrencyStamp",
                value: "ad05fa8e-50c7-4d05-847c-530f863823fa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ROLE3",
                column: "ConcurrencyStamp",
                value: "b7171e48-0868-437b-8179-e7cc9a91c4f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af0f5ac5-08f3-4789-8e7c-4937ed7379b4", "AQAAAAEAACcQAAAAEHnRK13WWs7oWSOGteNRemutproubAk/Gwtcq/t+MZPsXBkuCJER7m/sI4p6glMpVg==", "66039d81-0645-42fa-b1ea-3435fc632f90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8779ab70-9569-48ae-990c-d4c79bb55700", "AQAAAAEAACcQAAAAEJOqTrGWpyHcIJSNp2X81zIzenpuZf92XNr/W2Eo2/42/vwwDhE8NxPwkLRWrRiFYg==", "93251d4d-0fb5-469c-9db8-50e15c348799" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ACCOUNT3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975cb551-6709-469b-bf1d-e4ee5b48b936", "AQAAAAEAACcQAAAAEBRGJ99FZ8wU3k4Tj01RP+IBfdKc6GoWNmdcgqIZLq0pmYfX3cLWn5GhAA83MzDX6w==", "4556763e-63b9-4a83-8f38-9e2e987eecbf" });
        }
    }
}
