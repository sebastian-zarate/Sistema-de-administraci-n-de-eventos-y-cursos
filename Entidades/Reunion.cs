using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_4.Entidades
{
    public class Reunion
    {
        public int Id { get; set; }
        public string Lugar { get; set; }
        public TimeOnly Hora { get; set; }
        public string Expositor { get; set; }
        public List<Participante> Asistencias { get; set; }
        public Reunion() 
        { 
            Asistencias = new List<Participante>();
        }
        public Reunion(int id, string lugar, TimeOnly hora, string expositor, List<Participante> asistencias)
        {
            Id = id;
            Lugar = lugar;
            Hora = hora;
            Expositor = expositor;
            Asistencias = asistencias;
        }
    }
}
