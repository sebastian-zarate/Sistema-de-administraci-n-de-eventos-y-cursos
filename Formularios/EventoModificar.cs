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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tp_4.Formularios
{
    public partial class EventoModificar : Form
    {
        static int eventoID = -1;
        public EventoModificar()
        {
            InitializeComponent();
            cbEventoModificar.Text = "Seleccione un evento a modificar";
            //tbFechaEvento.Text = "Ingrese la fecha en formato dd/mm/yyyy";
        }

        private void btAceptarEvento_Click(object sender, EventArgs e)
        {
            //condicionales para que la fecha tenga más de 9 caracteres y dos '/'
            if (tbFechaEvento.Text.Length >= 9)
            {
                if (tbFechaEvento.Text[2] == '/' && tbFechaEvento.Text[5] == '/')
                {
                    //valido que esten todos los datos
                    if (tbNombreEvento.Text.Length == 0 || tbCantidadHorasEvento.Text.Length == 0 || tbFechaEvento.Text.Length == 0 || (int)cbEventoModificar.SelectedValue != eventoID)
                    {
                        MessageBox.Show("Debe cargar todos los datos");
                    }
                    else
                    {
                        //guardo los datos del evento a modificar con sus atributos en los text box
                        Evento evento = pEvento.getById(eventoID);
                        evento.Nombre = tbNombreEvento.Text;
                        evento.CantidadHoras = int.Parse(tbCantidadHorasEvento.Text);
                        evento.Fecha = DateOnly.Parse(tbFechaEvento.Text);
                        pEvento.Update(evento);

                        //Reinicio los textos y variables, y salgo de la ventana
                        tbNombreEvento.Text = string.Empty;
                        tbCantidadHorasEvento.Text = string.Empty;
                        tbFechaEvento.Text = string.Empty;
                        cbEventoModificar.Text = "Seleccione un evento a modificar";
                        Close();
                    }
                }
                else MessageBox.Show("Cargue correctamento los datos de la fecha: (dd/mm/yyyy)");

            }
            else MessageBox.Show("Cargue correctamento los datos de la fecha: (dd/mm/yyyy)");
        }

        private void btCancelarEvento_Click(object sender, EventArgs e)
        {
            //Reinicio los textos y variables, y salgo de la ventana
            tbNombreEvento.Text = string.Empty;
            tbCantidadHorasEvento.Text = string.Empty;
            tbFechaEvento.Text = string.Empty;
            cbEventoModificar.Text = "Seleccione un evento a modificar";
            Close();
        }

        private void cbEventoModificar_SelectedIndexCanged(object sender, EventArgs e)
        {
            // asigno la variable al nuevo valor elegido en el combbox
            eventoID = (int)cbEventoModificar.SelectedValue;
        }

        private void cbEventoModificar_Click(object sender, EventArgs e)
        {
            //cargo el combobox con la lista de eventoso de la BD
            eventoBindingSource.DataSource = pEvento.getAll();
        }

    }
}
