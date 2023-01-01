using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix4BranchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBank_Branch_BranchId",
                table: "EmployeeBank");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeBank_EmployeeBankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeBank",
                table: "EmployeeBank");

            migrationBuilder.RenameTable(
                name: "EmployeeBank",
                newName: "EmployeeBanks");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeBank_BranchId",
                table: "EmployeeBanks",
                newName: "IX_EmployeeBanks_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeBanks",
                table: "EmployeeBanks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 29, 0, 25, 10, 702, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBanks_Branch_BranchId",
                table: "EmployeeBanks",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeBanks_EmployeeBankId",
                table: "Employees",
                column: "EmployeeBankId",
                principalTable: "EmployeeBanks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBanks_Branch_BranchId",
                table: "EmployeeBanks");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeBanks_EmployeeBankId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeBanks",
                table: "EmployeeBanks");

            migrationBuilder.RenameTable(
                name: "EmployeeBanks",
                newName: "EmployeeBank");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeBanks_BranchId",
                table: "EmployeeBank",
                newName: "IX_EmployeeBank_BranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeBank",
                table: "EmployeeBank",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 38, 12, 719, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBank_Branch_BranchId",
                table: "EmployeeBank",
                column: "BranchId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeBank_EmployeeBankId",
                table: "Employees",
                column: "EmployeeBankId",
                principalTable: "EmployeeBank",
                principalColumn: "Id");
        }
    }
}
