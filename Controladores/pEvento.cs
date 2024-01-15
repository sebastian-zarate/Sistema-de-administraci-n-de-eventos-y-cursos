using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tp_4.Entidades;

namespace Tp_4.Controladores
{
    internal class pEvento
    {
        //Devuelvo la lista de eventos de la BD
        public static List<Evento> getAll()
        {
            List<Evento> eventos = new List<Evento>();
            SQLiteCommand cmd = new SQLiteCommand("select id, Nombre, Id_TipoEvento, CantidadHoras, Fecha, Lugar from Evento");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                Evento evento = new Evento();
                evento.Id = obdr.GetInt32(0);
                evento.Nombre = obdr.GetString(1);
                evento.TipoEventoNombre = pTipoEvento.GetbyId(obdr.GetInt32(2)).Nombre;       
                evento.CantidadHoras = obdr.GetDouble(3);
                evento.Fecha = DateOnly.Parse(obdr.GetString(4));
                evento.Lugar = obdr.GetString(5);
                evento.Participantes = pParticipante.getByEvento(evento.Id);
                evento.Reuniones = pReunion.getByEvento(evento.Id);
                eventos.Add(evento);
            }
            return eventos;
        }
        //Deveulve Evento por ID de la BD
        public static Evento getById(int id)
        {
            Evento evento = new Evento();
            SQLiteCommand cmd = new SQLiteCommand("select id, Nombre, Id_TipoEvento, CantidadHoras, Fecha, Lugar from Evento where id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                evento.Id = obdr.GetInt32(0);
                evento.Nombre = obdr.GetString(1);
                evento.TipoEventoNombre = pTipoEvento.GetbyId(obdr.GetInt32(2)).Nombre;
                evento.CantidadHoras = obdr.GetDouble(3);
                evento.Fecha = DateOnly.Parse(obdr.GetString(4));
                evento.Lugar = obdr.GetString(5);
                evento.Participantes = pParticipante.getByEvento(evento.Id);
                evento.Reuniones = pReunion.getByEvento(evento.Id);

            }
            return evento;
        }
        //Guardo el Evento en la BD recibiendo como argumento: el id del tipoEvento al que pertenece, y el evento que se va a guardar
        public static void Save(Evento evento, int tipoEventoID)
        {
            SQLiteCommand cmd = new SQLiteCommand("Insert into Evento (Nombre, Id_tipoEvento, CantidadHoras, Fecha, Lugar ) VALUES (@Nombre,@Id_tipoEvento, @CantidadHoras, @Fecha,@Lugar)");
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", evento.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@Id_tipoEvento", tipoEventoID));
            cmd.Parameters.Add(new SQLiteParameter("@CantidadHoras", evento.CantidadHoras));
            string f = evento.Fecha.ToString(); 
            cmd.Parameters.Add(new SQLiteParameter("@Fecha", f ));
            cmd.Parameters.Add(new SQLiteParameter("@Lugar", evento.Lugar));
            
            cmd.ExecuteNonQuery();
        }

        //Borro el Evento que se recibe en el argumento
        public static void Delete(Evento evento)
        {
            SQLiteCommand cmd = new SQLiteCommand("delete from Evento where id = @id");
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@id", evento.Id));
            
            cmd.ExecuteNonQuery();
        }

        //Guardo en la tabla intermedia
        public static void SaveEvento_Participantes(int id_evento, int id_participante)
        {
            SQLiteCommand cmd = new SQLiteCommand("Insert into Eventos_Participantes(Id_evento, Id_participantes) values(@Id_evento, @Id_participantes)");      //el id es autoincremental
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@Id_evento", id_evento));
            cmd.Parameters.Add(new SQLiteParameter("@Id_participantes", id_participante));


            cmd.ExecuteNonQuery();          //a diferencia de executeReader ejecuta y no devuelve nada (guardo)
        }
        //Guardo en la tabla intermedia
        public static void SaveEvento_Reuniones(int id_evento, int id_reunion)
        {
            SQLiteCommand cmd = new SQLiteCommand("insert into Evento_Reunion(Id_Evento, Id_Reunion) values(@id_evento, @id_reunion)");      //el id es autoincremental
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@id_evento", id_evento));
            cmd.Parameters.Add(new SQLiteParameter("@id_reunion", id_reunion));



            cmd.ExecuteNonQuery();          //a diferencia de executeReader ejecuta y no devuelve nada (guardo)
        }

        ////Actualizo el evento que se recibe en el argumento
        public static void Update(Evento evento)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Evento SET Nombre = @Nombre, CantidadHoras = @CantidadHoras, Fecha = @Fecha WHERE id = @id");
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@id", evento.Id));
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", evento.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@CantidadHoras", evento.CantidadHoras));
            cmd.Parameters.Add(new SQLiteParameter("@Fecha", evento.Fecha));

            cmd.ExecuteNonQuery();
        }

       
    }
}
