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
    public partial class ReunionModificar : Form
    {
        static int reunionID = -1;
        //private Participante participanteSeleccionado;

        public ReunionModificar()
        {
            InitializeComponent();
            cbReunionModificar.Text = "Seleccione una reunión";
        }


        private void btAceptar_Click(object sender, EventArgs e)
        {

            // Verifica si todos los datos esten completos 
            if (string.IsNullOrWhiteSpace(tbHorario.Text) ||
            string.IsNullOrWhiteSpace(tbLugar.Text) || (int)cbReunionModificar.SelectedValue != reunionID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {

                // Se guardan los datos de la reunion modificada y se guarda en la base de datos 
                Reunion reunion = pReunion.getbyId(reunionID);
                reunion.Lugar = tbLugar.Text;
                reunion.Hora = TimeOnly.Parse(tbHorario.Text);
                pReunion.Update(reunion);
                reunionID = -1;
                Close();
            }

        }


        
        private void btCANCELAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Obtiene la reunion seleccionada y es mostrada en el comboBox
        private void cbReunionModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            reunionID = (int)cbReunionModificar.SelectedValue;
        }


        //Obtiene las reuniones existentes de la base de datos 
        private void cbReunionModificar_Click(object sender, EventArgs e)
        {
            reunionBindingSource.DataSource = pReunion.getAll();
        }
    }
}





