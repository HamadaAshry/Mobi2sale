using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seedUserTableWitAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(7458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(6875),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(8063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(5989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(5188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(4642),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 192, DateTimeKind.Local).AddTicks(783),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 211, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 183, DateTimeKind.Local).AddTicks(631),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 207, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.AddColumn<string>(
                name: "MacAddress",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MacAddress",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8687),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Sales",
                table: "tbl_Offers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8268),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 208, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(7867),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 211, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6780),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6365),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 201, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 211, DateTimeKind.Local).AddTicks(3353),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 192, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 207, DateTimeKind.Local).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 23, 14, 11, 44, 183, DateTimeKind.Local).AddTicks(631));
        }
    }
}
