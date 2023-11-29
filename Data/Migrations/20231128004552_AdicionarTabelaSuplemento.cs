using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaSuplementosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaSuplemento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplement",
                columns: table => new
                {
                    SupplementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    HasGluten = table.Column<bool>(type: "bit", nullable: false),
                    ImageUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplement", x => x.SupplementId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplement");
        }
    }
}
