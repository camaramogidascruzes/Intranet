using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Cerimonial;

namespace Intranet.Data.EntityConfigurations.Cerimonial
{
    public class AutoridadeGrupoCerimonialConfiguration : EntityTypeConfiguration<AutoridadeGrupoCerimonial>
    {
        public AutoridadeGrupoCerimonialConfiguration()
        {
            this.ToTable("CerimonialAutoridadeGrupos");
            this.HasKey(e => new
            {
                e.IdAutoridade,
                e.IdGrupoCerimonial
            });

            this.HasRequired(ga => ga.Autoridade).WithMany(e => e.Grupos);
            this.HasRequired(ga => ga.GrupoCerimonial).WithMany(g => g.Autoridades);
        }
    }
}