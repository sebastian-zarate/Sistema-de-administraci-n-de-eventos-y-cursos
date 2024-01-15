namespace Tp_4.Formularios
{
    partial class ParticipantesEdicion
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNombreParticipante = new TextBox();
            tbApellidoParticipante = new TextBox();
            cbTipoParticipante = new ComboBox();
            tipoParticipanteBindingSource = new BindingSource(components);
            btAceptarEvento = new Button();
            btCancelarEvento = new Button();
            participanteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(36, 52);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(36, 142);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 233);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de participante";
            // 
            // tbNombreParticipante
            // 
            tbNombreParticipante.Location = new Point(36, 70);
            tbNombreParticipante.Name = "tbNombreParticipante";
            tbNombreParticipante.Size = new Size(247, 23);
            tbNombreParticipante.TabIndex = 9;
            // 
            // tbApellidoParticipante
            // 
            tbApellidoParticipante.Location = new Point(36, 160);
            tbApellidoParticipante.Name = "tbApellidoParticipante";
            tbApellidoParticipante.Size = new Size(247, 23);
            tbApellidoParticipante.TabIndex = 10;
            // 
            // cbTipoParticipante
            // 
            cbTipoParticipante.DataSource = tipoParticipanteBindingSource;
            cbTipoParticipante.DisplayMember = "nombre";
            cbTipoParticipante.FormattingEnabled = true;
            cbTipoParticipante.Location = new Point(36, 251);
            cbTipoParticipante.Name = "cbTipoParticipante";
            cbTipoParticipante.Size = new Size(247, 23);
            cbTipoParticipante.TabIndex = 14;
            cbTipoParticipante.ValueMember = "Id";
            cbTipoParticipante.SelectedIndexChanged += cbTipoParticipante_SelectedIndexChanged;
            cbTipoParticipante.Click += cbTipoParticipante_Click;
            // 
            // tipoParticipanteBindingSource
            // 
            tipoParticipanteBindingSource.DataSource = typeof(Entidades.TipoParticipante);
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
            btAceptarEvento.TabIndex = 15;
            btAceptarEvento.Text = "Aceptar";
            btAceptarEvento.UseVisualStyleBackColor = false;
            btAceptarEvento.Click += cbtAceptarParticipante_Click;
            // 
            // btCancelarEvento
            // 
            btCancelarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btCancelarEvento.FlatAppearance.BorderSize = 0;
            btCancelarEvento.FlatStyle = FlatStyle.Flat;
            btCancelarEvento.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelarEvento.ForeColor = Color.White;
            btCancelarEvento.Location = new Point(187, 334);
            btCancelarEvento.Name = "btCancelarEvento";
            btCancelarEvento.Size = new Size(132, 23);
            btCancelarEvento.TabIndex = 16;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelarEvento_Click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // ParticipantesEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(338, 380);
            Controls.Add(btCancelarEvento);
            Controls.Add(btAceptarEvento);
            Controls.Add(cbTipoParticipante);
            Controls.Add(tbApellidoParticipante);
            Controls.Add(tbNombreParticipante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(39, 39, 65);
            Name = "ParticipantesEdicion";
            Text = "ParticipantesEdicion";
            ((System.ComponentModel.ISupportInitialize)tipoParticipanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombreParticipante;
        private TextBox tbApellidoParticipante;
        private ComboBox cbTipoParticipante;
        private Button btAceptarEvento;
        private Button btCancelarEvento;
        private BindingSource tipoParticipanteBindingSource;
        private BindingSource participanteBindingSource;
    }
}