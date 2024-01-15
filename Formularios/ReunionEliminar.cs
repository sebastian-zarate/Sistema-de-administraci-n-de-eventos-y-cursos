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
    public partial class ReunionEliminar : Form
    {
        static int reunionID = -1;
        public ReunionEliminar()
        {
            InitializeComponent();
        }

        private void btCancelarReunion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btAceptarReunion_Click(object sender, EventArgs e)
        {
            //Verifica que todos los campos esten completos 
            if ((int)cbReunionEliminar.SelectedValue != reunionID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                //Se elimina la reunion seleccionada desde el metodo Delete
                Reunion reunion = pReunion.getbyId(reunionID);
                pReunion.Delete(reunion);
                cbReunionEliminar.Text = "Seleccione Reunion a Elimnar";
                reunionID = -1;
                Close();


            }
        }

        //Se obtienen todas la reuniones y se muestra en el combobox
        private void cbReunionEliminar_Click(object sender, EventArgs e)
        {
            reunionBindingSource.DataSource = pReunion.getAll();
        }


        // Se obtiene la reunion seleccionada para eliminar 
        private void cbReunionEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            reunionID = (int)cbReunionEliminar.SelectedValue;
        }
    }
}
