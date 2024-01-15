namespace Tp_4.Formularios
{
    partial class Certificado
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            labelEvento = new Label();
            labelFecha = new Label();
            labelParticipante = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(522, 97);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelEvento);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(labelParticipante);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 6;
            // 
            // labelEvento
            // 
            labelEvento.AutoSize = true;
            labelEvento.BackColor = Color.Transparent;
            labelEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEvento.ForeColor = Color.FromArgb(66, 109, 62);
            labelEvento.Image = Properties.Resources.fondo_label;
            labelEvento.Location = new Point(329, 310);
            labelEvento.Name = "labelEvento";
            labelEvento.Size = new Size(45, 17);
            labelEvento.TabIndex = 3;
            labelEvento.Text = "label4";
            labelEvento.Click += labelEvento_Click;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = Color.Transparent;
            labelFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.ForeColor = Color.FromArgb(179, 150, 57);
            labelFecha.Image = Properties.Resources.fondo_label;
            labelFecha.Location = new Point(189, 361);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(57, 21);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "label3";
            // 
            // labelParticipante
            // 
            labelParticipante.BackColor = Color.White;
            labelParticipante.Font = new Font("Freestyle Script", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelParticipante.Image = Properties.Resources.fondo_label;
            labelParticipante.Location = new Point(154, 211);
            labelParticipante.Name = "labelParticipante";
            labelParticipante.Size = new Size(488, 58);
            labelParticipante.TabIndex = 1;
            labelParticipante.Text = "label2";
            labelParticipante.TextAlign = ContentAlignment.MiddleCenter;
            labelParticipante.Click += labelParticipante_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Certificado_original_no_fake1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Certificado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "Certificado";
            Text = "Certificado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelEvento;
        private Label labelFecha;
        private Label labelParticipante;
    }
}