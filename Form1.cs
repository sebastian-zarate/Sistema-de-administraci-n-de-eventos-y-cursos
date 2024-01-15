using System.Diagnostics;
using Tp_4.Controladores;
using Tp_4.Controles;
using Tp_4.Entidades;
using Tp_4.Formularios;

namespace Tp_4
{
    public partial class Form1 : Form
    {
        public static int eventoID = -1, participanteID = -1, reunionID = -1;
        static Evento evento = new Evento();
        public Form1()
        {
            InitializeComponent();
            reunionBindingSource.DataSource = pReunion.getAll();
            eventoBindingSource.DataSource = pEvento.getAll();
            participanteBindingSource.DataSource = pParticipante.GetAll();
            cbEventoCertificado.Text = "Seleccione un evento";
            cbParticipanteCertificado.Text = "Seleccionar Participante";
            labelPrincipal.Text = "Adiministración";
            panelABM.Visible = true;
            panelABM.Dock = DockStyle.Fill;



        }
        //Agregar abm Eventos, Reuniones, participantes. Las asistencias.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //--- botones del costado---//
        private void btABM_Click(object sender, EventArgs e)
        {
            labelPrincipal.Text = "Adiministración";
            //color verde del panel
            panelSuperior.BackColor = System.Drawing.ColorTranslator.FromHtml("#36c367");
            panelCertificado.Dock = DockStyle.None;
            tcABM.Dock = DockStyle.Fill;
            panelAsistencias.Dock = DockStyle.None;
            panelABM.Dock = DockStyle.Fill;

            panelABM.Visible = true;
            panelCertificado.Visible = false;
            panelAsistencias.Visible = false;

            reunionBindingSource.DataSource = pReunion.getAll();
            eventoBindingSource.DataSource = pEvento.getAll();
            participanteBindingSource.DataSource = pParticipante.GetAll();
        }

        
        private void btMenuCertificado_Click(object sender, EventArgs e)
        {
            labelPrincipal.Text = "Generar Certificado";
            // color celes del panel
            panelSuperior.BackColor = System.Drawing.ColorTranslator.FromHtml("#179ef7");
            panelABM.Dock = DockStyle.None;
            tcABM.Dock = DockStyle.None;
            panelAsistencias.Dock = DockStyle.None;
            panelCertificado.Dock = DockStyle.Fill;
            panelABM.Visible = false;
            panelCertificado.Visible = true;
            panelAsistencias.Visible = false;

            cbEventoCertificado.Text = "Seleccione un evento";

        }

        private void btAsistencias_Click(object sender, EventArgs e)
        {
            labelPrincipal.Text = "Cargar Asistencias";
            // color naranja del panel
            panelSuperior.BackColor = System.Drawing.ColorTranslator.FromHtml("#f59a7f");
            panelABM.Dock = DockStyle.None;
            panelOpcionesAsistencia.Dock = DockStyle.Left;
            panelbtAsistencias.Dock = DockStyle.Fill;
            tcABM.Dock = DockStyle.None;
            panelCertificado.Dock = DockStyle.None;
            panelAsistencias.Dock = DockStyle.Fill;
            panelABM.Visible = false;
            panelCertificado.Visible = false;
            panelAsistencias.Visible = true;

            eventoBindingSource.DataSource = pEvento.getAll();
            cbEventoAsistencias.Text = "Seleccione un evento";
            cbReunionesAsistencias.Text = "";
        }

        //eventos para cambiar el color de los botones cuando tiene el mouse encima

        private void OnMouseEnterBoton(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = panelSuperior.BackColor;
        }
        private void OnMouseLeaveBoton(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.BackColor = Color.Transparent;
        }

        //-----------------------------------

        private void btAgregarEvento_Click(object sender, EventArgs e)
        {
            new EventoEdicion().ShowDialog(this.tpEvento);
            eventoBindingSource.DataSource = pEvento.getAll();
            participanteBindingSource.DataSource = pParticipante.GetAll();
            reunionBindingSource.DataSource = pReunion.getAll();
        }

        private void btModificarEvento_Click(object sender, EventArgs e)
        {
            new EventoModificar().ShowDialog(this.tpEvento);
            eventoBindingSource.DataSource = pEvento.getAll();
        }

        private void btEliminarEvento_Click(object sender, EventArgs e)
        {
            new EventoEliminar().ShowDialog(this.tpEvento);
            eventoBindingSource.DataSource = pEvento.getAll();
        }
        //-----------------certificado---------//
        private void cbEventoCertificado_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventoID = (int)cbEventoCertificado.SelectedValue;

            evento = pEvento.getById(eventoID);

            Evento eventoFiltrado = new Evento();


            //filtrar los participantes para quitar al participante expositor
            foreach (Participante participante in evento.Participantes)
            {
                if (participante.TipoParticipante.Id != 1)
                {
                    eventoFiltrado.Participantes.Add(participante);
                }
            }

