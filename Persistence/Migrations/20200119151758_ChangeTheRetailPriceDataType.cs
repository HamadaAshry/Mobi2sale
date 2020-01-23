using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeTheRetailPriceDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1348),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.AlterColumn<decimal>(
                name: "RetailPrice",
                schema: "Admin",
                table: "tbl_Items",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 551, DateTimeKind.Local).AddTicks(1069),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 186, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 540, DateTimeKind.Local).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 179, DateTimeKind.Local).AddTicks(3132));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7427),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.AlterColumn<decimal>(
                name: "RetailPrice",
                schema: "Admin",
                table: "tbl_Items",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1985),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1435),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 186, DateTimeKind.Local).AddTicks(2618),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 551, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 179, DateTimeKind.Local).AddTicks(3132),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 540, DateTimeKind.Local).AddTicks(5699));
        }
    }
}
