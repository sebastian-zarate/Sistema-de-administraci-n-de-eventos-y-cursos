namespace Tp_4.Formularios
{
    partial class ReunionAgregar
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
            lbLugar = new Label();
            tbLugar = new TextBox();
            lbHora = new Label();
            tbHorario = new TextBox();
            cbPartiExp = new ComboBox();
            participanteBindingSource = new BindingSource(components);
            lbIdParticipanteExp = new Label();
            btAgregarEvento = new Button();
            btCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbLugar
            // 
            lbLugar.AutoSize = true;
            lbLugar.ForeColor = Color.White;
            lbLugar.Location = new Point(34, 47);
            lbLugar.Name = "lbLugar";
            lbLugar.Size = new Size(37, 15);
            lbLugar.TabIndex = 0;
            lbLugar.Text = "Lugar";
            // 
            // tbLugar
            // 
            tbLugar.Location = new Point(34, 65);
            tbLugar.Name = "tbLugar";
            tbLugar.Size = new Size(268, 23);
            tbLugar.TabIndex = 1;
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.ForeColor = Color.White;
            lbHora.Location = new Point(34, 125);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(47, 15);
            lbHora.TabIndex = 2;
            lbHora.Text = "Horario";
            // 
            // tbHorario
            // 
            tbHorario.Location = new Point(34, 143);
            tbHorario.Name = "tbHorario";
            tbHorario.Size = new Size(268, 23);
            tbHorario.TabIndex = 3;
            // 
            // cbPartiExp
            // 
            cbPartiExp.DataSource = participanteBindingSource;
            cbPartiExp.DisplayMember = "nombre";
            cbPartiExp.FormattingEnabled = true;
            cbPartiExp.Location = new Point(34, 207);
            cbPartiExp.Name = "cbPartiExp";
            cbPartiExp.Size = new Size(268, 23);
            cbPartiExp.TabIndex = 4;
            cbPartiExp.ValueMember = "Id";
            cbPartiExp.Click += cbParticipante_click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // lbIdParticipanteExp
            // 
            lbIdParticipanteExp.AutoSize = true;
            lbIdParticipanteExp.ForeColor = Color.White;
            lbIdParticipanteExp.Location = new Point(34, 189);
            lbIdParticipanteExp.Name = "lbIdParticipanteExp";
            lbIdParticipanteExp.Size = new Size(56, 15);
            lbIdParticipanteExp.TabIndex = 5;
            lbIdParticipanteExp.Text = "Expositor";
            // 
            // btAgregarEvento
            // 
            btAgregarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btAgregarEvento.FlatAppearance.BorderSize = 0;
            btAgregarEvento.FlatStyle = FlatStyle.Flat;
            btAgregarEvento.ForeColor = Color.White;
            btAgregarEvento.Location = new Point(34, 280);
            btAgregarEvento.Name = "btAgregarEvento";
            btAgregarEvento.Size = new Size(132, 23);
            btAgregarEvento.TabIndex = 8;
            btAgregarEvento.Text = "Aceptar";
            btAgregarEvento.UseVisualStyleBackColor = false;
            btAgregarEvento.Click += btAceptarReunion_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(54, 195, 103);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.ForeColor = Color.White;
            btCancelar.Location = new Point(170, 280);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(132, 23);
            btCancelar.TabIndex = 9;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // ReunionAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(330, 355);
            Controls.Add(btCancelar);
            Controls.Add(btAgregarEvento);
            Controls.Add(lbIdParticipanteExp);
            Controls.Add(cbPartiExp);
            Controls.Add(tbHorario);
            Controls.Add(lbHora);
            Controls.Add(tbLugar);
            Controls.Add(lbLugar);
            Name = "ReunionAgregar";
            Text = "ReunionAgregar";
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLugar;
        private TextBox tbLugar;
        private Label lbHora;
        private TextBox tbHorario;
        private ComboBox cbPartiExp;
        private Label lbIdParticipanteExp;
        private BindingSource participanteBindingSource;
        private Button btAgregarEvento;
        private Button btCancelar;
    }
}