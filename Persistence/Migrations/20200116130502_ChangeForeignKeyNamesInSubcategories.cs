using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeForeignKeyNamesInSubcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(1659),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(788),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 82, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 388, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 71, DateTimeKind.Local).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 382, DateTimeKind.Local).AddTicks(7569));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7016),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 388, DateTimeKind.Local).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 82, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 382, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 71, DateTimeKind.Local).AddTicks(6698));
        }
    }
}
