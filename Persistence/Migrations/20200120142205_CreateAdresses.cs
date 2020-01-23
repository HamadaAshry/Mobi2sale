using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateAdresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(7129),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(6648),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5448),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 400, DateTimeKind.Local).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 551, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 394, DateTimeKind.Local).AddTicks(9806),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 540, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.CreateTable(
                name: "lkp_Countries",
                schema: "Admin",
                columns: table => new
                {
                    pk_Countries_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lkp_Countries", x => x.pk_Countries_Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Governorates_lkp_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "Admin",
                        principalTable: "lkp_Countries",
                        principalColumn: "pk_Countries_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernorateId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GovernoratesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Governorates_GovernoratesId",
                        column: x => x.GovernoratesId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Districts_GovernoratesId",
                table: "Districts",
                column: "GovernoratesId");

            migrationBuilder.CreateIndex(
                name: "IX_Governorates_CountryId",
                table: "Governorates",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Governorates");

            migrationBuilder.DropTable(
                name: "lkp_Countries",
                schema: "Admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 568, DateTimeKind.Local).AddTicks(1348),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 410, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(1478),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 564, DateTimeKind.Local).AddTicks(858),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 406, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 551, DateTimeKind.Local).AddTicks(1069),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 400, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 17, 57, 540, DateTimeKind.Local).AddTicks(5699),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 22, 5, 394, DateTimeKind.Local).AddTicks(9806));
        }
    }
}
