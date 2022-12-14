using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrder_Employees_EmployeeId",
                table: "EmployeeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrder_Orders_OrderId",
                table: "EmployeeOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeduction_Employees_EmployeeId",
                table: "EmployeeOrderDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeduction_Orders_OrderId",
                table: "EmployeeOrderDeduction");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeductionExecuation_EmployeeOrderDeduction_EmployeeOrderDeductionId",
                table: "EmployeeOrderDeductionExecuation");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrder_EmployeeOrderId",
                table: "EmployeeOrderExecuation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrderDeduction",
                table: "EmployeeOrderDeduction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrder",
                table: "EmployeeOrder");

            migrationBuilder.RenameTable(
                name: "EmployeeOrderDeduction",
                newName: "EmployeeOrderDeductions");

            migrationBuilder.RenameTable(
                name: "EmployeeOrder",
                newName: "EmployeeOrders");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderDeduction_OrderId",
                table: "EmployeeOrderDeductions",
                newName: "IX_EmployeeOrderDeductions_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderDeduction_EmployeeId",
                table: "EmployeeOrderDeductions",
                newName: "IX_EmployeeOrderDeductions_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrder_OrderId",
                table: "EmployeeOrders",
                newName: "IX_EmployeeOrders_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrder_EmployeeId",
                table: "EmployeeOrders",
                newName: "IX_EmployeeOrders_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrderDeductions",
                table: "EmployeeOrderDeductions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrders",
                table: "EmployeeOrders",
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
                name: "FK_EmployeeOrderDeductionExecuation_EmployeeOrderDeductions_EmployeeOrderDeductionId",
                table: "EmployeeOrderDeductionExecuation",
                column: "EmployeeOrderDeductionId",
                principalTable: "EmployeeOrderDeductions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderDeductions_Employees_EmployeeId",
                table: "EmployeeOrderDeductions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderDeductions_Orders_OrderId",
                table: "EmployeeOrderDeductions",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuation",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Employees_EmployeeId",
                table: "EmployeeOrders",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeductionExecuation_EmployeeOrderDeductions_EmployeeOrderDeductionId",
                table: "EmployeeOrderDeductionExecuation");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeductions_Employees_EmployeeId",
                table: "EmployeeOrderDeductions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderDeductions_Orders_OrderId",
                table: "EmployeeOrderDeductions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrders_EmployeeOrderId",
                table: "EmployeeOrderExecuation");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Employees_EmployeeId",
                table: "EmployeeOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Orders_OrderId",
                table: "EmployeeOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrders",
                table: "EmployeeOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeOrderDeductions",
                table: "EmployeeOrderDeductions");

            migrationBuilder.RenameTable(
                name: "EmployeeOrders",
                newName: "EmployeeOrder");

            migrationBuilder.RenameTable(
                name: "EmployeeOrderDeductions",
                newName: "EmployeeOrderDeduction");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrders_OrderId",
                table: "EmployeeOrder",
                newName: "IX_EmployeeOrder_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrders_EmployeeId",
                table: "EmployeeOrder",
                newName: "IX_EmployeeOrder_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderDeductions_OrderId",
                table: "EmployeeOrderDeduction",
                newName: "IX_EmployeeOrderDeduction_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeOrderDeductions_EmployeeId",
                table: "EmployeeOrderDeduction",
                newName: "IX_EmployeeOrderDeduction_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrder",
                table: "EmployeeOrder",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeOrderDeduction",
                table: "EmployeeOrderDeduction",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 9, 20, 45, 36, 661, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrder_Employees_EmployeeId",
                table: "EmployeeOrder",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrder_Orders_OrderId",
                table: "EmployeeOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderDeduction_Employees_EmployeeId",
                table: "EmployeeOrderDeduction",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderDeduction_Orders_OrderId",
                table: "EmployeeOrderDeduction",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderDeductionExecuation_EmployeeOrderDeduction_EmployeeOrderDeductionId",
                table: "EmployeeOrderDeductionExecuation",
                column: "EmployeeOrderDeductionId",
                principalTable: "EmployeeOrderDeduction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrderExecuation_EmployeeOrder_EmployeeOrderId",
                table: "EmployeeOrderExecuation",
                column: "EmployeeOrderId",
                principalTable: "EmployeeOrder",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
