using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateAdressesScima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(8194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 401, DateTimeKind.Local).AddTicks(2956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 400, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 396, DateTimeKind.Local).AddTicks(1423),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 394, DateTimeKind.Local).AddTicks(9806));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(7129),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5910),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5448),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 400, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 401, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 394, DateTimeKind.Local).AddTicks(9806),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 396, DateTimeKind.Local).AddTicks(1423));
        }
    }
}
