using System;

namespace Siseve.Dominio
{
    public class TipoServicoFactory
    {
        private string Descricao { get; set; }
        private int IdUsuarioInclusao { get; set; }

        public TipoServicoFactory(string descricao, int idUsuarioInclusao)
        {
            Descricao = descricao;
            IdUsuarioInclusao = idUsuarioInclusao;
        }

        public TipoServico Criar()
        {
            return new TipoServico
            {
                Descricao = Descricao,
                Ativo = true,
                DataInclusao = DateTime.Now,
                IdUsuarioInclusao = IdUsuarioInclusao
            };
        }
    }
}
