using System.Data.Entity;
using Intranet.Data.EntityConfiguration;
using Intranet.Data.EntityConfiguration.Geral;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.Context
{
    public class TesteContext : DbContext
    {
        public TesteContext() : base("intranet-database")
        {
            
        }

        public DbSet<Patrimonio> Patrimonios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DadosAlteracaoRegistroConfiguration());
            modelBuilder.Configurations.Add(new DadosCriacaoRegistroConfiguration());
            modelBuilder.Configurations.Add(new PatrimonioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}