using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp_4.Controladores;
using Tp_4.Entidades;

namespace Tp_4.Formularios
{
    public partial class ParticipantesDelEvento : Form
    {
        static int tipoParticipanteID = -1, eventoId = -1;

        static Participante participante = new Participante();                                  //participante que voy a agregar BD, a la tabla intermedia 
        static List<Participante> reunionesTemporales = new List<Participante>();            //lista de participantes temporales que uso para conseguir el último evento agregado
        

        public ParticipantesDelEvento(int eventoID)         //recibo por parametro el id del evento al que va a pertenecer el participante
        {
            InitializeComponent();
            eventoId = eventoID;

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            // Reinicio los textos y variables, y salgo de la ventana
            MessageBox.Show("No se guardo níngun participante al evento");
            //borro de la BD el evento que agregué para tener como referencia su ID, ya que no lo quiero guardar en la tabla intermedia
            pEvento.Delete(pEvento.getById(eventoId));
            Close();
            tbNombreParticipante.Text = string.Empty;
            tbApellidoParticipante.Text = string.Empty;
            tipoParticipanteID = -1;
            cbTipoParticipante.Text = string.Empty;

        }




        private void ParticipantesDelEvento_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (tbNombreParticipante.Text.Length == 0 || tbApellidoParticipante.Text.Length == 0
                || (int)cbTipoParticipante.SelectedValue != tipoParticipanteID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }

            else
            {
                //guardo los datos del nuevo participante con sus atributos en los text box y combbox
                participante.Nombre = tbNombreParticipante.Text;
                participante.Apellido = tbApellidoParticipante.Text;
                participante.TipoParticipanteNombre = pTipoParticipante.GetbyId(tipoParticipanteID).Nombre;

                //MessageBox.Show($"Participante: {participante.Id}. /*{participante.Nombre} - {participante.Apellido} - {participante.TipoParticipanteNombre}*/");
                pParticipante.Save(participante, tipoParticipanteID);

                //uso una lista temporal para llamar a todos  los participantes y obtener el participante que recien agregue
                reunionesTemporales = pParticipante.GetAll();
                participante = reunionesTemporales[reunionesTemporales.Count - 1];  //busco el participante recien agregado para obtener su id, que voy a necesitar para la tabla intermedia

                //guardo en tabla intermedia
                pEvento.SaveEvento_Participantes(eventoId, participante.Id);
                MessageBox.Show($"Se guardó el evento {pEvento.getById(eventoId).Nombre} con su participante: {participante.Nombre}");

                //seteo los textos y combbox 
                Close();
                tbNombreParticipante.Text = string.Empty;
                tbApellidoParticipante.Text = string.Empty;
                cbTipoParticipante.Text = string.Empty;
                tipoParticipanteID = -1;
                //MessageBox.Show($"Participante: {participante.Id}. /*{participante.Nombre} - {participante.Apellido} - {participante.TipoParticipanteNombre}*/");
            }

        }

        private void cbTipoParticipante_Click(object sender, EventArgs e)
        {
            //paso al combbox la lista de tipos de participantes
            tipoParticipanteBindingSource.DataSource = pTipoParticipante.getAll();
        }

        private void cbTipoParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asigno la variable al nuevo valor elegido en el combbox
            tipoParticipanteID = (int)cbTipoParticipante.SelectedValue;
        }


    }
}
