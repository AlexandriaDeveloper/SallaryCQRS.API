using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDBFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId",
                table: "EmployeeSubscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2536));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 1, 2, 27, 510, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId_SubscriptionId",
                table: "EmployeeSubscriptions",
                columns: new[] { "EmployeeId", "SubscriptionId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId_SubscriptionId",
                table: "EmployeeSubscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "PeriodicSubscription",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4767));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId",
                table: "EmployeeSubscriptions",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeriodicSubscription_Employees_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
