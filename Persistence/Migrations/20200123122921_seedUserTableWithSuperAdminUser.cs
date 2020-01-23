using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seedUserTableWithSuperAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5878),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(7925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(6895),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 422, DateTimeKind.Local).AddTicks(6670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 192, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 417, DateTimeKind.Local).AddTicks(8453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 183, DateTimeKind.Local).AddTicks(631));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(6875),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 441, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(8063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 443, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(4642),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 430, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 192, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 422, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 183, DateTimeKind.Local).AddTicks(631),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 29, 20, 417, DateTimeKind.Local).AddTicks(8453));
        }
    }
}