            participanteBindingSource1.DataSource = eventoFiltrado.Participantes;
            cbParticipanteCertificado.Text = "Seleccionar Participante";
        }


        private void cbEventoCertificado_Click(object sender, EventArgs e)
        {
            eventoBindingSource2.DataSource = pEvento.getAll();

        }

        private void cbParticipanteCertificado_SelectedChangedIndex(object sender, EventArgs e)
        {
            participanteID = (int)cbParticipanteCertificado.SelectedValue;
        }

        private void cbParticipanteCertificado_Click(object sender, EventArgs e)
        {
            //participanteBindingSource1.DataSource = pParticipante.GetAll();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Certificado_Click(object sender, EventArgs e)
        {
            if (participanteID == -1)
            {
                MessageBox.Show("Elija un participante!");
            }
            else
            {
                new Certificado(eventoID, participanteID).ShowDialog(this.tpEvento);
            }

        }

        //---------------------------------- ABM Reunion---------------------------------------------------------------------------------------------------------------//


        private void btReunionAgre_Click(object sender, EventArgs e)
        {
            new ReunionAgregar().ShowDialog(this.panel1);
            reunionBindingSource.DataSource = pReunion.getAll();

        }

        private void btModifiReunion_Click(object sender, EventArgs e)
        {

            new ReunionModificar().ShowDialog(this.tpReunion);
            reunionBindingSource.DataSource = pReunion.getAll();

        }

        private void btReunionElim_Click(object sender, EventArgs e)
        {
            new EliminarReunion().ShowDialog(this.tpReunion);
            reunionBindingSource.DataSource = pReunion.getAll();
        }

        //---------------------------------- ABM Participante---------------------------------------------------------------------------------------------------------------//

        private void btAgregarParticipante_Click(object sender, EventArgs e)
        {
            new ParticipantesEdicion().ShowDialog(this.tpParticipante);
            participanteBindingSource.DataSource = pParticipante.GetAll();
        }


        private void btModificarParticipante_Click(object sender, EventArgs e)
        {
            new ParticipanteModificar().ShowDialog(this.tpParticipante);
            participanteBindingSource.DataSource = pParticipante.GetAll();
        }

        private void btElimiarParticipante_Click(object sender, EventArgs e)
        {
            new ParticipanteEliminar().ShowDialog(this.tpParticipante);
            participanteBindingSource.DataSource = pParticipante.GetAll();
        }

        //---------------------------------ASISTENCIAS----------------------------------------//

        // CUANDO SE CAMBIA EL INDICE DEL EVENTO
        private void cbEventoAsistencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEventoAsistencias.SelectedValue != null)
            {
                eventoID = (int)cbEventoAsistencias.SelectedValue;
            }
                
            //borrar los botones para pasar lista (si los hay)
            limpiarBotonesAsistencias(panelbtAsistencias);
            cbReunionesAsistencias.Text = "";

            // conseguir el evento
            evento = pEvento.getById(eventoID);


            //para saber si el evento tiene participantes inscriptos al sistema
            if (evento.Participantes.Count > 0)
            {
                //cargar la cb reunion
                reunionBindingSource.DataSource = evento.Reuniones;

                //borrar los botones para pasar lista (si los hay)
                limpiarBotonesAsistencias(panelbtAsistencias);
                cbReunionesAsistencias.Text = "Seleccione una reunión";
                reunionID = -1;


            }
            //en el caso de que no hallan participantes
            //else
            //{
            //    MessageBox.Show("Este evento no tiene Participantes Registrados!");
            //    cbEventoAsistencias.Text = "Seleccione un evento";
            //    eventoID = -1;

