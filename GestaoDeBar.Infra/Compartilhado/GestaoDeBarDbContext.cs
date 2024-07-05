using GestaoDeBar.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeBar.Infra.Compartilhado
{
    public class GestaoDeBarDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GestaoDeBar;Integrated Security=True;Pooling=False";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
