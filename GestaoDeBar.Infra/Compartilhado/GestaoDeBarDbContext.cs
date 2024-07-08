using GestaoDeBar.Dominio;
using Microsoft.EntityFrameworkCore;

namespace GestaoDeBar.Infra.Compartilhado
{
    public class GestaoDeBarDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        
        public DbSet<Mesa> Mesas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GestaoDeBar;Integrated Security=True;Pooling=False";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>(produtoBuilder =>
            {
                produtoBuilder.ToTable("TBProduto");

                produtoBuilder.Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

                produtoBuilder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(150)");

                produtoBuilder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("int");
            });

            modelBuilder.Entity<Mesa>(mesaBuilder =>
            {
                mesaBuilder.ToTable("TBMesa");

                mesaBuilder.Property(m => m.Id)
                    .IsRequired()
                    .ValueGeneratedOnAdd();
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}