using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRelationBetweenCategoriesandSubcategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(8454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(7032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(7912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.AddColumn<Guid>(
                name: "fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 521, DateTimeKind.Local).AddTicks(9598),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 850, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 511, DateTimeKind.Local).AddTicks(270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 842, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.CreateIndex(
                name: "IX_tbl_SubCategories_fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories",
                column: "fk_Categories_subCategories_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_SubCategories_tbl_Categories_fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories",
                column: "fk_Categories_subCategories_CategoryId",
                principalSchema: "Admin",
                principalTable: "tbl_Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_SubCategories_tbl_Categories_fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_tbl_SubCategories_fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories");

            migrationBuilder.DropColumn(
                name: "fk_Categories_subCategories_CategoryId",
                schema: "Admin",
                table: "tbl_SubCategories");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(7032),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 854, DateTimeKind.Local).AddTicks(6670),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 576, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 850, DateTimeKind.Local).AddTicks(5285),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 521, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 20, 14, 28, 842, DateTimeKind.Local).AddTicks(6443),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 21, 57, 59, 511, DateTimeKind.Local).AddTicks(270));
        }
    }
}
