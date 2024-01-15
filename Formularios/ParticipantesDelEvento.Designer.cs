namespace Tp_4.Formularios
{
    partial class ParticipantesDelEvento
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
            eventoBindingSource = new BindingSource(components);
            participanteBindingSource = new BindingSource(components);
            btCancelarEvento = new Button();
            cbTipoParticipante = new ComboBox();
            tipoParticipanteBindingSource = new BindingSource(components);
            tbApellidoParticipante = new TextBox();
            tbNombreParticipante = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // eventoBindingSource
            // 
            eventoBindingSource.DataSource = typeof(Entidades.Evento);
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // btCancelarEvento
            // 
            btCancelarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btCancelarEvento.FlatAppearance.BorderSize = 0;
            btCancelarEvento.FlatStyle = FlatStyle.Flat;
            btCancelarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelarEvento.ForeColor = Color.White;
            btCancelarEvento.Location = new Point(227, 220);
            btCancelarEvento.Name = "btCancelarEvento";
            btCancelarEvento.Size = new Size(196, 35);
            btCancelarEvento.TabIndex = 24;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelar_Click;
            // 
            // cbTipoParticipante
            // 
            cbTipoParticipante.DataSource = tipoParticipanteBindingSource;
            cbTipoParticipante.DisplayMember = "nombre";
            cbTipoParticipante.FormattingEnabled = true;
            cbTipoParticipante.Location = new Point(86, 160);
            cbTipoParticipante.Name = "cbTipoParticipante";
            cbTipoParticipante.Size = new Size(247, 23);
            cbTipoParticipante.TabIndex = 22;
            cbTipoParticipante.ValueMember = "Id";
            cbTipoParticipante.SelectedIndexChanged += cbTipoParticipante_SelectedIndexChanged;
            cbTipoParticipante.Click += cbTipoParticipante_Click;
            // 
            // tipoParticipanteBindingSource
            // 
            tipoParticipanteBindingSource.DataSource = typeof(Entidades.TipoParticipante);
            // 
            // tbApellidoParticipante
            // 
            tbApellidoParticipante.Location = new Point(86, 107);
            tbApellidoParticipante.Name = "tbApellidoParticipante";
            tbApellidoParticipante.Size = new Size(247, 23);
            tbApellidoParticipante.TabIndex = 21;
            // 
            // tbNombreParticipante
            // 
            tbNombreParticipante.Location = new Point(86, 63);
            tbNombreParticipante.Name = "tbNombreParticipante";
            tbNombreParticipante.Size = new Size(247, 23);
            tbNombreParticipante.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(86, 142);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 19;
            label3.Text = "Tipo de participante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 45);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 17;
            label1.Text = "Nombre ";
            // 
            // btAgregar
            // 
            btAgregar.BackColor = Color.FromArgb(54, 195, 103);
            btAgregar.FlatAppearance.BorderSize = 0;
            btAgregar.FlatStyle = FlatStyle.Flat;
            btAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAgregar.ForeColor = Color.White;
            btAgregar.Location = new Point(25, 220);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(196, 35);
            btAgregar.TabIndex = 27;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // ParticipantesDelEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(472, 345);
            Controls.Add(btAgregar);
            Controls.Add(btCancelarEvento);
            Controls.Add(cbTipoParticipante);
            Controls.Add(tbApellidoParticipante);
            Controls.Add(tbNombreParticipante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ParticipantesDelEvento";
            Text = "ParticipantesDelEvento";
            Load += ParticipantesDelEvento_Load;
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource eventoBindingSource;
        private BindingSource participanteBindingSource;
        private Button btCancelarEvento;
        private ComboBox cbTipoParticipante;
        private TextBox tbApellidoParticipante;
        private TextBox tbNombreParticipante;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btAgregar;
        private BindingSource tipoParticipanteBindingSource;
    }
}