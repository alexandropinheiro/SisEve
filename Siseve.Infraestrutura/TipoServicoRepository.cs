using Siseve.Contexto;
using Siseve.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siseve.Infraestrutura
{
    public class TipoServicoRepository
    {
        private readonly SiseveContext _contexto = new SiseveContext();

        public IEnumerable<TipoServico> ObterTodos()
        {
            var query = from tiposServico in _contexto.TiposServico
                        select tiposServico;
            return query.ToList();
        }

        public TipoServico ObterTipoServicoPorId(int idTipoServico)
        {
            var query = from tiposServico in _contexto.TiposServico
                        where tiposServico.Id == idTipoServico
                        select tiposServico;
            return query.FirstOrDefault();
        }

        public void IncluirTipoServico(TipoServico tipoServico)
        {
            _contexto.TiposServico.Add(tipoServico);
            _contexto.SaveChanges();
        }

        public void AlterarTipoServico(TipoServico tipoServico)
        {
            var c = (from fp in _contexto.TiposServico
                     where fp.Id == tipoServico.Id
                     select fp).FirstOrDefault();

            if (c != null)
            {
                c.Descricao = tipoServico.Descricao;
                c.Ativo = tipoServico.Ativo;
                c.DataAlteracao = DateTime.Now;
                c.IdUsuarioAlteracao = 1;
            }
            _contexto.SaveChanges();
        }

        public void RemoverTipoServico(TipoServico tipoServico)
        {
            _contexto.TiposServico.Remove(tipoServico);
            _contexto.SaveChanges();
        }
    }
}
