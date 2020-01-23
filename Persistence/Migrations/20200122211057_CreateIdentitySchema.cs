using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.RenameTable(
                name: "tbl_SubCategories",
                schema: "Admin",
                newName: "tbl_SubCategories",
                newSchema: "Products");

            migrationBuilder.RenameTable(
                name: "tbl_Items",
                schema: "Admin",
                newName: "tbl_Items",
                newSchema: "Products");

            migrationBuilder.RenameTable(
                name: "tbl_Categories",
                schema: "Admin",
                newName: "tbl_Categories",
                newSchema: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(8327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_SubCategories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(7867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6780),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Items",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 211, DateTimeKind.Local).AddTicks(3353),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 900, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Products",
                table: "tbl_Categories",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 207, DateTimeKind.Local).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 895, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Offers",
                schema: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    OfferPrice = table.Column<decimal>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CraetedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8268)),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    ModifiedBy = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 220, DateTimeKind.Local).AddTicks(8687))
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Offers_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "tbl_Offers",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "tbl_SubCategories",
                schema: "Products",
                newName: "tbl_SubCategories",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "tbl_Items",
                schema: "Products",
                newName: "tbl_Items",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "tbl_Categories",
                schema: "Products",
                newName: "tbl_Categories",
                newSchema: "Admin");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(2148),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 910, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 222, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3968),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 906, DateTimeKind.Local).AddTicks(3271),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 216, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 900, DateTimeKind.Local).AddTicks(6725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 211, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CraetedAt",
                schema: "Admin",
                table: "tbl_Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 1, 20, 16, 38, 9, 895, DateTimeKind.Local).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 1, 22, 23, 10, 57, 207, DateTimeKind.Local).AddTicks(605));
        }
    }
}
