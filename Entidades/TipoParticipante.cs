using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_4.Entidades
{
    public class TipoParticipante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoParticipante() { }
        public TipoParticipante(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;

        }
    }
}
