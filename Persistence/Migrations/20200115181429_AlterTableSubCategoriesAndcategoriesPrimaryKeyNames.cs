using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AlterTableSubCategoriesAndcategoriesPrimaryKeyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(7032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(6670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 850, DateTimeKind.Local).AddTicks(5285),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 515, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 842, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 506, DateTimeKind.Local).AddTicks(6002));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8537),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8139),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 515, DateTimeKind.Local).AddTicks(4098),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 850, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 506, DateTimeKind.Local).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 842, DateTimeKind.Local).AddTicks(6443));
        }
    }
}
