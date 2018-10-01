using System;

namespace Siseve.Dominio
{
    public class TipoEventoFactory
    {
        private string Descricao { get; set; }
        private int IdUsuarioInclusao { get; set; }

        public TipoEventoFactory(string descricao, int idUsuarioInclusao)
        {
            Descricao = descricao;
            IdUsuarioInclusao = idUsuarioInclusao;
        }

        public TipoEvento Criar()
        {
            return new TipoEvento
            {
                Descricao = Descricao,
                Ativo = true,
                DataInclusao = DateTime.Now,
                IdUsuarioInclusao = IdUsuarioInclusao
            };
        }
    }
}
