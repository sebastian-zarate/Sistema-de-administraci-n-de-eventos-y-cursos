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
    public partial class ParticipanteEliminar : Form
    {
        static int IDparticipante = -1;// variable para guardar el id del participante
        public ParticipanteEliminar()
        {
            InitializeComponent();
        }
        private void cbEventoEliminar_Click(object sender, EventArgs e)
        {
            // obtengo los participantes existentes
            participanteBindingSource.DataSource = pParticipante.GetAll();
        }

        private void cbEventoEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guardo en una variable en id del participante seleccionado
            IDparticipante = (int)cbEliminarParticipante.SelectedValue;

        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (cbEliminarParticipante.SelectedValue == null)
            {
                // mensaje sino se completan todos los campos 
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                // obtengo los datos del participante selecionado y lo elimino
                Participante partici = pParticipante.getbyId(IDparticipante);
                pParticipante.Delete(partici);

                IDparticipante = -1;
                Close();


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            // cerrar ventana
            Close();
        }

    }
}
