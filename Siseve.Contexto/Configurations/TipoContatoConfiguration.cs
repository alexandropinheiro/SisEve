using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Siseve.Dominio;

namespace Siseve.Contexto.Configurations
{
    public class TipoContatoConfiguration : EntityTypeConfiguration<TipoContato>
    {
        public TipoContatoConfiguration()
        {
            ToTable("TIPO_CONTATO");

            HasKey(tipoContato => tipoContato.Id)
                .Property(tipoContato => tipoContato.Id)
                .HasColumnName("ID_TIPO_CONTATO")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(tipoContato => tipoContato.Descricao).HasColumnName("DESCRICAO").HasMaxLength(30).IsRequired();

            Property(tipoContato => tipoContato.Ativo).HasColumnName("ATIVO").IsRequired();
            Property(tipoContato => tipoContato.DataInclusao).HasColumnName("DATA_INCLUSAO").IsRequired();
            Property(tipoContato => tipoContato.IdUsuarioInclusao).HasColumnName("ID_USUARIO_INCLUSAO").IsRequired();
            Property(tipoContato => tipoContato.DataAlteracao).HasColumnName("DATA_ALTERACAO").IsOptional();
            Property(tipoContato => tipoContato.IdUsuarioAlteracao).HasColumnName("ID_USUARIO_ALTERACAO").IsOptional();
        }
    }
}
