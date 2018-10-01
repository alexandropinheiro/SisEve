using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Siseve.Dominio;

namespace Siseve.Contexto.Configurations
{
    public class TipoEventoConfiguration : EntityTypeConfiguration<TipoEvento>
    {
        public TipoEventoConfiguration()
        {
            ToTable("TIPO_EVENTO");

            HasKey(tipoEvento => tipoEvento.Id)
                .Property(tipoEvento => tipoEvento.Id)
                .HasColumnName("ID_TIPO_EVENTO")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(tipoEvento => tipoEvento.Descricao).HasColumnName("DESCRICAO").HasMaxLength(30).IsRequired();
            
            Property(tipoEvento => tipoEvento.Ativo).HasColumnName("ATIVO").IsRequired();
            Property(tipoEvento => tipoEvento.DataInclusao).HasColumnName("DATA_INCLUSAO").IsRequired();
            Property(tipoEvento => tipoEvento.IdUsuarioInclusao).HasColumnName("ID_USUARIO_INCLUSAO").IsRequired();
            Property(tipoEvento => tipoEvento.DataAlteracao).HasColumnName("DATA_ALTERACAO").IsOptional();
            Property(tipoEvento => tipoEvento.IdUsuarioAlteracao).HasColumnName("ID_USUARIO_ALTERACAO").IsOptional();
        }
    }
}
