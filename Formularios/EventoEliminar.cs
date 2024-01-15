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
    public partial class EventoEliminar : Form
    {
        static int eventoID = -1;
        public EventoEliminar()
        {
            InitializeComponent();
            cbEventoEliminar.Text = "Seleccione evento a elimnar";
        }

        private void cbEventoEliminar_Click(object sender, EventArgs e)
        {
            //paso al combbox la lista de eventos
            eventoBindingSource.DataSource = pEvento.getAll();
        }

        private void cbEventoEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asigno la variable al nuevo valor elegido en el combbox
            eventoID = (int)cbEventoEliminar.SelectedValue;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //si no se selecciono nada en el combbox salta la alerta
            if ((int)cbEventoEliminar.SelectedValue != eventoID)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                //Borro de la BD el evento
                Evento evento = pEvento.getById(eventoID);
                pEvento.Delete(evento);

                //Reinicio los textos y variables, y salgo de la ventana
                cbEventoEliminar.Text = "Seleccione evento a elimnar";
                eventoID = -1;
                Close();


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Reinicio los textos y variables, y salgo de la ventana
            cbEventoEliminar.Text = "Seleccione evento a elimnar";
            eventoID = -1;
            Close();
        }
    }
}
