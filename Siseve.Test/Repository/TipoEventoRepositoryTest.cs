using Microsoft.VisualStudio.TestTools.UnitTesting;
using Siseve.Dominio;
using Siseve.Infraestrutura;

namespace Siseve.Test.Repository
{
    [TestClass]
    public class TipoEventoRepositoryTest
    {
        private readonly TipoEventoRepository _tipoEventoRepository = new TipoEventoRepository();
        private TipoEvento _tipoEvento;

        [TestInitialize]
        public void Initialize()
        {
            var tipoEventoFactory = new TipoEventoFactory("Casamento", 1);
            _tipoEvento = tipoEventoFactory.Criar();
            _tipoEventoRepository.IncluirTipoEvento(_tipoEvento);
        }

        [TestMethod]
        public void TestarIncluirTipoEvento()
        {
            var tipoEventoFactory = new TipoEventoFactory("1 Ano", 1);
            var tipoEventoNovo = tipoEventoFactory.Criar();

            _tipoEventoRepository.IncluirTipoEvento(tipoEventoNovo);

            var tiposEvento = _tipoEventoRepository.ObterTipoEventoPorId(tipoEventoNovo.Id);
            Assert.IsNotNull(tiposEvento);
            _tipoEventoRepository.RemoverTipoEvento(tipoEventoNovo);
        }

        [TestMethod]
        public void TestarAlterarTipoEvento()
        {
            const string descricao = "Casamentos";
            _tipoEvento.Descricao = descricao;
            _tipoEventoRepository.AlterarTipoEvento(_tipoEvento);

            var t = _tipoEventoRepository.ObterTipoEventoPorId(_tipoEvento.Id);
            Assert.AreEqual(t.Descricao, descricao);
        }

        [TestMethod]
        public void TestarRemoverCliente()
        {
            var tipoEventoFactory = new TipoEventoFactory("Teste", 1);
            var tipoEvento = tipoEventoFactory.Criar();

            _tipoEventoRepository.IncluirTipoEvento(tipoEvento);

            var tipoEventosInserido = _tipoEventoRepository.ObterTipoEventoPorId(tipoEvento.Id);
            Assert.AreEqual(tipoEvento.Descricao, tipoEventosInserido.Descricao);

            _tipoEventoRepository.RemoverTipoEvento(tipoEvento);
            var tipoEventosApagado = _tipoEventoRepository.ObterTipoEventoPorId(tipoEvento.Id);

            Assert.AreEqual(tipoEventosApagado, null);
        }
    }
}
