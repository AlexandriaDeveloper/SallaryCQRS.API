using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderFile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "OrderFileId",
                table: "EmployeeOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OrderNumber",
                table: "EmployeeOrders",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OrderFiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFiles", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 6, 14, 33, 39, 742, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_OrderFileId",
                table: "EmployeeOrders",
                column: "OrderFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_OrderFiles_OrderFileId",
                table: "EmployeeOrders",
                column: "OrderFileId",
                principalTable: "OrderFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeOrders_OrderFiles_OrderFileId",
                table: "EmployeeOrders");

            migrationBuilder.DropTable(
                name: "OrderFiles");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeOrders_OrderFileId",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "OrderFileId",
                table: "EmployeeOrders");

            migrationBuilder.DropColumn(
                name: "OrderNumber",
                table: "EmployeeOrders");

            migrationBuilder.AlterColumn<int>(
                name: "FormId",
                table: "EmployeeOrders",
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
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 774, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 774, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 774, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 774, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 774, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeOrders_Form_FormId",
                table: "EmployeeOrders",
                column: "FormId",
                principalTable: "Form",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
