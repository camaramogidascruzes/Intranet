using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Geral;

namespace Intranet.Data.EntityConfiguration.Geral
{
    public class FuncionarioConfiguration : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfiguration()
        {
            this.ToTable("GeralFuncionarios");
            this.HasKey(f => f.Id);
            this.Property(t => t.Id).HasColumnName("id").IsRequired();
            this.Property(f => f.Nome).HasColumnName("nome").HasMaxLength(255);
            this.Property(f => f.Nascimento).HasColumnName("datanascimento");
            this.Property(f => f.Excluido).HasColumnName("excluido").IsRequired();

            this.HasOptional(f => f.Setor).WithMany(s => s.Funcionarios);
            this.HasMany(f => f.Cargos).WithRequired(c => c.Funcionario).HasForeignKey(f => f.Idfuncionario);
            this.HasMany(f => f.Contatos).WithRequired(c => c.Funcionario).HasForeignKey(c => c.IdFuncionario);
        }
    }

    public class FuncionarioContatoConfiguration : EntityTypeConfiguration<FuncionarioContato>
    {
        public FuncionarioContatoConfiguration()
        {
            this.ToTable("GeralFuncionarioContatos");
            this.HasKey(c => c.Id);
            this.Property(t => t.Id).HasColumnName("id").IsRequired();
            this.Property(f => f.Excluido).HasColumnName("excluido").IsOptional();

            this.HasRequired(c => c.Funcionario).WithMany(c => c.Contatos);
        }
    }

    public class OcupacaoConfiguration : EntityTypeConfiguration<Ocupacao>
    {
        public OcupacaoConfiguration()
        {
            this.ToTable("GeralFuncionariosCargos");
            this.HasKey(o => new
            {
                o.Idcargo,
                o.Idfuncionario
            });

            this.Property(o => o.Idcargo).HasColumnName("idcargo").IsRequired();
            this.Property(o => o.Idfuncionario).HasColumnName("idfuncionario").IsRequired();
            this.Property(c => c.Rgf).HasColumnName("rgf").IsRequired();

            this.HasRequired(o => o.Funcionario).WithMany(func => func.Cargos);
            this.HasRequired(o => o.Cargo).WithMany(func => func.Funcionarios);
        }
    }

}