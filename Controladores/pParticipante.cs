using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp_4.Entidades;

namespace Tp_4.Controladores
{

    internal class pParticipante
    {
        public static List<Participante> GetAll()
        {
            List<Participante> participantes = new List<Participante>();
            SQLiteCommand cmd = new SQLiteCommand("SELECT Id, Nombre, Apellido, Id_tipoParticipante FROM Participantes");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();

            while (obdr.Read())
            {
                Participante participante = new Participante();
                participante.Id = obdr.GetInt32(0);
                participante.Nombre = obdr.GetString(1);
                participante.Apellido = obdr.GetString(2);

                // Obtén el tipo de participante directamente
                TipoParticipante tipo = pTipoParticipante.GetbyId(obdr.GetInt32(3));

                // Asigna el tipo de participante al participante
                participante.TipoParticipante = tipo;

                // Muestra el nombre del tipo de participante en tu control en la interfaz gráfica
                // Aquí se asume que lblTipoParticipante es un control de texto, ajusta según tus necesidades
                // lblTipoParticipante.Text = tipo.Nombre;

                // Obtén el nombre del tipo y asigna al participante
                participante.TipoParticipanteNombre = tipo.Nombre;

                participantes.Add(participante);
            }

            return participantes;
        }




        // Metodo de filtrado por id del Evento 
        public static Participante getbyId(int id)
        {
            Participante participante = new Participante();
            //  MessageBox.Show($"argumento de entrada {id}");
            SQLiteCommand cmd = new SQLiteCommand("select Id, Nombre, Apellido, Id_tipoParticipante from Participantes where Id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                participante.Id = obdr.GetInt32(0);
                participante.Nombre = obdr.GetString(1);
                participante.Apellido = obdr.GetString(2);
                participante.TipoParticipante = pTipoParticipante.GetbyId(obdr.GetInt32(3));

            }
            return participante;
        }
        
        public static List<Participante> getByEvento(int eventoID)
        {
            List<Participante> participantes = new List<Participante>();
            SQLiteCommand cmd = new SQLiteCommand("Select Id_Participantes From Eventos_Participantes where Id_Evento = @eventoID");
            cmd.Parameters.Add(new SQLiteParameter("@eventoID", eventoID));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Participante participante = getbyId(obdr.GetInt32(0));
                participantes.Add(participante);

            }

            return participantes;
        }
        //Metodo de obtencion del id para filtrar por tipo de participante
        public static List<Participante> getByTipoParticipante(int tipo)
        {
            List<Participante> participantes = new List<Participante>();
            SQLiteCommand cmd = new SQLiteCommand("Select Id From Participantes where Id_tipoParticipante = @Id_tipoParticipante");
            cmd.Parameters.Add(new SQLiteParameter("@Id_tipoParticipante", tipo));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                Participante participante = getbyId(obdr.GetInt32(0));
                participantes.Add(participante);

            }

            return participantes;
        }

        


        public static void Save(Participante participante, int tipo)
        {

            SQLiteCommand cmd = new SQLiteCommand("insert into Participantes(Nombre, Apellido, Id_tipoParticipante) VALUES (@nombre, @apellido, @id_tipoParticipante)");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", participante.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", participante.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@id_tipoParticipante", tipo));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }



        public static void Delete(Participante participante)
        {
            SQLiteCommand cmd = new SQLiteCommand("delete from Participantes where id = @id");
            cmd.Parameters.Add(new SQLiteParameter("@id", participante.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
        }

        public static void Update(Participante participante)
        {
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Participantes SET Nombre = @Nombre, Apellido = @Apellido, Id_tipoParticipante = @Id_tipoParticipante WHERE Id = @Id");
            cmd.Connection = Conexion.Connection;
            cmd.Parameters.Add(new SQLiteParameter("@Id", participante.Id));
            cmd.Parameters.Add(new SQLiteParameter("@Nombre", participante.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@Apellido", participante.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@Id_tipoParticipante", participante.TipoParticipante.Id));

            cmd.ExecuteNonQuery();
        }
    }

}
