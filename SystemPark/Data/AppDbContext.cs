using Microsoft.EntityFrameworkCore;
using SystemPark.Entities;

namespace SystemPark.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
