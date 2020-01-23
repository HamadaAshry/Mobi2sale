using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangePrimaryKeyNamesInCategoriesAndSubcategorie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Admin",
                table: "tbl_SubCategories",
                newName: "pk_Subcategories_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Admin",
                table: "tbl_Categories",
                newName: "pk_Categories_Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 388, DateTimeKind.Local).AddTicks(6772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 521, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 382, DateTimeKind.Local).AddTicks(7569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 511, DateTimeKind.Local).AddTicks(270));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pk_Subcategories_Id",
                schema: "Admin",
                table: "tbl_SubCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pk_Categories_Id",
                schema: "Admin",
                table: "tbl_Categories",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(7912),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 409, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 521, DateTimeKind.Local).AddTicks(9598),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 388, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 511, DateTimeKind.Local).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 16, 14, 59, 45, 382, DateTimeKind.Local).AddTicks(7569));
        }
    }
}
