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
    public partial class EliminarReunion : Form
    {
        static int reunionID = -1;
        public EliminarReunion()
        {
            InitializeComponent();
        }

        private void btCancelarReunion_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btAceptarReunion_Click(object sender, EventArgs e)
        {
            if ((int)cbReunionEliminar.SelectedValue != reunionID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                //guardo
                Reunion reunion = pReunion.getbyId(reunionID);
                pReunion.Delete(reunion);
                cbReunionEliminar.Text = "Seleccione evento a elimnar";
                reunionID = -1;
                Close();


            }
        }

        private void cbReunionEliminar_Click(object sender, EventArgs e)
        {
            reunionBindingSource.DataSource = pReunion.getAll();
        }

        private void cbReunionEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            reunionID = (int)cbReunionEliminar.SelectedValue;
        }
    }
}
