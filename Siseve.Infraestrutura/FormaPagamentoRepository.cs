using Siseve.Contexto;
using Siseve.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siseve.Infraestrutura
{
    public class FormaPagamentoRepository
    {
        private readonly SiseveContext _contexto = new SiseveContext();

        public IEnumerable<FormaPagamento> ObterTodos()
        {
            var query = from formasPagamento in _contexto.FormasPagamento
                        select formasPagamento;
            return query.ToList();
        }

        public FormaPagamento ObterFormaPagamentoPorId(int idFormaPagamento)
        {
            var query = from formasPagamento in _contexto.FormasPagamento
                        where formasPagamento.Id == idFormaPagamento
                        select formasPagamento;
            return query.FirstOrDefault();
        }

        public void IncluirFormaPagamento(FormaPagamento formaPagamento)
        {
            _contexto.FormasPagamento.Add(formaPagamento);
            _contexto.SaveChanges();
        }

        public void AlterarFormaPagamento(FormaPagamento formaPagamento)
        {
            var c = (from fp in _contexto.FormasPagamento
                     where fp.Id == formaPagamento.Id
                     select fp).FirstOrDefault();

            if (c != null)
            {
                c.Descricao = formaPagamento.Descricao;
                c.Ativo = formaPagamento.Ativo;
                c.DataAlteracao = DateTime.Now;
                c.IdUsuarioAlteracao = 1;
            }
            _contexto.SaveChanges();
        }

        public void RemoverFormaPagamento(FormaPagamento formaPagamento)
        {
            _contexto.FormasPagamento.Remove(formaPagamento);
            _contexto.SaveChanges();
        }
    }
}