            //}


        }

        // CUANDO SE CAMBIA EL INDICE DE LAS REUNIONES
        private void cbReunionesAsistencias_SelectedIndexChanged(object sender, EventArgs e)
        {

            //borrar botones si los hay
            limpiarBotonesAsistencias(panelbtAsistencias);

            if (cbReunionesAsistencias.SelectedValue != null)
            {
                reunionID = (int)cbReunionesAsistencias.SelectedValue;
            }
            //CREAR BOTONES ASISTENCIAS
            mostrarParticipantes(eventoID, reunionID);

        }

        // crea los botones para tomar asistencias
        private void mostrarParticipantes(int eventoID, int reunionID)
        {

            Evento e = pEvento.getById(eventoID);

            //para crear un boton por cada participante que hau en el evento.
            for (int i = 0; i < e.Participantes.Count; i++)
            {

                // crea un boton del tipo btAsistencia
                btAsistencia bt = new btAsistencia();

                //atributos generales del boton
                bt.Text = e.Participantes[i].ToString();
                bt.Width = 150;
                bt.Height = 30;
                bt.Left = (8);
                bt.Top = (4 + i * (bt.Height + 4));
                bt.FlatStyle = FlatStyle.Flat;
                bt.FlatAppearance.BorderSize = 0;
                bt.ForeColor = Color.White;

                // guarda el id del participante que pertenece al boton
                bt.participanteID = e.Participantes[i].Id;

                // para saber si el participante ya esta cargado en la lista de personas presentes en la reunion
                bt.Presente = pReunion.verificarAsistencia(reunionID, e.Participantes[i].Id);
                if (bt.Presente == true)
                {
                    //si esta presente segun la bdd el boton es verde
                    bt.BackColor = Color.Green;
                }
                //sino es rojo
                else bt.BackColor = Color.Red;

                //asigna el evento
                bt.Click += btAsistente_Click;

                //agregar boton al panel
                panelbtAsistencias.Controls.Add(bt);

            }
        }

        // cuando se hace click en los botones de asistencia
        private void btAsistente_Click(object sender, EventArgs e)
        {
            Controles.btAsistencia button = (Controles.btAsistencia)sender;

            // si el boton era rojo lo cambia a verde, lo pone al participante en presente. el segundo caso es lo mismo pero al reves.
            switch (button.Presente)
            {
                case false: button.Presente = true; button.BackColor = Color.Green; break;
                case true: button.Presente = false; button.BackColor = Color.Red; break;
            }
        }
        // para reiniciar los botones de asistencias
        private void limpiarBotonesAsistencias(Panel p)
        {
            //para borrar todos los botones de asistentes (se usa cuando se cambia el index del cbevento o cbreunion) 
            panelbtAsistencias.Controls.Clear();

        }

        // cambiar todos los asistentes de la reunion a presente
        private void btTodosPresentes_Click(object sender, EventArgs e)
        {
            // recorre el panel de los botones
            List<btAsistencia> botones = new List<btAsistencia>();
            foreach (Control control in panelbtAsistencias.Controls)
            {

                if (control is btAsistencia)
                {
                    // parse de panel.controls a btAsistencia
                    botones.Add(control as btAsistencia);

                }
            }
            // cambia todos a presentes
            foreach (btAsistencia bt in botones)
            {
                bt.Presente = true;
                bt.BackColor = Color.Green;
            }

        }
        // cambiar todos los asistentes de la reunion a ausente (la misma logica del método anterior pero al reves)
        private void btTodosAusentes_Click(object sender, EventArgs e)
        {
            List<btAsistencia> botones = new List<btAsistencia>();
            foreach (Control control in panelbtAsistencias.Controls)
            {

                if (control is btAsistencia)
                {
                    // parse de panel.controls a btAsistencia
                    botones.Add(control as btAsistencia);

                }
            }
            foreach (btAsistencia bt in botones)
            {
                bt.Presente = false;
                bt.BackColor = Color.Red;
            }
        }

        // gaurdar las asistencias en la tabla de la bdd
        private void btGuardarAsistencia_Click(object sender, EventArgs e)
        {
            if (reunionID != -1 && panelbtAsistencias.Controls.Count > 0)
            {
                //arma una lista de todos los  bt.presente 
                List<bool> presentes = new List<bool>();

                //arma una lista de los ids de todos los participantes
                List<int> participantes = new List<int>();
                for (int i = 0; i < panelbtAsistencias.Controls.Count; i++)
                {
                    // por cada boton asistente agrega su bt.id y bt.presente a las listas correspondientes
                    Control control = panelbtAsistencias.Controls[i];
                    if (control is btAsistencia)
                    {
                        btAsistencia bt = control as btAsistencia;
                        presentes.Add(bt.Presente);
                        participantes.Add(bt.participanteID);
                    }


                }

                // si hay participantes
                if (participantes.Count > 0)
                {
                    for (int i = 0; i < participantes.Count; i++)
                    {
                        // si se le marca presente si todavia no estaba en la lista de presentes de la bdd
                        if (presentes[i] == true && pReunion.compararConTablaMedia(participantes[i], reunionID) == false)
                        {
                            pReunion.SaveReuniones_Asistentes(reunionID, participantes[i]);

                        }

                        // si se le puso ausente y en la bdd estaba como presente 
                        else if (presentes[i] == false && pReunion.compararConTablaMedia(participantes[i], reunionID) == true)
                        {
                            pReunion.DeleteReuniones_Asistentes(reunionID, participantes[i]);

                        }
                    }

                    MessageBox.Show("las asistencias han sido cargadas correctamente");
                }
                // si no hubieron cambios en la bdd
                else
                {
                    MessageBox.Show("No ha realizado ningún cambio a la lista");
                }
            }
            else if (reunionID != -1 && panelbtAsistencias.Controls.Count == 0)
            {
                MessageBox.Show("No hay ningun participante inscripto al evento!");
            }
            else
            {
                MessageBox.Show("la reunion no ha sido seleccionada correctamente vuelva a intentarlo");
            }



        }
        //-------------------------------------------------------------------------------------------------------------------------
        // cerrar formulario
        private void btCerrar_Click(object sender, EventArgs e)
        {
            participanteID = -1;
            reunionID = -1;
            eventoID = -1;
            
            Close();

        }
    }
}