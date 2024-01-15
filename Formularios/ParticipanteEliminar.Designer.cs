namespace Tp_4.Formularios
{
    partial class ParticipanteEliminar
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
            cbEliminarParticipante = new ComboBox();
            participanteBindingSource = new BindingSource(components);
            lapA = new Label();
            btAceptar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbEliminarParticipante
            // 
            cbEliminarParticipante.DataSource = participanteBindingSource;
            cbEliminarParticipante.DisplayMember = "nombre";
            cbEliminarParticipante.FormattingEnabled = true;
            cbEliminarParticipante.Location = new Point(34, 107);
            cbEliminarParticipante.Name = "cbEliminarParticipante";
            cbEliminarParticipante.Size = new Size(247, 23);
            cbEliminarParticipante.TabIndex = 18;
            cbEliminarParticipante.ValueMember = "Id";
            cbEliminarParticipante.SelectedIndexChanged += cbEventoEliminar_SelectedIndexChanged;
            cbEliminarParticipante.Click += cbEventoEliminar_Click;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // lapA
            // 
            lapA.AutoSize = true;
            lapA.ForeColor = Color.White;
            lapA.Location = new Point(34, 89);
            lapA.Name = "lapA";
            lapA.Size = new Size(146, 15);
            lapA.TabIndex = 19;
            lapA.Text = "Seleccione un participante";
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.FromArgb(54, 195, 103);
            btAceptar.FlatAppearance.BorderSize = 0;
            btAceptar.FlatStyle = FlatStyle.Flat;
            btAceptar.ForeColor = Color.White;
            btAceptar.Location = new Point(187, 334);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(132, 23);
            btAceptar.TabIndex = 20;
            btAceptar.Text = "Cancelar";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btCancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 195, 103);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(25, 334);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 21;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btAceptar_Click;
            // 
            // ParticipanteEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(338, 380);
            Controls.Add(button1);
            Controls.Add(btAceptar);
            Controls.Add(lapA);
            Controls.Add(cbEliminarParticipante);
            Name = "ParticipanteEliminar";
            Text = "ParticipanteEliminar";
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEliminarParticipante;
        private Label lapA;
        private Button btAceptar;
        private Button button1;
        private BindingSource participanteBindingSource;
    }
}