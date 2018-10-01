using System;
using System.Collections.Generic;
using System.Linq;
using Siseve.Contexto;
using Siseve.Dominio;

namespace Siseve.Infraestrutura
{
    public class TipoContatoRepository
    {
        private readonly SiseveContext _contexto = new SiseveContext();

        public IEnumerable<TipoContato> ObterTodos()
        {

            var query = from tiposContato in _contexto.TiposContatos
                        select tiposContato;
            return query.ToList();
        }

        public TipoContato ObterTipoContatoPorId(int idTipoContato)
        {
            var query = from tiposContato in _contexto.TiposContatos
                        where tiposContato.Id == idTipoContato
                        select tiposContato;
            return query.FirstOrDefault();
        }

        public void IncluirTipoContato(TipoContato tipoContato)
        {
            _contexto.TiposContatos.Add(tipoContato);
            _contexto.SaveChanges();
        }

        public void AlterarTipoContato(TipoContato tipoContato)
        {
            var c = (from tc in _contexto.TiposContatos
                     where tc.Id == tipoContato.Id
                     select tc).FirstOrDefault();

            if (c != null)
            {
                c.Descricao = tipoContato.Descricao;
                c.Ativo = tipoContato.Ativo;
                c.DataAlteracao = DateTime.Now;
                c.IdUsuarioAlteracao = 1;
            }
            _contexto.SaveChanges();
        }

        public void RemoverTipoContato(int id)
        {
            var c = from tipoContato in _contexto.TiposContatos
                    where tipoContato.Id == id
                    select tipoContato;
            _contexto.TiposContatos.RemoveRange(c);
            _contexto.SaveChanges();
        }
    }
}
