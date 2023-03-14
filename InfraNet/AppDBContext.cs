using Microsoft.EntityFrameworkCore;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.Domain;
using Microsoft.EntityFrameworkCore.Internal;
//using SaborDoSertão.Servicos.SeedService;

namespace SaborDoSertão.InfraNet
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Financeiro> FinanceiroTable { get; set; } 
        public DbSet<Comanda> ComandasTable { get; set; }
        public DbSet<Produto> ProdutosTable { get; set; }
        public DbSet<Pedido> PedidosTable { get; set; }
        public DbSet<Pagamento> PagamentosTable { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
                        
            //new SeedService(modelBuilder).Seed();

            
        }
    }
}
