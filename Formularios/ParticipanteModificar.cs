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
    public partial class ParticipanteModificar : Form
    {
        static int ParticipanteID = -1;
        static int TipodeParticipanteID = -1;
        static Participante par = new Participante();
        public ParticipanteModificar()
        {
            InitializeComponent();

        }


        private void btAceptarParticipante_Click(object sender, EventArgs e)
        {
            if (tbApellidoParticipante.Text.Length == 0 || tbNombreParticipante.Text.Length == 0 || cbTipoParticipante.SelectedValue == null)
            {
                MessageBox.Show("Debe cargar todos los datos");
            }
            else
            {
                // Guardar (Save)
                Participante participante = pParticipante.getbyId(ParticipanteID);

                participante.Nombre = tbNombreParticipante.Text;
                participante.Apellido = tbApellidoParticipante.Text;

                // Verificar si TipoParticipante está asignado
                if (participante.TipoParticipante == null)
                {
                    // Si no está asignado, crea una nueva instancia o maneja la situación de alguna manera
                    participante.TipoParticipante = new TipoParticipante();
                }

                // Obtener el valor seleccionado del combo box (suponiendo que es un objeto TipoParticipante)
                TipoParticipante selectedTipoParticipante = (TipoParticipante)cbTipoParticipante.SelectedItem;

                // Actualizar la propiedad TipoParticipante con el valor seleccionado
                participante.TipoParticipante.Id = selectedTipoParticipante.Id;

                // Actualizar el participante en la base de datos u otra fuente de datos
                pParticipante.Update(participante);

                Close();
            }
        }

        private void cbParticipanteModificar_Click(object sender, EventArgs e)
        {
            // obtengo los participantes

            participanteBindingSource.DataSource = pParticipante.GetAll();
        }

        private void cbModificar_SelectedIndexCanged(object sender, EventArgs e)
        {
            // obtengo el id del particiante seleccionado 
            ParticipanteID = (int)cbParticipanteModificar.SelectedValue;
            par = pParticipante.getbyId((int)ParticipanteID);
            cbParticipanteModificar.Text = string.Empty;
            if (ParticipanteID != null)
            {
                // agregamos los datos del participante selecionado
                tbApellidoParticipante.Text = par.Apellido.ToString();
                tbNombreParticipante.Text = par.Nombre.ToString();




            }
        }


        private void btCancelarEvento_Click(object sender, EventArgs e)
        {

            //Cierra la ventana
            Close();
        }

        private void cbTipoParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            // guardo el id del tipo de participante en la varible
            TipodeParticipanteID = (int)cbTipoParticipante.SelectedValue;
            cbTipoParticipante.Text = string.Empty;
        }
        private void cbTipoParticipante_Clicck(object sender, EventArgs e)
        {
            // obtengo los tipos de tipos
            tipoParticipanteBindingSource.DataSource = pTipoParticipante.getAll();
        }
    }
}
