using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tp_4.Entidades
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoParticipanteNombre { get; set; }
        public TipoParticipante TipoParticipante { get; set; }
        public Participante() { }

        public Participante(int id, string nombre, string apellido, TipoParticipante tipoParticipante)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            TipoParticipante = tipoParticipante;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
