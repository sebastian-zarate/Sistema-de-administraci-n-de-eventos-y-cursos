using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_4.Entidades
{
    public class TipoEvento
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoEvento() { }
        public TipoEvento(int id, string nombre) 
        {
           Id = id;
           Nombre = nombre;

        }

    }
}
