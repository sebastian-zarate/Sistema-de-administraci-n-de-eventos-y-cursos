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
    public partial class ReunionDelEvento : Form
    {
        static int expositorID = -1, eventoId = -1;

        static Reunion reunion = new Reunion();                                         //reunion que voy a agregar BD, a la tabla intermedia 
        static List<Reunion> reunionesTemporales = new List<Reunion>();                  //lista de reuniones temporales que uso para conseguir el último evento agregado
        public ReunionDelEvento(int eventoID)                //recibo por parametro el id del evento al que va a pertenecer la reunion
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
            tbLugarReuinion.Text = string.Empty;
            tbHoraReunion.Text = string.Empty;
            expositorID = -1;
            cbExpositor.Text = string.Empty;

        }


        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (tbLugarReuinion.Text.Length == 0 || tbHoraReunion.Text.Length == 0
                || (int)cbExpositor.SelectedValue != expositorID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }

            else
            {
                //guardo los datos del nuevo participante con sus atributos en los text box y combbox
                reunion.Lugar = tbLugarReuinion.Text;
                reunion.Hora = TimeOnly.Parse(tbHoraReunion.Text);
                reunion.Expositor = pParticipante.getbyId(expositorID).Nombre;



                pReunion.Save(reunion, expositorID);

                //uso una lista temporal para llamar a todos  los reuniones y obtener el participante que recien agregue
                reunionesTemporales = pReunion.getAll();
                reunion = reunionesTemporales[reunionesTemporales.Count - 1];  //busco el participante recien agregado para obtener su id, que voy a necesitar para la tabla intermedia

                pEvento.SaveEvento_Reuniones(eventoId, reunion.Id);
                MessageBox.Show($"Se guardó el evento {pEvento.getById(eventoId).Nombre} con su reunión: {reunion.Lugar}");


                Close();
                //seteo los textos y combbox 
                tbHoraReunion.Text = string.Empty;
                tbHoraReunion.Text = string.Empty;
                expositorID = -1;
                cbExpositor.Text = string.Empty;
            }

        }

        private void cbExpositor_Click(object sender, EventArgs e)
        {
            //paso al combbox la lista de expositores
            participanteBindingSource.DataSource = pParticipante.getByTipoParticipante(1);
        }

        private void cbExpositor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asigno la variable al nuevo valor elegido en el combbox
            expositorID = (int)cbExpositor.SelectedValue;
        }


    }
}
