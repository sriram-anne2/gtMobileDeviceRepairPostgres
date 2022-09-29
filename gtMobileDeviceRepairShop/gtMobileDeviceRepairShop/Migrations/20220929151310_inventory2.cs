using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace gtMobileDeviceRepairShop.Migrations
{
    /// <inheritdoc />
    public partial class inventory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartId",
                table: "inventory_entry",
                newName: "PartsId");

            migrationBuilder.AddColumn<long>(
                name: "PartId",
                table: "inventory_full",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_inventory_full_PartId",
                table: "inventory_full",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_inventory_entry_PartsId",
                table: "inventory_entry",
                column: "PartsId");

            migrationBuilder.AddForeignKey(
                name: "FK_inventory_entry_partdirectory_PartsId",
                table: "inventory_entry",
                column: "PartsId",
                principalTable: "partdirectory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_inventory_full_partdirectory_PartId",
                table: "inventory_full",
                column: "PartId",
                principalTable: "partdirectory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_inventory_entry_partdirectory_PartsId",
                table: "inventory_entry");

            migrationBuilder.DropForeignKey(
                name: "FK_inventory_full_partdirectory_PartId",
                table: "inventory_full");

            migrationBuilder.DropIndex(
                name: "IX_inventory_full_PartId",
                table: "inventory_full");

            migrationBuilder.DropIndex(
                name: "IX_inventory_entry_PartsId",
                table: "inventory_entry");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "inventory_full");

            migrationBuilder.RenameColumn(
                name: "PartsId",
                table: "inventory_entry",
                newName: "PartId");
        }
    }
}
