namespace Tp_4.Formularios
{
    partial class ReunionModificar
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
            tbLugar = new TextBox();
            label2 = new Label();
            tbHorario = new TextBox();
            participanteBindingSource = new BindingSource(components);
            label4 = new Label();
            cbReunionModificar = new ComboBox();
            reunionBindingSource = new BindingSource(components);
            btCancelar = new Button();
            btAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(34, 125);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Lugar";
            // 
            // tbLugar
            // 
            tbLugar.Location = new Point(34, 143);
            tbLugar.Name = "tbLugar";
            tbLugar.Size = new Size(268, 23);
            tbLugar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 189);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Horario";
            // 
            // tbHorario
            // 
            tbHorario.Location = new Point(34, 207);
            tbHorario.Name = "tbHorario";
            tbHorario.Size = new Size(268, 23);
            tbHorario.TabIndex = 3;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 47);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 8;
            label4.Text = "Reunion";
            // 
            // cbReunionModificar
            // 
            cbReunionModificar.DataSource = reunionBindingSource;
            cbReunionModificar.DisplayMember = "lugar";
            cbReunionModificar.FormattingEnabled = true;
            cbReunionModificar.Location = new Point(34, 65);
            cbReunionModificar.Name = "cbReunionModificar";
            cbReunionModificar.Size = new Size(268, 23);
            cbReunionModificar.TabIndex = 9;
            cbReunionModificar.ValueMember = "id";
            cbReunionModificar.SelectedIndexChanged += cbReunionModificar_SelectedIndexChanged;
            cbReunionModificar.Click += cbReunionModificar_Click;
            // 
            // reunionBindingSource
            // 
            reunionBindingSource.DataSource = typeof(Entidades.Reunion);
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
            btCancelar.TabIndex = 10;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCANCELAR_Click;
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.FromArgb(54, 195, 103);
            btAceptar.FlatAppearance.BorderSize = 0;
            btAceptar.FlatStyle = FlatStyle.Flat;
            btAceptar.ForeColor = Color.White;
            btAceptar.Location = new Point(32, 280);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(132, 23);
            btAceptar.TabIndex = 11;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // ReunionModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(330, 355);
            Controls.Add(btAceptar);
            Controls.Add(btCancelar);
            Controls.Add(cbReunionModificar);
            Controls.Add(label4);
            Controls.Add(tbHorario);
            Controls.Add(label2);
            Controls.Add(tbLugar);
            Controls.Add(label1);
            Name = "ReunionModificar";
            Text = "ReunionModificar";

            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbLugar;
        private Label label2;
        private TextBox tbHorario;
        private BindingSource participanteBindingSource;
        private Label label4;
        private ComboBox cbReunionModificar;
        private BindingSource reunionBindingSource;
        private Button btCancelar;
        private Button btAceptar;
    }
}