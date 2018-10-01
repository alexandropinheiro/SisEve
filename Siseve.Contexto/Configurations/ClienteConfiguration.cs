using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

using Siseve.Dominio;

namespace Siseve.Contexto.Configurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente> {
        public ClienteConfiguration() {
            ToTable("CLIENTE");

            HasKey(cliente => cliente.IdCliente).Property(cliente => cliente.IdCliente).HasColumnName("ID_CLIENTE").
                    HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            Property(cliente => cliente.NomeCliente).HasMaxLength(255).HasColumnName("NOME_CLIENTE").IsRequired();
            Property(cliente => cliente.DataNascimento).HasColumnName("DATA_NASCIMENTO").IsOptional();
            Property(cliente => cliente.Identidade).HasMaxLength(20).HasColumnName("IDENTIDADE").IsOptional();
        }
    }
}
