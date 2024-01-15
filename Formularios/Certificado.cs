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
    public partial class Certificado : Form
    {
        static Evento evento = new Evento();
        static Participante participante = new Participante();
        public Certificado(int eventoID, int participanteID)
        {

            if (evento != null && participante != null)
            {                
                InitializeComponent();
                evento = pEvento.getById(Form1.eventoID);
                participante = pParticipante.getbyId(Form1.participanteID);

                labelParticipante.Text = participante.ToString();
                labelEvento.Text = evento.Nombre.ToUpper();
                labelFecha.Text = evento.Fecha.ToString();
            }

        }

        private void labelEvento_Click(object sender, EventArgs e)
        {

        }

        private void labelParticipante_Click(object sender, EventArgs e)
        {

        }
    }
}
