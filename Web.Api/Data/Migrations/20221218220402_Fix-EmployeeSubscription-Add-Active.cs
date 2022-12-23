using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEmployeeSubscriptionAddActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSubscription_Employees_EmployeeId",
                table: "EmployeeSubscription");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSubscription_Subscriptions_SubscriptionId",
                table: "EmployeeSubscription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSubscription",
                table: "EmployeeSubscription");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "EmployeeSubscription",
                newName: "EmployeeSubscriptions");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSubscription_SubscriptionId",
                table: "EmployeeSubscriptions",
                newName: "IX_EmployeeSubscriptions_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSubscription_EmployeeId",
                table: "EmployeeSubscriptions",
                newName: "IX_EmployeeSubscriptions_EmployeeId");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "EmployeeSubscriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSubscriptions",
                table: "EmployeeSubscriptions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 19, 0, 4, 1, 673, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSubscriptions_Employees_EmployeeId",
                table: "EmployeeSubscriptions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSubscriptions_Subscriptions_SubscriptionId",
                table: "EmployeeSubscriptions",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSubscriptions_Employees_EmployeeId",
                table: "EmployeeSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSubscriptions_Subscriptions_SubscriptionId",
                table: "EmployeeSubscriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeSubscriptions",
                table: "EmployeeSubscriptions");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "EmployeeSubscriptions");

            migrationBuilder.RenameTable(
                name: "EmployeeSubscriptions",
                newName: "EmployeeSubscription");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSubscriptions_SubscriptionId",
                table: "EmployeeSubscription",
                newName: "IX_EmployeeSubscription_SubscriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId",
                table: "EmployeeSubscription",
                newName: "IX_EmployeeSubscription_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeSubscription",
                table: "EmployeeSubscription",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3714));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3411));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 5, "Admin", new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3412), null, null, null, null, "خصم غياب بدون إذن" },
                    { 6, "Admin", new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3413), null, null, null, null, "خصم من المرتب امر عقاب" },
                    { 7, "Admin", new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3414), null, null, null, null, "أمر عقاب خصم من مكافأة الامتحانات" },
                    { 8, "Admin", new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3414), null, null, null, null, "أجازة بدون مرتب" }
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 12, 16, 23, 34, 13, 14, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSubscription_Employees_EmployeeId",
                table: "EmployeeSubscription",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSubscription_Subscriptions_SubscriptionId",
                table: "EmployeeSubscription",
                column: "SubscriptionId",
                principalTable: "Subscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
