using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_4.Entidades;

namespace Tp_4.Controladores
{
    internal class pTipoParticipante
    {
        //Obtengo tipo de participante por ID
        public static TipoParticipante GetbyId(int id)
        {
            TipoParticipante tip = new TipoParticipante();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id, nombre FROM TipoParticipante WHERE id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                tip.Id = obdr.GetInt32(0);
                tip.Nombre = obdr.GetString(1);
            }
            return tip;
        }

        //Actualizo el tipo de participante que se recibe en el argumento
        public static void Update(TipoParticipante tipo)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TipoParticipante SET Nombre = @nombre WHERE Id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", tipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", tipo.Nombre));
        
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Obtengo los tipos de participantes  
        public static List<TipoParticipante> getAll()
        {
            List<TipoParticipante> tiposParticipante = new List<TipoParticipante>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id, Nombre From TipoParticipante");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                TipoParticipante tipoParticipante  = new TipoParticipante();
                tipoParticipante.Id = obdr.GetInt32(0);
                tipoParticipante.Nombre = obdr.GetString(1);
                tiposParticipante.Add(tipoParticipante);
            }
            return tiposParticipante;
        }
    }
}
