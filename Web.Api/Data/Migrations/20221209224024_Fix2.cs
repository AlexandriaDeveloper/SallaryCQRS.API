using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuation_BudgetItems_BudgetItemId",
                table: "EmployeeOrderExecuation");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuation");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuation_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrderExecuation",
                table: "EmployeeOrderExecuation");

            migrationBuilder.RenameTable(
                name: "EmployeeOrderExecuation",
                newName: "EmployeeOrderExecuations");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuation_SubscriptionId",
                table: "EmployeeOrderExecuations",
                newName: "IX_EmployeeOrderExecuations_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuation_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                newName: "IX_EmployeeOrderExecuations_EmployeeOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuation_BudgetItemId",
                table: "EmployeeOrderExecuations",
                newName: "IX_EmployeeOrderExecuations_BudgetItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrderExecuations",
                table: "EmployeeOrderExecuations",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 40, 24, 351, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_BudgetItems_BudgetItemId",
                table: "EmployeeOrderExecuations",
                column: "BudgetItemId",
                principalTable: "BudgetItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuations",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_BudgetItems_BudgetItemId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrderExecuations",
                table: "EmployeeOrderExecuations");

            migrationBuilder.RenameTable(
                name: "EmployeeOrderExecuations",
                newName: "EmployeeOrderExecuation");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuations_SubscriptionId",
                table: "EmployeeOrderExecuation",
                newName: "IX_EmployeeOrderExecuation_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuations_EmployeeOrderId",
                table: "EmployeeOrderExecuation",
                newName: "IX_EmployeeOrderExecuation_EmployeeOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderExecuations_BudgetItemId",
                table: "EmployeeOrderExecuation",
                newName: "IX_EmployeeOrderExecuation_BudgetItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrderExecuation",
                table: "EmployeeOrderExecuation",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 10, 0, 20, 47, 536, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuation_BudgetItems_BudgetItemId",
                table: "EmployeeOrderExecuation",
                column: "BudgetItemId",
                principalTable: "BudgetItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuation",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuation_Subscriptions_SubscriptionId",
                table: "EmployeeOrderExecuation",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }
    }
}
