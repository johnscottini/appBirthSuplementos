using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaSuplementosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationSupplementBrand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Brand",
                table: "Supplement",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "brandId",
                table: "Supplement",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Supplement_brandId",
                table: "Supplement",
                column: "brandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Supplement_Brand_brandId",
                table: "Supplement",
                column: "brandId",
                principalTable: "Brand",
                principalColumn: "brandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Supplement_Brand_brandId",
                table: "Supplement");

            migrationBuilder.DropIndex(
                name: "IX_Supplement_brandId",
                table: "Supplement");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Supplement");

            migrationBuilder.DropColumn(
                name: "brandId",
                table: "Supplement");
        }
    }
}
