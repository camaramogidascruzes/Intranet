using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.EntityConfiguration.Geral
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            this.ToTable("GeralUsuarios");
            this.HasKey(u => u.Id);
            this.Property(u => u.Id).HasColumnName("id").IsRequired();
            this.Property(u => u.Login).HasColumnName("login").HasMaxLength(255).IsRequired();
            this.Property(u => u.Nome).HasColumnName("nome").HasMaxLength(255).IsRequired();
            this.Property(u => u.PasswordHash).HasColumnName("passwordhHash").HasMaxLength(255).IsRequired();
            this.Property(u => u.DataUltimoLogin).HasColumnName("dataultimologin").IsOptional();
            this.Property(u => u.QuantidadeFalhasAcesso).HasColumnName("quantidadefalhasacesso").IsOptional();
            this.Property(u => u.Bloqueado).HasColumnName("bloqueado").IsOptional();
            this.Property(u => u.TerminoBloqueio).HasColumnName("terminobloqueio").IsOptional();
            this.Property(u => u.Ip).HasColumnName("ipultimoacesso").HasMaxLength(255).IsRequired();
            this.Property(u => u.NecessarioAlterarSenha).HasColumnName("necessarioalterarsenha").IsOptional();

            this.HasMany(u => u.Grupos).WithRequired(u => u.Usuario).HasForeignKey(u => u.IdUsuario);
        }   
    }


    public class UsuarioGrupoConfiguration : EntityTypeConfiguration<UsuarioGrupo>
    {
        public UsuarioGrupoConfiguration()
        {
            this.ToTable("GeralUsuarioGrupo");
            this.HasKey(e => new
            {
                e.IdUsuario,
                e.IdGrupo
            });
            this.HasRequired(ug => ug.Usuario).WithMany(e => e.Grupos);
            this.HasRequired(ug => ug.Grupo).WithMany(e => e.Usuarios);
        }
    }
}