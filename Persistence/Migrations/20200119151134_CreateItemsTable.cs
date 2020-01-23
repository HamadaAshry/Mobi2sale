using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7866),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 186, DateTimeKind.Local).AddTicks(2618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 82, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 179, DateTimeKind.Local).AddTicks(3132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 71, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.CreateTable(
                name: "tbl_Items",
                schema: "Admin",
                columns: table => new
                {
                    pk_Items_Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SupplyPrice = table.Column<decimal>(type: "money", nullable: false),
                    RetailPrice = table.Column<decimal>(nullable: false),
                    WholesalePrice = table.Column<decimal>(type: "money", nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SafeLimit = table.Column<int>(nullable: false),
                    MainImageUrl = table.Column<string>(nullable: false),
                    CoverImageUrl = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CraetedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1435)),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 201, DateTimeKind.Local).AddTicks(1985)),
                    fk_subCategories_Items_SubcategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Items", x => x.pk_Items_Id);
                    table.ForeignKey(
                        name: "FK_tbl_Items_tbl_SubCategories_fk_subCategories_Items_SubcategoryId",
                        column: x => x.fk_subCategories_Items_SubcategoryId,
                        principalSchema: "Admin",
                        principalTable: "tbl_SubCategories",
                        principalColumn: "pk_Subcategories_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Items_fk_subCategories_Items_SubcategoryId",
                schema: "Admin",
                table: "tbl_Items",
                column: "fk_subCategories_Items_SubcategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Items",
                schema: "Admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(1659),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 111, DateTimeKind.Local).AddTicks(788),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 205, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 82, DateTimeKind.Local).AddTicks(5130),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 186, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 16, 15, 5, 2, 71, DateTimeKind.Local).AddTicks(6698),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 19, 17, 11, 34, 179, DateTimeKind.Local).AddTicks(3132));
        }
    }
}
