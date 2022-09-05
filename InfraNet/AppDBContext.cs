using Microsoft.EntityFrameworkCore;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.FinanceiroInfo;

namespace SaborDoSertão.InfraNet
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Financeiro> FinanceiroTable { get; set; } 

    }
}
