using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCollectionWithOrderSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Collection",
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
                    table.PrimaryKey("PK_Collection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CollectionId = table.Column<int>(type: "int", nullable: false),
                    EmployeeOrderInCollection = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeCollections_Collection_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeCollections_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(257), null, null, null, null, "مرتبات بطاقات حكوميه" },
                    { 2, "Admin", new DateTime(2023, 1, 5, 19, 44, 19, 775, DateTimeKind.Local).AddTicks(258), null, null, null, null, "مرتبات تحويلات بنكيه" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCollections_CollectionId",
                table: "EmployeeCollections",
                column: "CollectionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCollections_EmployeeId",
                table: "EmployeeCollections",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeCollections");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.UpdateData(
                table: "BudgetItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "EmployeeBasicSallaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "Form",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 3, 22, 38, 32, 748, DateTimeKind.Local).AddTicks(3187));
        }
    }
}
