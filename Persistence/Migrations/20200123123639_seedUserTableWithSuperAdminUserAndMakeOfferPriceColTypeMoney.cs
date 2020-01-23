using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seedUserTableWithSuperAdminUserAndMakeOfferPriceColTypeMoney : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OfferPrice",
                schema: "Sales",
                table: "tbl_Offers",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 538, DateTimeKind.Local).AddTicks(8466),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 538, DateTimeKind.Local).AddTicks(8117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 540, DateTimeKind.Local).AddTicks(6546),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 540, DateTimeKind.Local).AddTicks(6053),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 534, DateTimeKind.Local).AddTicks(3008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 534, DateTimeKind.Local).AddTicks(2593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 528, DateTimeKind.Local).AddTicks(7201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 422, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 524, DateTimeKind.Local).AddTicks(2211),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 417, DateTimeKind.Local).AddTicks(8453));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OfferPrice",
                schema: "Sales",
                table: "tbl_Offers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 538, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5352),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 538, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 540, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 540, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 534, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(6895),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 534, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 422, DateTimeKind.Local).AddTicks(6670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 528, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 417, DateTimeKind.Local).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 36, 39, 524, DateTimeKind.Local).AddTicks(2211));
        }
    }
}
