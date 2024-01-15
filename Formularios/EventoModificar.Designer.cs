namespace Tp_4.Formularios
{
    partial class EventoModificar
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
            tbCantidadHorasEvento = new TextBox();
            tbNombreEvento = new TextBox();
            tbFechaEvento = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btCancelarEvento = new Button();
            btAceptarEvento = new Button();
            cbEventoModificar = new ComboBox();
            eventoBindingSource = new BindingSource(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tbCantidadHorasEvento
            // 
            tbCantidadHorasEvento.Location = new Point(61, 156);
            tbCantidadHorasEvento.Name = "tbCantidadHorasEvento";
            tbCantidadHorasEvento.Size = new Size(267, 23);
            tbCantidadHorasEvento.TabIndex = 21;
            // 
            // tbNombreEvento
            // 
            tbNombreEvento.Location = new Point(61, 102);
            tbNombreEvento.Name = "tbNombreEvento";
            tbNombreEvento.Size = new Size(267, 23);
            tbNombreEvento.TabIndex = 20;
            // 
            // tbFechaEvento
            // 
            tbFechaEvento.Location = new Point(61, 210);
            tbFechaEvento.Name = "tbFechaEvento";
            tbFechaEvento.PlaceholderText = "Ingrese la fecha en formato dd/mm/yyyy";
            tbFechaEvento.Size = new Size(267, 23);
            tbFechaEvento.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(61, 192);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 18;
            label3.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(61, 138);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 17;
            label2.Text = "Cantidad de Horas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(61, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre";
            // 
            // btCancelarEvento
            // 
            btCancelarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btCancelarEvento.FlatAppearance.BorderSize = 0;
            btCancelarEvento.FlatStyle = FlatStyle.Flat;
            btCancelarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCancelarEvento.ForeColor = Color.White;
            btCancelarEvento.Location = new Point(214, 249);
            btCancelarEvento.Name = "btCancelarEvento";
            btCancelarEvento.Size = new Size(196, 35);
            btCancelarEvento.TabIndex = 15;
            btCancelarEvento.Text = "Cancelar";
            btCancelarEvento.UseVisualStyleBackColor = false;
            btCancelarEvento.Click += btCancelarEvento_Click;
            // 
            // btAceptarEvento
            // 
            btAceptarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btAceptarEvento.FlatAppearance.BorderSize = 0;
            btAceptarEvento.FlatStyle = FlatStyle.Flat;
            btAceptarEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAceptarEvento.ForeColor = Color.White;
            btAceptarEvento.Location = new Point(12, 249);
            btAceptarEvento.Name = "btAceptarEvento";
            btAceptarEvento.Size = new Size(196, 35);
            btAceptarEvento.TabIndex = 14;
            btAceptarEvento.Text = "Aceptar";
            btAceptarEvento.UseVisualStyleBackColor = false;
            btAceptarEvento.Click += btAceptarEvento_Click;
            // 
            // cbEventoModificar
            // 
            cbEventoModificar.DataSource = eventoBindingSource;
            cbEventoModificar.DisplayMember = "nombre";
            cbEventoModificar.FormattingEnabled = true;
            cbEventoModificar.Location = new Point(61, 45);
            cbEventoModificar.Name = "cbEventoModificar";
            cbEventoModificar.Size = new Size(267, 23);
            cbEventoModificar.TabIndex = 23;
            cbEventoModificar.ValueMember = "Id";
            cbEventoModificar.SelectedIndexChanged += cbEventoModificar_SelectedIndexCanged;
            cbEventoModificar.Click += cbEventoModificar_Click;
            // 
            // eventoBindingSource
            // 
            eventoBindingSource.DataSource = typeof(Entidades.Evento);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(61, 27);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 22;
            label5.Text = "Evento";
            // 
            // EventoModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(472, 345);
            Controls.Add(cbEventoModificar);
            Controls.Add(label5);
            Controls.Add(tbCantidadHorasEvento);
            Controls.Add(tbNombreEvento);
            Controls.Add(tbFechaEvento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btCancelarEvento);
            Controls.Add(btAceptarEvento);
            Location = new Point(400, 310);
            Name = "EventoModificar";
            Text = "EventoModificar";
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbCantidadHorasEvento;
        private TextBox tbNombreEvento;
        private TextBox tbFechaEvento;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btCancelarEvento;
        private Button btAceptarEvento;
        private ComboBox cbEventoModificar;
        private Label label5;
        private BindingSource eventoBindingSource;
    }
}