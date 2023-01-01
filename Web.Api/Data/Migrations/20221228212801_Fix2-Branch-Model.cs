using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix2BranchModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeBank_Employees_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 23, 28, 1, 146, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeBankId",
                table: "Employees",
                column: "EmployeeBankId",
                unique: true,
                filter: "[EmployeeBankId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmployeeBank_EmployeeBankId",
                table: "Employees",
                column: "EmployeeBankId",
                principalTable: "EmployeeBank",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmployeeBank_EmployeeBankId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeBankId",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 28, 19, 12, 51, 599, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBank_Employees_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
