using System;
using System.Collections.Generic;
using System.Linq;
using Siseve.Contexto;
using Siseve.Dominio;

namespace Siseve.Infraestrutura
{
    public class TipoEventoRepository
    {
        private readonly SiseveContext _contexto = new SiseveContext();

        public IEnumerable<TipoEvento> ObterTodos()
        {

            var query = from tiposEvento in _contexto.TiposEvento
                        select tiposEvento;
            return query.ToList();
        }

        public TipoEvento ObterTipoEventoPorId(int idTipoEvento)
        {
            var query = from tiposEvento in _contexto.TiposEvento
                        where tiposEvento.Id == idTipoEvento
                        select tiposEvento;
            return query.FirstOrDefault();
        }

        public void IncluirTipoEvento(TipoEvento tipoEvento)
        {
            _contexto.TiposEvento.Add(tipoEvento);
            _contexto.SaveChanges();
        }

        public void AlterarTipoEvento(TipoEvento tipoEvento)
        {
            var c = (from te in _contexto.TiposEvento
                     where te.Id == tipoEvento.Id
                     select te).FirstOrDefault();

            if (c != null)
            {
                c.Descricao = tipoEvento.Descricao;
                c.Ativo = tipoEvento.Ativo;
                c.DataAlteracao = DateTime.Now;
                c.IdUsuarioAlteracao = 1;
            }
            _contexto.SaveChanges();
        }

        public void RemoverTipoEvento(TipoEvento tipoEvento)
        {
            _contexto.TiposEvento.Remove(tipoEvento);
            _contexto.SaveChanges();
        }
    }
}
