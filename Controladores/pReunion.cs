using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_4.Entidades;

namespace Tp_4.Controladores
{
    internal class pReunion
    {
        //Devuelve la lista de reuniones que hay en la BD
        public static List<Reunion> getAll()
        {
            List<Reunion> reuniones = new List<Reunion>();
            SQLiteCommand cmd = new SQLiteCommand("Select Id, Lugar, Hora, Id_Participante_expositor From Reunion");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Reunion reunion = new Reunion();
                reunion.Id = obdr.GetInt32(0);
                reunion.Lugar = obdr.GetString(1);
                reunion.Hora = TimeOnly.Parse(obdr.GetString(2));
                reunion.Asistencias = pParticipante.GetAll();
                reunion.Expositor = pParticipante.getbyId(obdr.GetInt32(3)).Nombre;
                reuniones.Add(reunion);

            }

            return reuniones;
        }
        //Retorna la Reunión por el ID
        public static Reunion getbyId(int id)
        {
            Reunion reunion = new Reunion();
            SQLiteCommand cmd = new SQLiteCommand("Select Id, Lugar, Hora, Id_Participante_expositor From Reunion WHERE id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;

            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {

                reunion.Id = obdr.GetInt32(0);
                reunion.Lugar = obdr.GetString(1);
                reunion.Hora = TimeOnly.Parse(obdr.GetString(2));
                reunion.Asistencias = pParticipante.GetAll();
                reunion.Expositor = pParticipante.getbyId(obdr.GetInt32(3)).Nombre;

            }

            return reunion;
        }

        //Guarda la Reunión en la BD
        public static void Save(Reunion reunion, int expositorID)
        {
            SQLiteCommand cmd = new SQLiteCommand("insert into Reunion(Lugar, Hora, Id_Participante_expositor) VALUES (@Lugar, @Hora, @Id_Participante_expositor)");
            cmd.Parameters.Add(new SQLiteParameter("@Lugar", reunion.Lugar));
            cmd.Parameters.Add(new SQLiteParameter("@Hora", reunion.Hora));
            cmd.Parameters.Add(new SQLiteParameter("@Id_Participante_expositor", expositorID));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Borra la reunión de la BD
        public static void Delete(Reunion reunion)
        {
            SQLiteCommand cmd = new SQLiteCommand("delete from Reunion where id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", reunion.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Actualiza la reunión que recibe por parametro en la BD
        public static void Update(Reunion reunion)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Reunion SET Lugar = @Lugar, Hora = @Hora WHERE Id =@Id");
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@Id", reunion.Id));
            cmd.Parameters.Add(new SQLiteParameter("@Lugar", reunion.Lugar));
            cmd.Parameters.Add(new SQLiteParameter("@Hora", reunion.Hora));
            //cmd.Parameters.Add(new SQLiteParameter("@Id_Participante_expositor", reunion.Expositor.Id));

            cmd.ExecuteNonQuery();
        }

        //Guardo en la tabla intermedia 
        public static void SaveReuniones_Asistentes(int id_reunion, int id_asistente)
        {
            SQLiteCommand cmd = new SQLiteCommand("insert into Reunion_Asistentes(Id_Reunion, Id_Participante) values(@Id_Reunion, @Id_Participante)");
            cmd.Parameters.Add(new SQLiteParameter("@Id_Reunion", id_reunion));
            cmd.Parameters.Add(new SQLiteParameter("@Id_Participante", id_asistente));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Borro de la tabla intermedia
        public static void DeleteReuniones_Asistentes(int reunionID, int participanteID)
        {
            SQLiteCommand cmd = new SQLiteCommand("delete from Reunion_Asistentes where Id_Participante = @Id_Participante and Id_Reunion = @Id_Reunion");
            cmd.Parameters.Add(new SQLiteParameter("@Id_Participante", participanteID));
            cmd.Parameters.Add(new SQLiteParameter("@Id_Reunion", reunionID));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Obtengo una lista de reuniones por el Id del evento que recibe por parametro
        public static List<Reunion> getByEvento(int eventoID)
        {
            List<Reunion> reuniones = new List<Reunion>();
            SQLiteCommand cmd = new SQLiteCommand("Select Id_Reunion From Evento_Reunion where Id_Evento = @eventoID");
            cmd.Parameters.Add(new SQLiteParameter("@eventoID", eventoID));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Reunion reunion = getbyId(obdr.GetInt32(0));
                reuniones.Add(reunion);
            }
            return reuniones;
        }

        //Retorna el estado de presente o ausente del participante
        public static bool verificarAsistencia(int id_reunion, int id_asistente)
        {
            bool presente = false;

            SQLiteCommand cmd = new SQLiteCommand("select Id_Participante from Reunion_Asistentes where Id_Reunion = @id_reunion");
            cmd.Parameters.Add(new SQLiteParameter("@id_reunion", id_reunion));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Participante participante = new Participante();
                participante.Id = obdr.GetInt32(0);
                if (participante.Id == id_asistente)
                {

                    presente = true;
                }
            }
            return presente;
        }

        // para que no se repita la asistencia de un usuario en la bdd
        public static bool compararConTablaMedia(int participanteID, int reunionID)
        {
            SQLiteCommand cmd = new SQLiteCommand("Select Id_Participante from Reunion_Asistentes where Id_Reunion = @Id_Reunion");
            cmd.Parameters.Add(new SQLiteParameter("Id_Reunion", reunionID));
            cmd.Connection = Conexion.Connection;

            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Participante participante = new Participante();
                participante.Id = obdr.GetInt32(0);

                if (participante.Id == participanteID)
                {
                    return true;

                }

            }
            return false;

        }
    }
}
