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
    public partial class ParticipantesEdicion : Form
    {
        static int TipodeParticipanteID = -1;// variable donde guardo el id del tipo participante
        public ParticipantesEdicion()
        {
            InitializeComponent();
           
        }
        private void cbtAceptarParticipante_Click(object sender, EventArgs e)
        {
            
            if (tbApellidoParticipante.Text.Length == 0 || tbNombreParticipante.Text.Length == 0
                        || (int)cbTipoParticipante.SelectedValue != TipodeParticipanteID)
            {
                // mensaje de que debe cargar todos los campos 
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                //guardo el participante creado
                Participante participante = new Participante();
                participante.Nombre = tbNombreParticipante.Text;
                participante.Apellido = tbApellidoParticipante.Text;
                pParticipante.Save(participante, TipodeParticipanteID);
                // reinicio la variable 
                TipodeParticipanteID = -1;
                Close();
            }
        }

        private void cbTipoParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guardo la varible del tipo de participante seleccionado en el combox
            TipodeParticipanteID = (int)cbTipoParticipante.SelectedValue;
           
        }
        private void cbTipoParticipante_Click(object sender, EventArgs e)
        {
            // obtengo los tipo de particiapntes 
            tipoParticipanteBindingSource.DataSource = pTipoParticipante.getAll();

        }
        private void btCancelarEvento_Click(object sender, EventArgs e)
        {
            // cerrar ventana 
            Close();
        }
    }
}
