using System;

namespace Siseve.Dominio
{
    public class FormaPagamentoFactory
    {
        private string Descricao { get; set; }
        private int IdUsuarioInclusao { get; set; }

        public FormaPagamentoFactory(string descricao, int idUsuarioInclusao)
        {
            Descricao = descricao;
            IdUsuarioInclusao = idUsuarioInclusao;
        }

        public FormaPagamento Criar()
        {
            return new FormaPagamento
            {
                Descricao = Descricao,
                Ativo = true,
                DataInclusao = DateTime.Now,
                IdUsuarioInclusao = IdUsuarioInclusao
            };
        }
    }
}
