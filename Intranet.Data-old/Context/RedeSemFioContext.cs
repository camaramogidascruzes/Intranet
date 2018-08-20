using System.Data.Entity;

namespace Intranet.Data.Context
{
    public class RedeSemFioContext : DbContext
    {
        public RedeSemFioContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
