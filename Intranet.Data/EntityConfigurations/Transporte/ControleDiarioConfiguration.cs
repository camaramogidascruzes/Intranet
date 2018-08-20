using System.Data.Entity.ModelConfiguration;
using Intranet.Domain.Entities.Transporte;

namespace Intranet.Data.EntityConfigurations.Transporte
{
    public class ControleDiarioConfiguration : EntityTypeConfiguration<ControleDiario>
    {
        public ControleDiarioConfiguration()
        {
            this.ToTable("TransporteControleDiario");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID").IsRequired();
            this.Property(c => c.Data).HasColumnName("data").IsRequired();
            this.Property(c => c.Numero).HasColumnName("numero").IsRequired();
            this.Property(c => c.TermoResponsabilidadeDestino).HasColumnName("termoresponsabilidadedestino").IsOptional();
            this.Property(c => c.TermoResponsabilidadeFinalidade).HasColumnName("termoresponsabilidadefinalidade").IsOptional();
            this.Property(c => c.Excluido).HasColumnName("excluido").IsRequired();

            this.HasOptional(c => c.FuncionarioRequisitante).WithMany().HasForeignKey(c => c.IdFuncionarioRequisitante);
            this.HasOptional(c => c.ParlamentarRequisitante).WithMany().HasForeignKey(c => c.IdParlamentarRequisitante);
            this.HasRequired(c => c.Motorista).WithMany().HasForeignKey(c => c.IdMotorista);

            this.HasMany(c => c.VeiculosUtilizados).WithRequired(v => v.ControleDiario);
            this.HasMany(c => c.Pedagios).WithRequired(p => p.ControleDiario);
            this.HasMany(c => c.Abastecimentos).WithRequired(a => a.ControleDiario);
            this.HasMany(c => c.ItinerariosForaMunicipio).WithRequired(i => i.ControleDiario);
        }
    }

    public class ControleDiarioVeiculosUtilizadosConfiguration : EntityTypeConfiguration<ControleDiarioVeiculosUtilizados>
    {
        public ControleDiarioVeiculosUtilizadosConfiguration()
        {
            this.ToTable("TransporteControleDiarioVeiculosUtilizados");
            this.HasKey(v => v.Id);
            this.Property(v => v.Saida).HasColumnName("saida").IsRequired();
            this.Property(v => v.OdometroSaida).HasColumnName("odometroraida").IsRequired();
            this.Property(v => v.Retorno).HasColumnName("retorno").IsRequired();
            this.Property(v => v.OdometroRetorno).HasColumnName("odometroretorno").IsRequired();

            this.HasRequired(v => v.Veiculo).WithMany().HasForeignKey(v => v.IdVeiculo);
            this.HasRequired(v => v.ControleDiario).WithMany(c => c.VeiculosUtilizados).HasForeignKey(v => v.IdControleDiario);
        }
    }

    public class ControleDiarioPedagioConfiguration : EntityTypeConfiguration<ControleDiarioPedagio>
    {
        public ControleDiarioPedagioConfiguration()
        {
            this.ToTable("TransporteControleDiarioPedagio");
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasColumnName("id").IsRequired();
            this.Property(p => p.Local).HasColumnName("local").HasMaxLength(255).IsRequired();
            this.Property(p => p.Numero).HasColumnName("numero").HasMaxLength(255).IsRequired();
            this.Property(p => p.Data).HasColumnName("datahora").IsRequired();
            this.Property(p => p.Valor).HasColumnName("valor").IsRequired();
            this.Property(p => p.Observacao).HasColumnName("observacao").IsOptional();

            this.HasRequired(p => p.ControleDiario).WithMany(c => c.Pedagios).HasForeignKey(p => p.IdControleDiario);

        }
    }

    public class AbastecimentoConfiguration : EntityTypeConfiguration<Abastecimento>
    {
        public AbastecimentoConfiguration()
        {
            this.ToTable("TransporteAbastecimento");
            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasColumnName("id").IsRequired();
            this.Property(a => a.NumeroRequisicao).HasColumnName("numerorequisicao").HasMaxLength(255).IsRequired();
            this.Property(a => a.NumeroNotaFiscal).HasColumnName("numeronotafiscal").HasMaxLength(255).IsRequired();
            this.Property(a => a.Quantidade).HasColumnName("quantidade").IsRequired();
            this.Property(a => a.Odometro).HasColumnName("odometro").IsRequired();

            this.HasRequired(a => a.ControleDiario).WithMany(c => c.Abastecimentos).HasForeignKey(a => a.IdControleDiario);
            this.HasRequired(a => a.TipoCombustivel).WithMany().HasForeignKey(a => a.IdTipoCombustivel);

        }
    }

    public class ControleDiarioItinerarioForaMunicipioConfiguration : EntityTypeConfiguration<ControleDiarioItinerarioForaMunicipio>
    {
        public ControleDiarioItinerarioForaMunicipioConfiguration()
        {
            this.ToTable("TransporteControleDiarioItinerarioForaMunicipio");
            this.HasKey(i => i.Id);
            this.Property(c => c.Id).HasColumnName("id").IsRequired();
            this.Property(i => i.HoraSaida).HasColumnName("horasaida").IsRequired();
            this.Property(i => i.HoraRetorno).HasColumnName("horaretorno").IsRequired();
            this.Property(i => i.Destino).HasColumnName("destino").HasMaxLength(255).IsRequired();
            this.Property(i => i.Observacao).HasColumnName("observacao").IsOptional();

            this.HasRequired(i => i.ControleDiario).WithMany(c => c.ItinerariosForaMunicipio).HasForeignKey(i => i.IdControleDiario);
        }
    }
}