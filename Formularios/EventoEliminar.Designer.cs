namespace Tp_4.Formularios
{
    partial class EventoEliminar
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
            cbEventoEliminar = new ComboBox();
            eventoBindingSource = new BindingSource(components);
            label5 = new Label();
            btCancelar = new Button();
            btAceptar = new Button();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbEventoEliminar
            // 
            cbEventoEliminar.DataSource = eventoBindingSource;
            cbEventoEliminar.DisplayMember = "nombre";
            cbEventoEliminar.FormattingEnabled = true;
            cbEventoEliminar.Location = new Point(61, 71);
            cbEventoEliminar.Name = "cbEventoEliminar";
            cbEventoEliminar.Size = new Size(309, 23);
            cbEventoEliminar.TabIndex = 17;
            cbEventoEliminar.ValueMember = "Id";
            cbEventoEliminar.SelectedIndexChanged += cbEventoEliminar_SelectedIndexChanged;
            cbEventoEliminar.Click += cbEventoEliminar_Click;
            // 
            // eventoBindingSource
            // 
            eventoBindingSource.DataSource = typeof(Entidades.Evento);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 53);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 16;
            label5.Text = "Evento";
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.FromArgb(54, 195, 103);
            btCancelar.FlatAppearance.BorderSize = 0;
            btCancelar.FlatStyle = FlatStyle.Flat;
            btCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelar.ForeColor = Color.White;
            btCancelar.Location = new Point(214, 155);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(196, 35);
            btCancelar.TabIndex = 15;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // btAceptar
            // 
            btAceptar.BackColor = Color.FromArgb(54, 195, 103);
            btAceptar.FlatAppearance.BorderSize = 0;
            btAceptar.FlatStyle = FlatStyle.Flat;
            btAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAceptar.ForeColor = Color.White;
            btAceptar.Location = new Point(12, 155);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(196, 35);
            btAceptar.TabIndex = 14;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = false;
            btAceptar.Click += btAceptar_Click;
            // 
            // EventoEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(472, 345);
            Controls.Add(cbEventoEliminar);
            Controls.Add(label5);
            Controls.Add(btCancelar);
            Controls.Add(btAceptar);
            Location = new Point(400, 310);
            Name = "EventoEliminar";
            Text = "EventoEliminar";
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEventoEliminar;
        private Label label5;
        private Button btCancelar;
        private Button btAceptar;
        private BindingSource eventoBindingSource;
    }
}