using Siseve.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Siseve.Contexto.Configurations
{
    public class TipoServicoConfiguration : EntityTypeConfiguration<TipoServico>
    {
        public TipoServicoConfiguration()
        {
            ToTable("TIPO_SERVICO");

            HasKey(tipoServico => tipoServico.Id)
                .Property(tipoServico => tipoServico.Id)
                .HasColumnName("ID_TIPO_SERVICO")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(tipoServico => tipoServico.Descricao).HasColumnName("DESCRICAO").HasMaxLength(30).IsRequired();

            Property(tipoServico => tipoServico.Ativo).HasColumnName("ATIVO").IsRequired();
            Property(tipoServico => tipoServico.DataInclusao).HasColumnName("DATA_INCLUSAO").IsRequired();
            Property(tipoServico => tipoServico.IdUsuarioInclusao).HasColumnName("ID_USUARIO_INCLUSAO").IsRequired();
            Property(tipoServico => tipoServico.DataAlteracao).HasColumnName("DATA_ALTERACAO").IsOptional();
            Property(tipoServico => tipoServico.IdUsuarioAlteracao).HasColumnName("ID_USUARIO_ALTERACAO").IsOptional();
        }
    }
}
