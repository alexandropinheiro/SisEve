using System;

namespace Siseve.Dominio
{
    public class Cliente : CamposDefault
    {
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Identidade { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
