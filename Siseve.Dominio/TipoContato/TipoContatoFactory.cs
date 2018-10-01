using System;

namespace Siseve.Dominio
{
    public class TipoContatoFactory
    {
        private string Descricao { get; set; }
        private int IdUsuarioInclusao { get; set; }

        public TipoContatoFactory(string descricao, int idUsuarioInclusao)
        {
            Descricao = descricao;
            IdUsuarioInclusao = idUsuarioInclusao;
        }

        public TipoContato Criar()
        {
            return new TipoContato
            {
                Descricao = Descricao,
                Ativo = true,
                DataInclusao = DateTime.Now,
                IdUsuarioInclusao = IdUsuarioInclusao
            };
        }
    }
}
