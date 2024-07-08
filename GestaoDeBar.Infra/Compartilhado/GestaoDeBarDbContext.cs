using GestaoDeBar.Dominio;
using GestaoDeBar.Dominio.ModuloGarcom;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeBar.Infra.Compartilhado
{
    public class GestaoDeBarDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Garcom> Garcons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GestaoDeBar;Integrated Security=True;Pooling=False";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garcom>(garcomBuilder =>
            {
                garcomBuilder.ToTable("TBGarcon");

                garcomBuilder.Property(d => d.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();

                garcomBuilder.Property(d => d.Nome)
                    .IsRequired()
                    .HasColumnType("varchar(250)");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
