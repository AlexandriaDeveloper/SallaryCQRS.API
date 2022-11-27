using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeBasicSallary2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinancialYears_FinancialYears_FinancialYearId",
                table: "FinancialYears");

            migrationBuilder.DropIndex(
                name: "IX_FinancialYears_FinancialYearId",
                table: "FinancialYears");

            migrationBuilder.DropColumn(
                name: "FinancialYearId",
                table: "FinancialYears");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FinancialYearId",
                table: "FinancialYears",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FinancialYears_FinancialYearId",
                table: "FinancialYears",
                column: "FinancialYearId");

            migrationBuilder.AddForeignKey(
                name: "FK_FinancialYears_FinancialYears_FinancialYearId",
                table: "FinancialYears",
                column: "FinancialYearId",
                principalTable: "FinancialYears",
                principalColumn: "Id");
        }
    }
}
