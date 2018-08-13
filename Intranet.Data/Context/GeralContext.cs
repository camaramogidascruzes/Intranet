using System.Data.Entity;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.Context
{
    public class GeralContext : DbContext
    {
        public GeralContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<TipoEmpresa> TiposEmpresa { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Parlamentar> Parlamentares { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
