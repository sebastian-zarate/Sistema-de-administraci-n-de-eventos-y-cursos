namespace Tp_4.Formularios
{
    partial class EventoEdicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btAceptarEvento = new Button();
            btCancelarEvento = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbFechaEvento = new TextBox();
            tbNombreEvento = new TextBox();
            tbCantidadHorasEvento = new TextBox();
            tbLugarEvento = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbTipoEvento = new ComboBox();
            tipoEventoBindingSource = new BindingSource(components);
            eventoBindingSource = new BindingSource(components);
            btAgregarParticipante = new Button();
            participanteBindingSource = new BindingSource(components);
            reunionBindingSource = new BindingSource(components);
            btAgregarReunion = new Button();
            ((System.ComponentModel.ISupportInitialize)tipoEventoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btAceptarEvento
            // 
            btAceptarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btAceptarEvento.FlatAppearance.BorderSize = 0;
            btAceptarEvento.FlatStyle = FlatStyle.Flat;
            btAceptarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAceptarEvento.ForeColor = Color.White;
            btAceptarEvento.Location = new Point(76, 305);
            btAceptarEvento.Name = "btAceptarEvento";
            btAceptarEvento.Size = new Size(196, 35);
            btAceptarEvento.TabIndex = 0;
            btAceptarEvento.Text = "Aceptar";
            btAceptarEvento.UseVisualStyleBackColor = false;
            btAceptarEvento.Click += cbtAceptarEvento_Click;
            // 
            // btCancelarEvento
            // 
            btCancelarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btCancelarEvento.FlatAppearance.BorderSize = 0;
            btCancelarEvento.FlatStyle = FlatStyle.Flat;
            btCancelarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelarEvento.ForeColor = Color.White;
            btCancelarEvento.Location = new Point(292, 305);
            btCancelarEvento.Name = "btCancelarEvento";
            btCancelarEvento.Size = new Size(196, 35);
            btCancelarEvento.TabIndex = 1;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelarEvento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 17);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 71);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 4;
            label2.Text = "Cantidad de Horas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 125);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha";
            // 
            // tbFechaEvento
            // 
            tbFechaEvento.Location = new Point(76, 143);
            tbFechaEvento.Name = "tbFechaEvento";
            tbFechaEvento.Size = new Size(266, 23);
            tbFechaEvento.TabIndex = 7;
            tbFechaEvento.Click += tbFechaEvento_Click;
            // 
            // tbNombreEvento
            // 
            tbNombreEvento.Location = new Point(76, 35);
            tbNombreEvento.Name = "tbNombreEvento";
            tbNombreEvento.Size = new Size(266, 23);
            tbNombreEvento.TabIndex = 8;
            // 
            // tbCantidadHorasEvento
            // 
            tbCantidadHorasEvento.Location = new Point(76, 89);
            tbCantidadHorasEvento.Name = "tbCantidadHorasEvento";
            tbCantidadHorasEvento.Size = new Size(266, 23);
            tbCantidadHorasEvento.TabIndex = 9;
            // 
            // tbLugarEvento
            // 
            tbLugarEvento.Location = new Point(76, 196);
            tbLugarEvento.Name = "tbLugarEvento";
            tbLugarEvento.Size = new Size(266, 23);
            tbLugarEvento.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 178);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 10;
            label4.Text = "Lugar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(76, 229);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 12;
            label5.Text = "Tipo de Evento";
            // 
            // cbTipoEvento
            // 
            cbTipoEvento.DataSource = tipoEventoBindingSource;
            cbTipoEvento.DisplayMember = "nombre";
            cbTipoEvento.FormattingEnabled = true;
            cbTipoEvento.Location = new Point(76, 247);
            cbTipoEvento.Name = "cbTipoEvento";
            cbTipoEvento.Size = new Size(266, 23);
            cbTipoEvento.TabIndex = 13;
            cbTipoEvento.ValueMember = "Id";
            cbTipoEvento.SelectedIndexChanged += cbTipoEvento_SelectedIndexChanged;
            cbTipoEvento.Click += cbTipoEvento_Click;
            // 
            // tipoEventoBindingSource
            // 
            tipoEventoBindingSource.DataSource = typeof(Entidades.TipoEvento);
            // 
            // eventoBindingSource
            // 
            eventoBindingSource.DataSource = typeof(Entidades.Evento);
            // 
            // btAgregarParticipante
            // 
            btAgregarParticipante.BackColor = Color.FromArgb(54, 195, 103);
            btAgregarParticipante.FlatAppearance.BorderSize = 0;
            btAgregarParticipante.FlatStyle = FlatStyle.Flat;
            btAgregarParticipante.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAgregarParticipante.ForeColor = Color.White;
            btAgregarParticipante.Location = new Point(365, 35);
            btAgregarParticipante.Name = "btAgregarParticipante";
            btAgregarParticipante.Size = new Size(123, 51);
            btAgregarParticipante.TabIndex = 14;
            btAgregarParticipante.Text = "Agregar Participante";
            btAgregarParticipante.UseVisualStyleBackColor = false;
            btAgregarParticipante.Click += btAgregarParticipante_Click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // reunionBindingSource
            // 
            reunionBindingSource.DataSource = typeof(Entidades.Reunion);
            // 
            // btAgregarReunion
            // 
            btAgregarReunion.BackColor = Color.FromArgb(54, 195, 103);
            btAgregarReunion.FlatAppearance.BorderSize = 0;
            btAgregarReunion.FlatStyle = FlatStyle.Flat;
            btAgregarReunion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAgregarReunion.ForeColor = Color.White;
            btAgregarReunion.Location = new Point(365, 105);
            btAgregarReunion.Name = "btAgregarReunion";
            btAgregarReunion.Size = new Size(123, 51);
            btAgregarReunion.TabIndex = 17;
            btAgregarReunion.Text = "Agregar Reunión";
            btAgregarReunion.UseVisualStyleBackColor = false;
            btAgregarReunion.Click += btAgregarReunion_Click;
            // 
            // EventoEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(538, 397);
            Controls.Add(btAgregarReunion);
            Controls.Add(btAgregarParticipante);
            Controls.Add(cbTipoEvento);
            Controls.Add(label5);
            Controls.Add(tbLugarEvento);
            Controls.Add(label4);
            Controls.Add(tbCantidadHorasEvento);
            Controls.Add(tbNombreEvento);
            Controls.Add(tbFechaEvento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCancelarEvento);
            Controls.Add(btAceptarEvento);
            Name = "EventoEdicion";
            Text = "EventoEdicion";
            Load += EventoEdicion_Load;
            ((System.ComponentModel.ISupportInitialize)tipoEventoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAceptarEvento;
        private Button btCancelarEvento;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbFechaEvento;
        private TextBox tbNombreEvento;
        private TextBox tbCantidadHorasEvento;
        private TextBox tbLugarEvento;
        private Label label4;
        private Label label5;
        private ComboBox cbTipoEvento;
        private BindingSource eventoBindingSource;
        private BindingSource tipoEventoBindingSource;
        private Button btAgregarParticipante;
        private BindingSource participanteBindingSource;
        private BindingSource reunionBindingSource;
        private Button btAgregarReunion;
    }
}