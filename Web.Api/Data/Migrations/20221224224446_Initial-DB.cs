using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BudgetItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    TabCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TegaraCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CollageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Section = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EmployeeBankId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialYears",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FormDate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    FileNumber55 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    FileNumber224 = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branche", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branche_Bank_BankId",
                        column: x => x.BankId,
                        principalTable: "Bank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesPartTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesPartTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeesPartTimes_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBasicSallaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FinancialYearId = table.Column<int>(type: "int", nullable: false),
                    BasicSallary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Wazifi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mokamel = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Ta3widi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBasicSallaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicSallaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeBasicSallaries_FinancialYears_FinancialYearId",
                        column: x => x.FinancialYearId,
                        principalTable: "FinancialYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeGrades_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeGrades_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrderDeductions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrderDeductions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductions_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    StartFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSubscriptions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeSubscriptions_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(22)", maxLength: 22, nullable: true),
                    BrancheId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBank_Branche_BrancheId",
                        column: x => x.BrancheId,
                        principalTable: "Branche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeBank_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrderDeductionExecuation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeOrderDeductionId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrderDeductionExecuation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductionExecuation_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductionExecuation_EmployeeOrderDeductions_EmployeeOrderDeductionId",
                        column: x => x.EmployeeOrderDeductionId,
                        principalTable: "EmployeeOrderDeductions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderDeductionExecuation_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeOrderExecuations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetItemId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeOrderId = table.Column<int>(type: "int", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeOrderExecuations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_BudgetItems_BudgetItemId",
                        column: x => x.BudgetItemId,
                        principalTable: "BudgetItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_EmployeeOrders_EmployeeOrderId",
                        column: x => x.EmployeeOrderId,
                        principalTable: "EmployeeOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeOrderExecuations_Subscriptions_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PeriodicSubscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderId = table.Column<int>(type: "int", nullable: true),
                    EmployeeOrderDeductionId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditOrDebit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodicSubscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_EmployeeOrderDeductions_EmployeeOrderDeductionId",
                        column: x => x.EmployeeOrderDeductionId,
                        principalTable: "EmployeeOrderDeductions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_EmployeeOrders_EmployeeOrderId",
                        column: x => x.EmployeeOrderId,
                        principalTable: "EmployeeOrders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PeriodicSubscription_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BudgetItems",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4622), null, null, null, null, "اجر وظيفى " },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4623), null, null, null, null, "اجر مكمل" },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4624), null, null, null, null, "أجر تعويضى" },
                    { 4, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4625), null, null, null, null, "جزاء" },
                    { 5, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4626), null, null, null, null, "غياب" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CollageName", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EmployeeBankId", "ModifiedBy", "ModifiedDate", "Name", "NationalId", "Section", "TabCode", "TegaraCode" },
                values: new object[,]
                {
                    { 1, "كلية الطب", "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4670), null, null, null, null, null, "محمد على شريف", "0123456781", "مكافأة شامله", "2309", "1" },
                    { 2, "كلية الطب", "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4671), null, null, null, null, null, "محمود عبد الحميد شاهين", "0123456782", "مكافأة شامله", "2310", "2" },
                    { 3, "كلية الطب", "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4673), null, null, null, null, null, " اسمهان موسى عيد ", "0123456783", "مكافأة شامله", "2311", "3" }
                });

            migrationBuilder.InsertData(
                table: "FinancialYears",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4649), null, null, null, null, "العام المالى 2017-2018" },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4650), null, null, null, null, "العام المالى 2018-2019" },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4651), null, null, null, null, "العام المالى 2020-2019" }
                });

            migrationBuilder.InsertData(
                table: "Form",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Details", "FileNumber224", "FileNumber55", "FormDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4592), null, null, "مرتبات شهر مارس", "1", "1", "2022-3", null, null },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4595), null, null, "مرتبات شهر ابريل", "1", "1", "2022-4", null, null },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4597), null, null, "مرتبات شهر مايو", "2", "2", "2022-5", null, null },
                    { 4, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4598), null, null, "مرتبات شهر يونيو", "3", "3", "2022-6", null, null }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4763), null, null, null, null, "درجة كبير" },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4764), null, null, null, null, "درجة اولى" },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4765), null, null, null, null, "درجة ثانيه" },
                    { 4, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4766), null, null, null, null, "درجة ثالثه" },
                    { 5, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4767), null, null, null, null, "درجة رابعه" },
                    { 6, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4768), null, null, null, null, "درجة خامسه" },
                    { 7, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4768), null, null, null, null, "درجة سادسه" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4440), null, null, null, null, "غياب بدون إذن" },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4454), null, null, null, null, "امر عقاب جزاء عن الغياب بدون إذن" },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4455), null, null, null, null, "أمر عقاب خصم من مكافأة الامتحانات" },
                    { 4, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4456), null, null, null, null, "أجازة بدون مرتب" },
                    { 5, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4457), null, null, null, null, "أشتراكات" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4716), null, null, null, null, "تأمين علاجى" },
                    { 2, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4717), null, null, null, null, "نقابه" },
                    { 3, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4718), null, null, null, null, "محمول شركة ETI" },
                    { 4, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4719), null, null, null, null, "محمول شركه سيجنال " },
                    { 5, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4720), null, null, null, null, "خزنه تك  " },
                    { 6, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4721), null, null, null, null, "نفقه  " }
                });

            migrationBuilder.InsertData(
                table: "EmployeeBasicSallaries",
                columns: new[] { "Id", "BasicSallary", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "EmployeeId", "FinancialYearId", "ModifiedBy", "ModifiedDate", "Mokamel", "Ta3widi", "Wazifi" },
                values: new object[,]
                {
                    { 1, 246m, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4692), null, null, 1, 1, null, null, 440m, 31.17m, 1128.09m },
                    { 2, 223.5m, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4695), null, null, 2, 1, null, null, 417.5m, 28.47m, 1123.49m },
                    { 3, 208.5m, "Admin", new DateTime(2022, 12, 25, 0, 44, 45, 648, DateTimeKind.Local).AddTicks(4697), null, null, 3, 1, null, null, 402.3m, 26.67m, 1083.65m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branche_BankId",
                table: "Branche",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_BrancheId",
                table: "EmployeeBank",
                column: "BrancheId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBank_EmployeeId",
                table: "EmployeeBank",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicSallaries_EmployeeId_FinancialYearId",
                table: "EmployeeBasicSallaries",
                columns: new[] { "EmployeeId", "FinancialYearId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBasicSallaries_FinancialYearId",
                table: "EmployeeBasicSallaries",
                column: "FinancialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGrades_EmployeeId_GradeId",
                table: "EmployeeGrades",
                columns: new[] { "EmployeeId", "GradeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGrades_GradeId",
                table: "EmployeeGrades",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductionExecuation_BudgetItemId",
                table: "EmployeeOrderDeductionExecuation",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductionExecuation_EmployeeOrderDeductionId",
                table: "EmployeeOrderDeductionExecuation",
                column: "EmployeeOrderDeductionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductionExecuation_SubscriptionId",
                table: "EmployeeOrderDeductionExecuation",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductions_EmployeeId",
                table: "EmployeeOrderDeductions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductions_FormId",
                table: "EmployeeOrderDeductions",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderDeductions_OrderId",
                table: "EmployeeOrderDeductions",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_BudgetItemId",
                table: "EmployeeOrderExecuations",
                column: "BudgetItemId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_EmployeeOrderId",
                table: "EmployeeOrderExecuations",
                column: "EmployeeOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrderExecuations_SubscriptionId",
                table: "EmployeeOrderExecuations",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_EmployeeId",
                table: "EmployeeOrders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_FormId",
                table: "EmployeeOrders",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeOrders_OrderId",
                table: "EmployeeOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalId",
                table: "Employees",
                column: "NationalId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_TabCode",
                table: "Employees",
                column: "TabCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesPartTimes_EmployeeId",
                table: "EmployeesPartTimes",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_EmployeeId",
                table: "EmployeeSubscriptions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSubscriptions_SubscriptionId",
                table: "EmployeeSubscriptions",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeId",
                table: "PeriodicSubscription",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeOrderDeductionId",
                table: "PeriodicSubscription",
                column: "EmployeeOrderDeductionId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriodicSubscription_EmployeeOrderId",
                table: "PeriodicSubscription",
                column: "EmployeeOrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeBank");

            migrationBuilder.DropTable(
                name: "EmployeeBasicSallaries");

            migrationBuilder.DropTable(
                name: "EmployeeGrades");

            migrationBuilder.DropTable(
                name: "EmployeeOrderDeductionExecuation");

            migrationBuilder.DropTable(
                name: "EmployeeOrderExecuations");

            migrationBuilder.DropTable(
                name: "EmployeesPartTimes");

            migrationBuilder.DropTable(
                name: "EmployeeSubscriptions");

            migrationBuilder.DropTable(
                name: "PeriodicSubscription");

            migrationBuilder.DropTable(
                name: "Branche");

            migrationBuilder.DropTable(
                name: "FinancialYears");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "BudgetItems");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "EmployeeOrderDeductions");

            migrationBuilder.DropTable(
                name: "EmployeeOrders");

            migrationBuilder.DropTable(
                name: "Bank");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
