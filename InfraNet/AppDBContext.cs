using Microsoft.EntityFrameworkCore;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.Domain;

namespace SaborDoSertão.InfraNet
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Financeiro> FinanceiroTable { get; set; } 
        public DbSet<Comanda> ComandasTable { get; set; }
        public DbSet<Produto> ProdutosTable { get; set; }
    }
}
