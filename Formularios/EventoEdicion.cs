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
    public partial class EventoEdicion : Form
    {
        static int tipoEventoID = -1;
        static List<Evento> eventosTemporales = new List<Evento>();         //lista de eventos temporales que uso para conseguir el último evento agregado
        public EventoEdicion()
        {
            InitializeComponent();
            cbTipoEvento.Text = "Seleccione un Tipo de evento";
            tbFechaEvento.Text = "Ingrese la fecha en formato dd/mm/yyyy";
        }

        private void cbtAceptarEvento_Click(object sender, EventArgs e)
        {
            //condicionales para que la fecha tenga más de 9 caracteres y dos '/'
            if (tbFechaEvento.Text.Length >= 9)
            {
                if (tbFechaEvento.Text[2] == '/' && tbFechaEvento.Text[5] == '/')
                {
                    //valido que esten todos los datos
                    if (tbNombreEvento.Text.Length == 0 || tbCantidadHorasEvento.Text.Length == 0 || tbLugarEvento.Text.Length == 0
                        || (int)cbTipoEvento.SelectedValue != tipoEventoID)
                    {
                        MessageBox.Show("Debe cargar todos los datos");
                    }
                    else
                    {
                        if (eventosTemporales.Count == 0)           //si es la primera vez que paso por la interface de agregar eventos, la lista temporal va a estar vacia por lo que guardar en la BD el evento
                        {
                            //guardo los datos del nuevo evento con sus atributos en los text box
                            Evento evento = new Evento();
                            evento.Nombre = tbNombreEvento.Text;
                            evento.CantidadHoras = int.Parse(tbCantidadHorasEvento.Text);
                            evento.Fecha = DateOnly.Parse(tbFechaEvento.Text);
                            evento.Lugar = tbLugarEvento.Text;

                            //MessageBox.Show($"El id del tipoEvento: {tipoEventoID} - Nombre: {evento.Nombre} - cantidadhr: {evento.CantidadHoras} - fecha: {evento.Fecha} - lugar: {evento.Lugar}");
                            pEvento.Save(evento, tipoEventoID);         //guardo en la BD el nuevo evento para después tener información de su ID

                        }
                        //Reinicio los textos y variables, y salgo de la ventana
                        tbNombreEvento.Text = string.Empty;
                        tbCantidadHorasEvento.Text = string.Empty;
                        tbFechaEvento.Text = string.Empty;
                        tbLugarEvento.Text = string.Empty;
                        cbTipoEvento.Text = "Seleccione un Tipo de evento";
                        tbFechaEvento.Text = "Ingrese la fecha en formato dd/mm/yyyy";
                        tipoEventoID = -1;
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
            tbLugarEvento.Text = string.Empty;
            cbTipoEvento.Text = "Seleccione un Tipo de evento";
            tbFechaEvento.Text = "Ingrese la fecha en formato dd/mm/yyyy";
            tipoEventoID = -1;
            Close();
        }

        private void cbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asigno la variable al nuevo valor elegido en el combbox
            tipoEventoID = (int)cbTipoEvento.SelectedValue;

        }

        private void cbTipoEvento_Click(object sender, EventArgs e)
        {
            //cargo el combobox con la lista de tipo de evento de la BD
            tipoEventoBindingSource.DataSource = pTipoEvento.getAll();

        }


        private void tbFechaEvento_Click(object sender, EventArgs e)
        {
            if (tbFechaEvento.Text == "Ingrese la fecha en formato dd/mm/yyyy")
            {
                tbFechaEvento.Text = string.Empty;
            }

        }

        private void EventoEdicion_Load(object sender, EventArgs e)
        {

        }

        private void btAgregarParticipante_Click(object sender, EventArgs e)
        {

            if (tbNombreEvento.Text.Length == 0 || tbCantidadHorasEvento.Text.Length == 0 || tbLugarEvento.Text.Length == 0
                || (int)cbTipoEvento.SelectedValue != tipoEventoID)
            {
                MessageBox.Show("Debe cargar todos los datos para agregar un participante");
            }
            else
            {
                if (eventosTemporales.Count == 0)                    //si es la primera vez que paso por la interface de agregar eventos, la lista temporal va a estar vacia por lo que guardar en la BD el evento
                {
                    //guardo los datos del nuevo evento con sus atributos en los text box
                    Evento evento = new Evento();
                    evento.Nombre = tbNombreEvento.Text;
                    evento.CantidadHoras = int.Parse(tbCantidadHorasEvento.Text);
                    evento.Fecha = DateOnly.Parse(tbFechaEvento.Text);
                    evento.Lugar = tbLugarEvento.Text;
                    pEvento.Save(evento, tipoEventoID);          //guardo en la BD el nuevo evento para después tener información de su ID
                }


                //Guardo en la tabla intermedia
                eventosTemporales = pEvento.getAll();
                //obtengo el id del nuevo evento agregado
                int eventoId = eventosTemporales[eventosTemporales.Count - 1].Id;
                //el id del evento lo paso como parametro para el formulario de participantesDelEvento
                new ParticipantesDelEvento(eventoId).ShowDialog(this.btAceptarEvento);


            }


        }

        private void btAgregarReunion_Click(object sender, EventArgs e)
        {
            if (tbNombreEvento.Text.Length == 0 || tbCantidadHorasEvento.Text.Length == 0 || tbLugarEvento.Text.Length == 0
            || (int)cbTipoEvento.SelectedValue != tipoEventoID)
            {
                MessageBox.Show("Debe cargar todos los datos para agregar reuniones");
            }
            else
            {

                if (eventosTemporales.Count == 0)
                {
                    //guardo
                    Evento evento = new Evento();
                    evento.Nombre = tbNombreEvento.Text;
                    evento.CantidadHoras = int.Parse(tbCantidadHorasEvento.Text);
                    evento.Fecha = DateOnly.Parse(tbFechaEvento.Text);
                    //evento.Lugar= nVarios.CreateMD5(tbClave.Text);
                    evento.Lugar = tbLugarEvento.Text;
                    pEvento.Save(evento, tipoEventoID);
                }


                //Guardo en la tabla intermedia
                eventosTemporales = pEvento.getAll();
                int eventoId = eventosTemporales[eventosTemporales.Count - 1].Id;
                new ReunionDelEvento(eventoId).ShowDialog(this.btAceptarEvento);


            }
        }
    }
}
