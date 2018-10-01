using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Siseve.Contexto.Configurations;
using Siseve.Dominio;

namespace Siseve.Contexto
{
    public class SiseveContext : DbContext
    {
        public SiseveContext()
            : base("name=SiseveContext")
        {
            InitializeContext();
        }

        private static void InitializeContext()
        {
            Database.SetInitializer<SiseveContext>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoEvento> TiposEvento { get; set; }
        public DbSet<TipoContato> TiposContatos { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<TipoServico> TiposServico { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {       
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new TipoEventoConfiguration());
            modelBuilder.Configurations.Add(new TipoContatoConfiguration());
            modelBuilder.Configurations.Add(new FormaPagamentoConfiguration());
            modelBuilder.Configurations.Add(new TipoServicoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
