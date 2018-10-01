using Siseve.Dominio;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Siseve.Contexto.Configurations
{
    public class FormaPagamentoConfiguration : EntityTypeConfiguration<FormaPagamento>
    {
        public FormaPagamentoConfiguration()
        {
            ToTable("FORMA_PGTO");

            HasKey(formaPagamento => formaPagamento.Id)
                .Property(formaPagamento => formaPagamento.Id)
                .HasColumnName("ID_FORMA_PGTO")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(formaPagamento => formaPagamento.Descricao).HasColumnName("DESCRICAO").HasMaxLength(30).IsRequired();

            Property(formaPagamento => formaPagamento.Ativo).HasColumnName("ATIVO").IsRequired();
            Property(formaPagamento => formaPagamento.DataInclusao).HasColumnName("DATA_INCLUSAO").IsRequired();
            Property(formaPagamento => formaPagamento.IdUsuarioInclusao).HasColumnName("ID_USUARIO_INCLUSAO").IsRequired();
            Property(formaPagamento => formaPagamento.DataAlteracao).HasColumnName("DATA_ALTERACAO").IsOptional();
            Property(formaPagamento => formaPagamento.IdUsuarioAlteracao).HasColumnName("ID_USUARIO_ALTERACAO").IsOptional();
        }
    }
}
