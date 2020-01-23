using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateAdressesScimaForGovernorates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Governorates_GovernoratesId",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Governorates_lkp_Countries_CountryId",
                table: "Governorates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Governorates",
                table: "Governorates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Districts",
                table: "Districts");

            migrationBuilder.DropIndex(
                name: "IX_Districts_GovernoratesId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "GovernoratesId",
                table: "Districts");

            migrationBuilder.RenameTable(
                name: "Governorates",
                newName: "lkp_Governorates",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "Districts",
                newName: "lkp_Districts",
                newSchema: "Admin");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Admin",
                table: "lkp_Governorates",
                newName: "pk_Governorates_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Governorates_CountryId",
                schema: "Admin",
                table: "lkp_Governorates",
                newName: "IX_lkp_Governorates_CountryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "Admin",
                table: "lkp_Districts",
                newName: "pk_Districts_Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(2148),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 900, DateTimeKind.Local).AddTicks(6725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 401, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 895, DateTimeKind.Local).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 396, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Admin",
                table: "lkp_Governorates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "Admin",
                table: "lkp_Districts",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkp_Governorates",
                schema: "Admin",
                table: "lkp_Governorates",
                column: "pk_Governorates_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_lkp_Districts",
                schema: "Admin",
                table: "lkp_Districts",
                column: "pk_Districts_Id");

            migrationBuilder.CreateIndex(
                name: "IX_lkp_Districts_GovernorateId",
                schema: "Admin",
                table: "lkp_Districts",
                column: "GovernorateId");

            migrationBuilder.AddForeignKey(
                name: "FK_lkp_Districts_lkp_Governorates_GovernorateId",
                schema: "Admin",
                table: "lkp_Districts",
                column: "GovernorateId",
                principalSchema: "Admin",
                principalTable: "lkp_Governorates",
                principalColumn: "pk_Governorates_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_lkp_Governorates_lkp_Countries_CountryId",
                schema: "Admin",
                table: "lkp_Governorates",
                column: "CountryId",
                principalSchema: "Admin",
                principalTable: "lkp_Countries",
                principalColumn: "pk_Countries_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lkp_Districts_lkp_Governorates_GovernorateId",
                schema: "Admin",
                table: "lkp_Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_lkp_Governorates_lkp_Countries_CountryId",
                schema: "Admin",
                table: "lkp_Governorates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lkp_Governorates",
                schema: "Admin",
                table: "lkp_Governorates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_lkp_Districts",
                schema: "Admin",
                table: "lkp_Districts");

            migrationBuilder.DropIndex(
                name: "IX_lkp_Districts_GovernorateId",
                schema: "Admin",
                table: "lkp_Districts");

            migrationBuilder.RenameTable(
                name: "lkp_Governorates",
                schema: "Admin",
                newName: "Governorates");

            migrationBuilder.RenameTable(
                name: "lkp_Districts",
                schema: "Admin",
                newName: "Districts");

            migrationBuilder.RenameColumn(
                name: "pk_Governorates_Id",
                table: "Governorates",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_lkp_Governorates_CountryId",
                table: "Governorates",
                newName: "IX_Governorates_CountryId");

            migrationBuilder.RenameColumn(
                name: "pk_Districts_Id",
                table: "Districts",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5657),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 410, DateTimeKind.Local).AddTicks(5288),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(8194),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 406, DateTimeKind.Local).AddTicks(7812),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 401, DateTimeKind.Local).AddTicks(2956),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 900, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 34, 6, 396, DateTimeKind.Local).AddTicks(1423),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 895, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Governorates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Districts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "GovernoratesId",
                table: "Districts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Governorates",
                table: "Governorates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Districts",
                table: "Districts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_GovernoratesId",
                table: "Districts",
                column: "GovernoratesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Governorates_GovernoratesId",
                table: "Districts",
                column: "GovernoratesId",
                principalTable: "Governorates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Governorates_lkp_Countries_CountryId",
                table: "Governorates",
                column: "CountryId",
                principalSchema: "Admin",
                principalTable: "lkp_Countries",
                principalColumn: "pk_Countries_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
