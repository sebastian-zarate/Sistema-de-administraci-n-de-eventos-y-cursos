namespace Tp_4.Formularios
{
    partial class ParticipanteModificar
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
            label5 = new Label();
            cbParticipanteModificar = new ComboBox();
            participanteBindingSource = new BindingSource(components);
            label1 = new Label();
            tbNombreParticipante = new TextBox();
            label2 = new Label();
            tbApellidoParticipante = new TextBox();
            label3 = new Label();
            btAceptarEvento = new Button();
            btCancelarEvento = new Button();
            cbTipoParticipante = new ComboBox();
            tipoParticipanteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(33, 35);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 17;
            label5.Text = "Participante";
            // 
            // cbParticipanteModificar
            // 
            cbParticipanteModificar.DataSource = participanteBindingSource;
            cbParticipanteModificar.DisplayMember = "nombre";
            cbParticipanteModificar.FormattingEnabled = true;
            cbParticipanteModificar.Location = new Point(33, 53);
            cbParticipanteModificar.Name = "cbParticipanteModificar";
            cbParticipanteModificar.Size = new Size(267, 23);
            cbParticipanteModificar.TabIndex = 24;
            cbParticipanteModificar.ValueMember = "Id";
            cbParticipanteModificar.SelectedIndexChanged += cbModificar_SelectedIndexCanged;
            cbParticipanteModificar.Click += cbParticipanteModificar_Click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(33, 103);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 25;
            label1.Text = "Nombre";
            // 
            // tbNombreParticipante
            // 
            tbNombreParticipante.Location = new Point(33, 121);
            tbNombreParticipante.Name = "tbNombreParticipante";
            tbNombreParticipante.Size = new Size(267, 23);
            tbNombreParticipante.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(33, 175);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 28;
            label2.Text = "Apellido";
            // 
            // tbApellidoParticipante
            // 
            tbApellidoParticipante.Location = new Point(33, 193);
            tbApellidoParticipante.Name = "tbApellidoParticipante";
            tbApellidoParticipante.Size = new Size(267, 23);
            tbApellidoParticipante.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(33, 247);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 31;
            label3.Text = "Tipo participante";
            // 
            // btAceptarEvento
            // 
            btAceptarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btAceptarEvento.FlatAppearance.BorderSize = 0;
            btAceptarEvento.FlatStyle = FlatStyle.Flat;
            btAceptarEvento.ForeColor = Color.White;
            btAceptarEvento.Location = new Point(25, 334);
            btAceptarEvento.Name = "btAceptarEvento";
            btAceptarEvento.Size = new Size(132, 23);
            btAceptarEvento.TabIndex = 32;
            btAceptarEvento.Text = "Aceptar";
            btAceptarEvento.UseVisualStyleBackColor = false;
            btAceptarEvento.Click += btAceptarParticipante_Click;
            // 
            // btCancelarEvento
            // 
            btCancelarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btCancelarEvento.FlatAppearance.BorderSize = 0;
            btCancelarEvento.FlatStyle = FlatStyle.Flat;
            btCancelarEvento.ForeColor = Color.White;
            btCancelarEvento.Location = new Point(168, 334);
            btCancelarEvento.Name = "btCancelarEvento";
            btCancelarEvento.Size = new Size(132, 23);
            btCancelarEvento.TabIndex = 33;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelarEvento_Click;
            // 
            // cbTipoParticipante
            // 
            cbTipoParticipante.DataSource = tipoParticipanteBindingSource;
            cbTipoParticipante.DisplayMember = "nombre";
            cbTipoParticipante.FormattingEnabled = true;
            cbTipoParticipante.Location = new Point(33, 265);
            cbTipoParticipante.Name = "cbTipoParticipante";
            cbTipoParticipante.Size = new Size(267, 23);
            cbTipoParticipante.TabIndex = 34;
            cbTipoParticipante.ValueMember = "Id";
            cbTipoParticipante.SelectedIndexChanged += cbTipoParticipante_SelectedIndexChanged;
            cbTipoParticipante.Click += cbTipoParticipante_Clicck;
            // 
            // tipoParticipanteBindingSource
            // 
            tipoParticipanteBindingSource.DataSource = typeof(Entidades.TipoParticipante);
            // 
            // ParticipanteModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(338, 380);
            Controls.Add(cbTipoParticipante);
            Controls.Add(btCancelarEvento);
            Controls.Add(btAceptarEvento);
            Controls.Add(label3);
            Controls.Add(tbApellidoParticipante);
            Controls.Add(label2);
            Controls.Add(tbNombreParticipante);
            Controls.Add(label1);
            Controls.Add(cbParticipanteModificar);
            Controls.Add(label5);
            Name = "ParticipanteModificar";
            Text = "ParticipanteModificar";
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox cbParticipanteModificar;
        private Label label1;
        private TextBox tbNombreParticipante;
        private Label label2;
        private TextBox tbApellidoParticipante;
        private Label label3;
        private Button btAceptarEvento;
        private Button btCancelarEvento;
        private ComboBox cbTipoParticipante;
        private BindingSource participanteBindingSource;
        private BindingSource tipoParticipanteBindingSource;
    }
}