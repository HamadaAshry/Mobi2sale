using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTheFiveCommonPropereties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "lkp_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 742, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "Admin",
                table: "lkp_Categories",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Admin",
                table: "lkp_Categories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "lkp_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 749, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "Admin",
                table: "lkp_Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CraetedAt",
                schema: "Admin",
                table: "lkp_Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "Admin",
                table: "lkp_Categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Admin",
                table: "lkp_Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "Admin",
                table: "lkp_Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "Admin",
                table: "lkp_Categories");
        }
    }
}
