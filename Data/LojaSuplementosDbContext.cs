using lojaSuplementosAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace lojaSuplementosAppWeb.Data;


    public class LojaSuplementosDbContext : DbContext
{
    public DbSet<Supplement> Supplement { get; set; }

    public DbSet<Brand> Brand { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        string conn = config.GetConnectionString("Conn");

        optionsBuilder.UseSqlServer(conn);
    }
}

