using System;

namespace Siseve.Dominio
{
    public abstract class CamposDefault
    {
        public virtual int Id { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual DateTime DataInclusao { get; set; }
        public virtual int IdUsuarioInclusao { get; set; }
        public virtual DateTime? DataAlteracao { get; set; }
        public virtual int? IdUsuarioAlteracao { get; set; }

        public string IdFormatado
        {
            set { Id = Convert.ToInt32(value); }
        }
    }
}
