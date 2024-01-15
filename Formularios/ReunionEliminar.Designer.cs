namespace Tp_4.Formularios
{
    partial class ReunionEliminar
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
            cbReunionEliminar = new ComboBox();
            reunionBindingSource = new BindingSource(components);
            label4 = new Label();
            btAgregarEvento = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbReunionEliminar
            // 
            cbReunionEliminar.DataSource = reunionBindingSource;
            cbReunionEliminar.DisplayMember = "lugar";
            cbReunionEliminar.FormattingEnabled = true;
            cbReunionEliminar.Location = new Point(32, 72);
            cbReunionEliminar.Name = "cbReunionEliminar";
            cbReunionEliminar.Size = new Size(270, 23);
            cbReunionEliminar.TabIndex = 11;
            cbReunionEliminar.ValueMember = "id";
            cbReunionEliminar.SelectedIndexChanged += cbReunionEliminar_SelectedIndexChanged;
            cbReunionEliminar.Click += cbReunionEliminar_Click;
            // 
            // reunionBindingSource
            // 
            reunionBindingSource.DataSource = typeof(Entidades.Reunion);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 54);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Reunion";
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
            btAgregarEvento.TabIndex = 14;
            btAgregarEvento.Text = "Aceptar";
            btAgregarEvento.UseVisualStyleBackColor = false;
            btAgregarEvento.Click += btAceptarReunion_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 195, 103);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(170, 280);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btCancelarReunion_Click;
            // 
            // EliminarReunion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 65);
            ClientSize = new Size(330, 355);
            Controls.Add(button1);
            Controls.Add(btAgregarEvento);
            Controls.Add(cbReunionEliminar);
            Controls.Add(label4);
            Name = "EliminarReunion";
            Text = "EliminarReunion";
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbReunionEliminar;
        private Label label4;
        private BindingSource reunionBindingSource;
        private Button btAgregarEvento;
        private Button button1;
    }
}