using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_4.Entidades;

namespace Tp_4.Controladores
{
    internal class pTipoEvento
    {
        //Obtengo el tipo de evento por ID
        public static TipoEvento GetbyId(int id)
        {
            TipoEvento tip = new TipoEvento();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id, nombre FROM TipoEvento WHERE id = @id");
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

        //Actualizo el tipo de evento que se recibe en el argumento
        public static void Update(TipoEvento tipo)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE TipoEvento SET Nombre = @nombre WHERE Id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", tipo.Id));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", tipo.Nombre));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        //Obtengo los tipos de eventos 
        public static List<TipoEvento> getAll()
        {
            List<TipoEvento> tiposEventos = new List<TipoEvento>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id, Nombre FROM TipoEvento ");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                TipoEvento tipoEvento = new TipoEvento();
                tipoEvento.Id = obdr.GetInt32(0);
                tipoEvento.Nombre = obdr.GetString(1);
                tiposEventos.Add(tipoEvento);
            }
            return tiposEventos;
        }
    }
}
