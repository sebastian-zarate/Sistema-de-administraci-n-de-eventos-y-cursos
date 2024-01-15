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

    public partial class ReunionAgregar : Form
    {



        public ReunionAgregar()
        {
            InitializeComponent();
        }

        private int expositorID = -1;

        private Participante participanteSeleccionado;

        public void btAceptarReunion_Click(object sender, EventArgs e)
        {

            cbPartiExp.Refresh();
            // Verifica si alguno de los campos está vacío
            if (string.IsNullOrWhiteSpace(tbHorario.Text) ||
            string.IsNullOrWhiteSpace(tbLugar.Text) ||
            cbPartiExp.SelectedItem == null)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                // Crea un nuevo objeto Participante
                Reunion r = new Reunion();
                // Transforma el tbHorario.Text a TimeOnly 
                r.Hora = TimeOnly.Parse(tbHorario.Text);
                tbHorario.Text = r.Hora.ToString();
                // Asigna valores desde los controles del formulario al objeto Participante
                r.Lugar = tbLugar.Text;
                // Convierte  el contenido del TextBox a TimeOnly aceptando el siguiente formato hh:mm
                if (TimeOnly.TryParse(tbHorario.Text, out TimeOnly horaConvertida))
                {
                    r.Hora = horaConvertida;

                }
                 


                //Asigna el participante seleccionado por el usuario al objeto Participante
                participanteSeleccionado = (Participante)cbPartiExp.SelectedItem;
                if (participanteSeleccionado != null)
                {
                    // El objeto Participante se obtuvo correctamente, continúa con el resto del código
                    expositorID = participanteSeleccionado.Id;

                    // Guarda el objeto Participante
                    pReunion.Save(r, expositorID);

                    // Cierra el formulario
                    Close();
                    cbPartiExp.Refresh();
                }

            }

        }

        private void cbParticipante_click(object sender, EventArgs e)
        {
            // Se obtiene el id del tipo de participante desde el metodo getByTipoParticipante en Participante en este caso el expositor 
            participanteBindingSource.DataSource = pParticipante.getByTipoParticipante(1);
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
