using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateTableSubCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "lkp_Categories",
                schema: "Admin",
                newName: "tbl_Categories",
                newSchema: "Admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 515, DateTimeKind.Local).AddTicks(4098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 749, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 506, DateTimeKind.Local).AddTicks(6002),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 742, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.CreateTable(
                name: "tbl_SubCategories",
                schema: "Admin",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CraetedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8139)),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 519, DateTimeKind.Local).AddTicks(8537))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_SubCategories_Id", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_SubCategories",
                schema: "Admin");

            migrationBuilder.RenameTable(
                name: "tbl_Categories",
                schema: "Admin",
                newName: "lkp_Categories",
                newSchema: "Admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "lkp_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 749, DateTimeKind.Local).AddTicks(9887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 515, DateTimeKind.Local).AddTicks(4098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "lkp_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 12, 20, 47, 11, 742, DateTimeKind.Local).AddTicks(3616),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 15, 19, 51, 10, 506, DateTimeKind.Local).AddTicks(6002));
        }
    }
}
