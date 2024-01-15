namespace Tp_4.Formularios
{
    partial class ReunionDelEvento
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
            btAgregar = new Button();
            reunionBindingSource = new BindingSource(components);
            btCancelarEvento = new Button();
            cbExpositor = new ComboBox();
            participanteBindingSource = new BindingSource(components);
            tbHoraReunion = new TextBox();
            tbLugarReuinion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            SuspendLayout();
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
            btAgregar.TabIndex = 38;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = false;
            btAgregar.Click += btAgregar_Click;
            // 
            // reunionBindingSource
            // 
            reunionBindingSource.DataSource = typeof(Entidades.Reunion);
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
            btCancelarEvento.TabIndex = 35;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelar_Click;
            // 
            // cbExpositor
            // 
            cbExpositor.DataSource = participanteBindingSource;
            cbExpositor.DisplayMember = "nombre";
            cbExpositor.FormattingEnabled = true;
            cbExpositor.Location = new Point(86, 164);
            cbExpositor.Name = "cbExpositor";
            cbExpositor.Size = new Size(247, 23);
            cbExpositor.TabIndex = 33;
            cbExpositor.ValueMember = "Id";
            cbExpositor.SelectedIndexChanged += cbExpositor_SelectedIndexChanged;
            cbExpositor.Click += cbExpositor_Click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // tbHoraReunion
            // 
            tbHoraReunion.Location = new Point(86, 111);
            tbHoraReunion.Name = "tbHoraReunion";
            tbHoraReunion.Size = new Size(247, 23);
            tbHoraReunion.TabIndex = 32;
            // 
            // tbLugarReuinion
            // 
            tbLugarReuinion.Location = new Point(86, 63);
            tbLugarReuinion.Name = "tbLugarReuinion";
            tbLugarReuinion.Size = new Size(247, 23);
            tbLugarReuinion.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(86, 146);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 30;
            label3.Text = "Expositor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(86, 93);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 29;
            label2.Text = "Hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 45);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 28;
            label1.Text = "Lugar";
            // 
            // ReunionDelEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(472, 345);
            Controls.Add(btAgregar);
            Controls.Add(btCancelarEvento);
            Controls.Add(cbExpositor);
            Controls.Add(tbHoraReunion);
            Controls.Add(tbLugarReuinion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReunionDelEvento";
            Text = "ReunionDelEvento";
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAgregar;
        private DataGridViewTextBoxColumn TipoParticipanteNombre;
        private Button btCancelarEvento;
        private ComboBox cbExpositor;
        private TextBox tbHoraReunion;
        private TextBox tbLugarReuinion;
        private Label label3;
        private Label label2;
        private Label label1;
        private BindingSource reunionBindingSource;
        private BindingSource participanteBindingSource;
    }
}