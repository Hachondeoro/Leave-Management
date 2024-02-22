using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedEmploymentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmploymentType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "3602a427-40cf-4073-b597-aeb11ee89223");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "92d06654-21a1-4a37-a61a-36d0246310cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4ce9077-e952-4202-8c20-b296d6ce0c3a", "AQAAAAEAACcQAAAAEC+f5/DJVAXZ6UGnuJmc5IoBASO7g9K4pb/skvLcuF0bx8rdhyWj5JFwU3zYknglSg==", "778a12d7-9eb6-4c0c-b7c2-6dc63f384cbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ef3f4c6-7beb-4659-9b25-0941f285734a", "AQAAAAEAACcQAAAAEFJEmr2Wz+EaRn1sXwMXhxMH9MhBly7iTGaecZttNRW84DQXD3gnLpfoCqcgfQgPTg==", "d38336d4-d486-4dba-a0dd-8e9ba914f095" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmploymentType",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9db56f17-c41d-460b-a1b7-b24b23e685d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "f54cc069-e05e-47b9-86d5-a95e93e5ffec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11c66d4f-d016-4f94-b7d1-ae0cb0f7e17a", "AQAAAAEAACcQAAAAEAxiMBUxX8NlGeBwxfiIkjU2uPel8cR0Dn0lUtyxQ3qBWqanZPDjyOu9pFmk3kzpTw==", "a7a16fa2-f44a-444d-9197-ab05c6a723bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "021d143f-9dbb-4eae-8a34-1df0acf2d075", "AQAAAAEAACcQAAAAEGi/UGWTa7kABqkQ9MyF0CCDCWXr59030bcynLIn6OiJf98m8thsNhJ2sa5+BN3htQ==", "4b8217ca-02b1-429d-b327-ca12358cddd6" });
        }
    }
}
