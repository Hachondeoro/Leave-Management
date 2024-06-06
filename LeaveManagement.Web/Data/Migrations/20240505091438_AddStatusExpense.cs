using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddStatusExpense : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Expenses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Expenses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssignerId",
                table: "EmployeeTasks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "EmployeeTasks",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "f86ba42a-a9c5-4988-a2f0-7f3bf1ac6b65");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "6b5b120f-e345-4803-851e-7343aa4b77ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4880ba95-ac94-47cd-8555-a9e78c65154b", "AQAAAAEAACcQAAAAEAtJ0tSuOvpRe1Zllq4a4piKXzUAaNGMiQ9jwJeQ4GJaW5s1kkWjnfPIDL2tT97rrQ==", "f2342d0b-dfa4-4d08-9de1-3c82cf8e6ff1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69d1a2e7-a2a3-4684-a4cc-befc168bee8d", "AQAAAAEAACcQAAAAEFlDLJuLARsDloabYTrj6UvyTGRfH2ZNHHxzzj/JZXDIvY5YdTnzmdjQHVAx5cU9KA==", "b0b0a021-2ffb-4765-b6ee-02346795f368" });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AssigneeId",
                table: "EmployeeTasks",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTasks_AssignerId",
                table: "EmployeeTasks",
                column: "AssignerId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AssigneeId",
                table: "EmployeeTasks",
                column: "AssigneeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AssignerId",
                table: "EmployeeTasks",
                column: "AssignerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_AspNetUsers_EmployeeId",
                table: "Expenses",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AssigneeId",
                table: "EmployeeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AssignerId",
                table: "EmployeeTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_AspNetUsers_EmployeeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_Expenses_EmployeeId",
                table: "Expenses");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_AssigneeId",
                table: "EmployeeTasks");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTasks_AssignerId",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Expenses");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AssignerId",
                table: "EmployeeTasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AssigneeId",
                table: "EmployeeTasks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d8c34be0-b679-4761-b887-7bca73ec6953");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "fa6631cc-4d52-4f8a-8880-0fa76c87b5fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b0a09f-4581-47c9-a12d-d6fd2b7670ff", "AQAAAAEAACcQAAAAEGVFNDBa+EcJc24XgIsL3G2pesQpBDmjdMPlGwnbAkeBBm9CH7mkWIBN2u8fHU2rkQ==", "0aeff7dc-41d9-4d1c-a437-874c6415c46d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94e8b4e-fb48-438d-b336-0e89a4946756", "AQAAAAEAACcQAAAAEF6nxfBoWWr23MhVexDhXY19lVQkl76MagkCm8az5MLMMfhUKcLKG8HoymnfbXSj/Q==", "d7be61b5-a2c6-4aeb-8a7d-61de25751bf9" });
        }
    }
}
