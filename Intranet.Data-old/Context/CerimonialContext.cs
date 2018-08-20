
using System.Data.Entity;

namespace Intranet.Data.Context
{
    public class CerimonialContext : DbContext
    {
        public CerimonialContext() : base("intranet-database")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }
    }
}
