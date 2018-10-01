
using System.Linq;

using Siseve.Contexto;
using Siseve.Dominio;
using System.Collections.Generic;

namespace Siseve.Infraestrutura
{
    public class ClienteRepository
    {
        private readonly SiseveContext _contexto = new SiseveContext();

        public IEnumerable<Cliente> ObterTodos() {

            var query = from clientes in _contexto.Clientes
                        select clientes;
            return query.ToList();
        }

        public Cliente ObterClientePorId(int idCliente)
        {
            var query = from clientes in _contexto.Clientes
                        where clientes.IdCliente == idCliente
                        select clientes;
            return query.FirstOrDefault();
        }

        public void IncluirCliente(Cliente cliente) {
            _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();
        }

        public void AlterarCliente(int id) {
            var c = (from cliente in _contexto.Clientes
                    where cliente.IdCliente == id
                    select cliente).FirstOrDefault();

            if (c != null) {
                c.Identidade = "567";
            }
            _contexto.SaveChanges();
        }

        public void RemoverCliente(int id) {
            var c = from cliente in _contexto.Clientes
                    where cliente.IdCliente == id
                    select cliente;
            _contexto.Clientes.RemoveRange(c);
            _contexto.SaveChanges();
        }

    }
}
