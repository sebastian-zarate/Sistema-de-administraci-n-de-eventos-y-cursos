using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_4.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoEventoNombre { get; set; }
        public double CantidadHoras { get; set; }
        public DateOnly Fecha { get; set; }
        public string Lugar { get; set; }
        public List<Participante> Participantes { get; set; }
        public List<Reunion> Reuniones { get; set; }
        public Evento() 
        { 
          Participantes = new List<Participante>();
          Reuniones = new List<Reunion>();
        } 
        public Evento(int id, string nombre, string tipoEventoNombre, int cantidadHoras, DateOnly fecha,string lugar) 
        { 
            Id = id;
            Nombre = nombre;
            TipoEventoNombre = tipoEventoNombre;
            Fecha = fecha;
            CantidadHoras = cantidadHoras;
            Lugar = lugar;
            Participantes = new List<Participante>();
            Reuniones = new List<Reunion>();
        }

    }
}
