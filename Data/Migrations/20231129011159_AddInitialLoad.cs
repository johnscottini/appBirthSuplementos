using lojaSuplementosAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lojaSuplementosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialLoad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new LojaSuplementosDbContext();
            context.Brand.AddRange(GetInitialLoad());
            context.SaveChanges();
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

        private IList<Brand> GetInitialLoad()
        {
            return new List<Brand>()
            {
                new Brand() { description = "Growth"},
                new Brand() { description = "Max Titanium"},
                new Brand() { description = "Essential"},
            };
        }
    }
}
