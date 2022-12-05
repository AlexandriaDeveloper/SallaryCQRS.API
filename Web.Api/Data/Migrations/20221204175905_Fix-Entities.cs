using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Web.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("13ea4b12-f3af-4b01-85f7-d59d643dbccd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("230b595d-ed59-42fb-9df3-c5c174e4f48c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ddc1c0f1-b08f-42dc-b6a4-3e4d0542af2d"));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "EmployeeOrderExecuation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4020d7e8-db76-4060-aed3-227efff36da3"), "Admin", new DateTime(2022, 12, 4, 19, 59, 5, 249, DateTimeKind.Local).AddTicks(6678), null, null, null, null, "أجازة بدون مرتب" },
                    { new Guid("86fc2178-e92f-45fc-b8f5-338523bf96d5"), "Admin", new DateTime(2022, 12, 4, 19, 59, 5, 249, DateTimeKind.Local).AddTicks(6665), null, null, null, null, "غياب بدون إذن" },
                    { new Guid("f23b8deb-8dc8-49fb-bf18-4ac2b44b4f77"), "Admin", new DateTime(2022, 12, 4, 19, 59, 5, 249, DateTimeKind.Local).AddTicks(6676), null, null, null, null, "امر عقاب" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4020d7e8-db76-4060-aed3-227efff36da3"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("86fc2178-e92f-45fc-b8f5-338523bf96d5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f23b8deb-8dc8-49fb-bf18-4ac2b44b4f77"));

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "EmployeeOrderExecuation");

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("13ea4b12-f3af-4b01-85f7-d59d643dbccd"), "Admin", new DateTime(2022, 12, 2, 22, 51, 41, 753, DateTimeKind.Local).AddTicks(4812), null, null, null, null, "أجازة بدون مرتب" },
                    { new Guid("230b595d-ed59-42fb-9df3-c5c174e4f48c"), "Admin", new DateTime(2022, 12, 2, 22, 51, 41, 753, DateTimeKind.Local).AddTicks(4810), null, null, null, null, "امر عقاب" },
                    { new Guid("ddc1c0f1-b08f-42dc-b6a4-3e4d0542af2d"), "Admin", new DateTime(2022, 12, 2, 22, 51, 41, 753, DateTimeKind.Local).AddTicks(4796), null, null, null, null, "غياب بدون إذن" }
                });
        }
    }
}
