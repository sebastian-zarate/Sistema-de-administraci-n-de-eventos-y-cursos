namespace Tp_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btCerrar = new Button();
            btMenuCertificado = new Button();
            btAsistencias = new Button();
            btABM = new Button();
            panelABM = new Panel();
            tcABM = new TabControl();
            tpEvento = new TabPage();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cantidadHorasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lugarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eventoBindingSource = new BindingSource(components);
            btEliminarEvento = new Button();
            btModificarEvento = new Button();
            btAgregarEvento = new Button();
            tpReunion = new TabPage();
            btReunionElim = new Button();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lugarDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            horaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            expositorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reunionBindingSource = new BindingSource(components);
            btReunionMod = new Button();
            btReunionAgre = new Button();
            tpParticipante = new TabPage();
            btElimiarParticipante = new Button();
            dataGridView3 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoParticipanteNombre = new DataGridViewTextBoxColumn();
            participanteBindingSource = new BindingSource(components);
            btModificarParticipante = new Button();
            btAgregarParticipante = new Button();
            panelCertificado = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            bt_Certificado = new Button();
            cbEventoCertificado = new ComboBox();
            eventoBindingSource2 = new BindingSource(components);
            label2 = new Label();
            cbParticipanteCertificado = new ComboBox();
            participanteBindingSource1 = new BindingSource(components);
            eventoBindingSource1 = new BindingSource(components);
            panelSuperior = new Panel();
            panelAsistencias = new Panel();
            panelbtAsistencias = new Panel();
            panelOpcionesAsistencia = new Panel();
            btGuardarAsistencia = new Button();
            btTodosAusentes = new Button();
            btTodosPresentes = new Button();
            label3 = new Label();
            label4 = new Label();
            cbReunionesAsistencias = new ComboBox();
            cbEventoAsistencias = new ComboBox();
            panel3 = new Panel();
            labelPrincipal = new Label();
            panel1.SuspendLayout();
            panelABM.SuspendLayout();
            tcABM.SuspendLayout();
            tpEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).BeginInit();
            tpReunion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).BeginInit();
            tpParticipante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).BeginInit();
            panelCertificado.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource1).BeginInit();
            panelSuperior.SuspendLayout();
            panelAsistencias.SuspendLayout();
            panelOpcionesAsistencia.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 65);
            panel1.Controls.Add(btCerrar);
            panel1.Controls.Add(btMenuCertificado);
            panel1.Controls.Add(btAsistencias);
            panel1.Controls.Add(btABM);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 421);
            panel1.TabIndex = 0;
            // 
            // btCerrar
            // 
            btCerrar.FlatAppearance.BorderSize = 0;
            btCerrar.FlatStyle = FlatStyle.Flat;
            btCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCerrar.ForeColor = Color.White;
            btCerrar.Location = new Point(0, 343);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(154, 30);
            btCerrar.TabIndex = 3;
            btCerrar.Text = "Cerrar";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            btCerrar.MouseEnter += OnMouseEnterBoton;
            btCerrar.MouseLeave += OnMouseLeaveBoton;
            // 
            // btMenuCertificado
            // 
            btMenuCertificado.FlatAppearance.BorderSize = 0;
            btMenuCertificado.FlatStyle = FlatStyle.Flat;
            btMenuCertificado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btMenuCertificado.ForeColor = Color.White;
            btMenuCertificado.Location = new Point(0, 150);
            btMenuCertificado.Name = "btMenuCertificado";
            btMenuCertificado.Size = new Size(154, 30);
            btMenuCertificado.TabIndex = 2;
            btMenuCertificado.Text = "Certificado";
            btMenuCertificado.UseVisualStyleBackColor = true;
            btMenuCertificado.Click += btMenuCertificado_Click;
            btMenuCertificado.MouseEnter += OnMouseEnterBoton;
            btMenuCertificado.MouseLeave += OnMouseLeaveBoton;
            // 
            // btAsistencias
            // 
            btAsistencias.BackColor = Color.FromArgb(39, 39, 65);
            btAsistencias.FlatAppearance.BorderSize = 0;
            btAsistencias.FlatStyle = FlatStyle.Flat;
            btAsistencias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAsistencias.ForeColor = Color.White;
            btAsistencias.Location = new Point(0, 114);
            btAsistencias.Name = "btAsistencias";
            btAsistencias.Size = new Size(154, 30);
            btAsistencias.TabIndex = 1;
            btAsistencias.Text = "Asistencias";
            btAsistencias.UseVisualStyleBackColor = false;
            btAsistencias.Click += btAsistencias_Click;
            btAsistencias.MouseEnter += OnMouseEnterBoton;
            btAsistencias.MouseLeave += OnMouseLeaveBoton;
            // 
            // btABM
            // 
            btABM.BackColor = Color.FromArgb(39, 39, 65);
            btABM.FlatAppearance.BorderSize = 0;
            btABM.FlatStyle = FlatStyle.Flat;
            btABM.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btABM.ForeColor = Color.White;
            btABM.Location = new Point(0, 79);
            btABM.Name = "btABM";
            btABM.Size = new Size(154, 30);
            btABM.TabIndex = 0;
            btABM.Text = "Administración";
            btABM.UseVisualStyleBackColor = false;
            btABM.Click += btABM_Click;
            btABM.MouseEnter += OnMouseEnterBoton;
            btABM.MouseLeave += OnMouseLeaveBoton;
            // 
            // panelABM
            // 
            panelABM.BackColor = Color.White;
            panelABM.Controls.Add(tcABM);
            panelABM.Location = new Point(611, 18);
            panelABM.Name = "panelABM";
            panelABM.Size = new Size(167, 129);
            panelABM.TabIndex = 2;
            panelABM.Visible = false;
            // 
            // tcABM
            // 
            tcABM.Controls.Add(tpEvento);
            tcABM.Controls.Add(tpReunion);
            tcABM.Controls.Add(tpParticipante);
            tcABM.Location = new Point(5, 3);
            tcABM.Name = "tcABM";
            tcABM.SelectedIndex = 0;
            tcABM.Size = new Size(737, 421);
            tcABM.TabIndex = 1;
            // 
            // tpEvento
            // 
            tpEvento.Controls.Add(dataGridView1);
            tpEvento.Controls.Add(btEliminarEvento);
            tpEvento.Controls.Add(btModificarEvento);
            tpEvento.Controls.Add(btAgregarEvento);
            tpEvento.Location = new Point(4, 24);
            tpEvento.Name = "tpEvento";
            tpEvento.Padding = new Padding(3);
            tpEvento.Size = new Size(729, 393);
            tpEvento.TabIndex = 0;
            tpEvento.Text = "Evento";
            tpEvento.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, cantidadHorasDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, lugarDataGridViewTextBoxColumn });
            dataGridView1.DataSource = eventoBindingSource;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(729, 262);
            dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "TipoEventoNombre";
            dataGridViewTextBoxColumn1.HeaderText = "Tipo Evento";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // cantidadHorasDataGridViewTextBoxColumn
            // 
            cantidadHorasDataGridViewTextBoxColumn.DataPropertyName = "CantidadHoras";
            cantidadHorasDataGridViewTextBoxColumn.HeaderText = "CantidadHoras";
            cantidadHorasDataGridViewTextBoxColumn.MinimumWidth = 8;
            cantidadHorasDataGridViewTextBoxColumn.Name = "cantidadHorasDataGridViewTextBoxColumn";
            cantidadHorasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            lugarDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            lugarDataGridViewTextBoxColumn.MinimumWidth = 8;
            lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            lugarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventoBindingSource
            // 
            eventoBindingSource.DataSource = typeof(Entidades.Evento);
            // 
            // btEliminarEvento
            // 
            btEliminarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btEliminarEvento.FlatAppearance.BorderSize = 0;
            btEliminarEvento.FlatStyle = FlatStyle.Flat;
            btEliminarEvento.ForeColor = Color.White;
            btEliminarEvento.Location = new Point(464, 310);
            btEliminarEvento.Name = "btEliminarEvento";
            btEliminarEvento.Size = new Size(196, 35);
            btEliminarEvento.TabIndex = 3;
            btEliminarEvento.Text = "Eliminar";
            btEliminarEvento.UseVisualStyleBackColor = false;
            btEliminarEvento.Click += btEliminarEvento_Click;
            // 
            // btModificarEvento
            // 
            btModificarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btModificarEvento.FlatAppearance.BorderSize = 0;
            btModificarEvento.FlatStyle = FlatStyle.Flat;
            btModificarEvento.ForeColor = Color.White;
            btModificarEvento.Location = new Point(245, 310);
            btModificarEvento.Name = "btModificarEvento";
            btModificarEvento.Size = new Size(196, 35);
            btModificarEvento.TabIndex = 2;
            btModificarEvento.Text = "Modificar";
            btModificarEvento.UseVisualStyleBackColor = false;
            btModificarEvento.Click += btModificarEvento_Click;
            // 
            // btAgregarEvento
            // 
            btAgregarEvento.BackColor = Color.FromArgb(54, 195, 103);
            btAgregarEvento.FlatAppearance.BorderSize = 0;
            btAgregarEvento.FlatStyle = FlatStyle.Flat;
            btAgregarEvento.ForeColor = Color.White;
            btAgregarEvento.Location = new Point(33, 310);
            btAgregarEvento.Name = "btAgregarEvento";
            btAgregarEvento.Size = new Size(196, 35);
            btAgregarEvento.TabIndex = 1;
            btAgregarEvento.Text = "Agregar";
            btAgregarEvento.UseVisualStyleBackColor = false;
            btAgregarEvento.Click += btAgregarEvento_Click;
            // 
            // tpReunion
            // 
            tpReunion.Controls.Add(btReunionElim);
            tpReunion.Controls.Add(dataGridView2);
            tpReunion.Controls.Add(btReunionMod);
            tpReunion.Controls.Add(btReunionAgre);
            tpReunion.Location = new Point(4, 24);
            tpReunion.Name = "tpReunion";
            tpReunion.Padding = new Padding(3);
            tpReunion.Size = new Size(729, 393);
            tpReunion.TabIndex = 1;
            tpReunion.Text = "Reunion";
            tpReunion.UseVisualStyleBackColor = true;
            // 
            // btReunionElim
            // 
            btReunionElim.BackColor = Color.FromArgb(54, 195, 103);
            btReunionElim.FlatAppearance.BorderSize = 0;
            btReunionElim.FlatStyle = FlatStyle.Flat;
            btReunionElim.ForeColor = Color.White;
            btReunionElim.Location = new Point(464, 310);
            btReunionElim.Margin = new Padding(4, 5, 4, 5);
            btReunionElim.Name = "btReunionElim";
            btReunionElim.Size = new Size(196, 35);
            btReunionElim.TabIndex = 8;
            btReunionElim.Text = "Eliminar";
            btReunionElim.UseVisualStyleBackColor = false;
            btReunionElim.Click += btReunionElim_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, lugarDataGridViewTextBoxColumn1, horaDataGridViewTextBoxColumn, expositorDataGridViewTextBoxColumn });
            dataGridView2.DataSource = reunionBindingSource;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(720, 262);
            dataGridView2.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 8;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 50;
            // 
            // lugarDataGridViewTextBoxColumn1
            // 
            lugarDataGridViewTextBoxColumn1.DataPropertyName = "Lugar";
            lugarDataGridViewTextBoxColumn1.HeaderText = "Lugar";
            lugarDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lugarDataGridViewTextBoxColumn1.Name = "lugarDataGridViewTextBoxColumn1";
            lugarDataGridViewTextBoxColumn1.ReadOnly = true;
            lugarDataGridViewTextBoxColumn1.Width = 200;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            horaDataGridViewTextBoxColumn.MinimumWidth = 8;
            horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            horaDataGridViewTextBoxColumn.ReadOnly = true;
            horaDataGridViewTextBoxColumn.Width = 150;
            // 
            // expositorDataGridViewTextBoxColumn
            // 
            expositorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            expositorDataGridViewTextBoxColumn.DataPropertyName = "Expositor";
            expositorDataGridViewTextBoxColumn.HeaderText = "Expositor";
            expositorDataGridViewTextBoxColumn.MinimumWidth = 8;
            expositorDataGridViewTextBoxColumn.Name = "expositorDataGridViewTextBoxColumn";
            expositorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reunionBindingSource
            // 
            reunionBindingSource.DataSource = typeof(Entidades.Reunion);
            // 
            // btReunionMod
            // 
            btReunionMod.BackColor = Color.FromArgb(54, 195, 103);
            btReunionMod.FlatAppearance.BorderSize = 0;
            btReunionMod.FlatStyle = FlatStyle.Flat;
            btReunionMod.ForeColor = Color.White;
            btReunionMod.Location = new Point(245, 310);
            btReunionMod.Margin = new Padding(4, 5, 4, 5);
            btReunionMod.Name = "btReunionMod";
            btReunionMod.Size = new Size(196, 35);
            btReunionMod.TabIndex = 7;
            btReunionMod.Text = "Modificar";
            btReunionMod.UseVisualStyleBackColor = false;
            btReunionMod.Click += btModifiReunion_Click;
            // 
            // btReunionAgre
            // 
            btReunionAgre.BackColor = Color.FromArgb(54, 195, 103);
            btReunionAgre.FlatAppearance.BorderSize = 0;
            btReunionAgre.FlatStyle = FlatStyle.Flat;
            btReunionAgre.ForeColor = Color.White;
            btReunionAgre.Location = new Point(33, 310);
            btReunionAgre.Margin = new Padding(4, 5, 4, 5);
            btReunionAgre.Name = "btReunionAgre";
            btReunionAgre.Size = new Size(196, 35);
            btReunionAgre.TabIndex = 6;
            btReunionAgre.Text = "Agregar ";
            btReunionAgre.UseVisualStyleBackColor = false;
            btReunionAgre.Click += btReunionAgre_Click;
            // 
            // tpParticipante
            // 
            tpParticipante.Controls.Add(btElimiarParticipante);
            tpParticipante.Controls.Add(dataGridView3);
            tpParticipante.Controls.Add(btModificarParticipante);
            tpParticipante.Controls.Add(btAgregarParticipante);
            tpParticipante.Location = new Point(4, 24);
            tpParticipante.Margin = new Padding(2);
            tpParticipante.Name = "tpParticipante";
            tpParticipante.Padding = new Padding(2);
            tpParticipante.Size = new Size(729, 393);
            tpParticipante.TabIndex = 2;
            tpParticipante.Text = "Participante";
            tpParticipante.UseVisualStyleBackColor = true;
            // 
            // btElimiarParticipante
            // 
            btElimiarParticipante.BackColor = Color.FromArgb(54, 195, 103);
            btElimiarParticipante.FlatAppearance.BorderSize = 0;
            btElimiarParticipante.FlatStyle = FlatStyle.Flat;
            btElimiarParticipante.ForeColor = Color.White;
            btElimiarParticipante.Location = new Point(464, 310);
            btElimiarParticipante.Margin = new Padding(4, 5, 4, 5);
            btElimiarParticipante.Name = "btElimiarParticipante";
            btElimiarParticipante.Size = new Size(196, 35);
            btElimiarParticipante.TabIndex = 7;
            btElimiarParticipante.Text = "Eliminar";
            btElimiarParticipante.UseVisualStyleBackColor = false;
            btElimiarParticipante.Click += btElimiarParticipante_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, nombreDataGridViewTextBoxColumn1, apellidoDataGridViewTextBoxColumn, TipoParticipanteNombre });
            dataGridView3.DataSource = participanteBindingSource;
            dataGridView3.Location = new Point(2, 4);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.RowTemplate.Height = 33;
            dataGridView3.Size = new Size(720, 262);
            dataGridView3.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 8;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.ReadOnly = true;
            idDataGridViewTextBoxColumn2.Width = 50;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn1.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            nombreDataGridViewTextBoxColumn1.Width = 200;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.MinimumWidth = 8;
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            apellidoDataGridViewTextBoxColumn.Width = 200;
            // 
            // TipoParticipanteNombre
            // 
            TipoParticipanteNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TipoParticipanteNombre.DataPropertyName = "TipoParticipanteNombre";
            TipoParticipanteNombre.HeaderText = "TipoParticipanteNombre";
            TipoParticipanteNombre.Name = "TipoParticipanteNombre";
            TipoParticipanteNombre.ReadOnly = true;
            // 
            // participanteBindingSource
            // 
            participanteBindingSource.DataSource = typeof(Entidades.Participante);
            // 
            // btModificarParticipante
            // 
            btModificarParticipante.BackColor = Color.FromArgb(54, 195, 103);
            btModificarParticipante.FlatAppearance.BorderSize = 0;
            btModificarParticipante.FlatStyle = FlatStyle.Flat;
            btModificarParticipante.ForeColor = Color.White;
            btModificarParticipante.Location = new Point(245, 310);
            btModificarParticipante.Margin = new Padding(4, 5, 4, 5);
            btModificarParticipante.Name = "btModificarParticipante";
            btModificarParticipante.Size = new Size(196, 35);
            btModificarParticipante.TabIndex = 6;
            btModificarParticipante.Text = "Modificar";
            btModificarParticipante.UseVisualStyleBackColor = false;
            btModificarParticipante.Click += btModificarParticipante_Click;
            // 
            // btAgregarParticipante
            // 
            btAgregarParticipante.BackColor = Color.FromArgb(54, 195, 103);
            btAgregarParticipante.FlatAppearance.BorderSize = 0;
            btAgregarParticipante.FlatStyle = FlatStyle.Flat;
            btAgregarParticipante.ForeColor = Color.White;
            btAgregarParticipante.Location = new Point(33, 310);
            btAgregarParticipante.Margin = new Padding(4, 5, 4, 5);
            btAgregarParticipante.Name = "btAgregarParticipante";
            btAgregarParticipante.Size = new Size(196, 35);
            btAgregarParticipante.TabIndex = 5;
            btAgregarParticipante.Text = "Agregar";
            btAgregarParticipante.UseVisualStyleBackColor = false;
            btAgregarParticipante.Click += btAgregarParticipante_Click;
            // 
            // panelCertificado
            // 
            panelCertificado.BackColor = Color.White;
            panelCertificado.Controls.Add(panel4);
            panelCertificado.Location = new Point(665, 187);
            panelCertificado.Name = "panelCertificado";
            panelCertificado.Size = new Size(286, 138);
            panelCertificado.TabIndex = 2;
            panelCertificado.Visible = false;
            panelCertificado.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(39, 39, 65);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(bt_Certificado);
            panel4.Controls.Add(cbEventoCertificado);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(cbParticipanteCertificado);
            panel4.Location = new Point(14, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(257, 209);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Evento";
            // 
            // bt_Certificado
            // 
            bt_Certificado.BackColor = Color.FromArgb(39, 39, 65);
            bt_Certificado.FlatAppearance.BorderSize = 0;
            bt_Certificado.FlatStyle = FlatStyle.Flat;
            bt_Certificado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bt_Certificado.ForeColor = Color.White;
            bt_Certificado.Location = new Point(28, 148);
            bt_Certificado.Name = "bt_Certificado";
            bt_Certificado.Size = new Size(174, 37);
            bt_Certificado.TabIndex = 4;
            bt_Certificado.Text = "Generar Certificado";
            bt_Certificado.UseVisualStyleBackColor = false;
            bt_Certificado.Click += bt_Certificado_Click;
            bt_Certificado.MouseEnter += OnMouseEnterBoton;
            bt_Certificado.MouseLeave += OnMouseLeaveBoton;
            // 
            // cbEventoCertificado
            // 
            cbEventoCertificado.DataSource = eventoBindingSource2;
            cbEventoCertificado.DisplayMember = "Nombre";
            cbEventoCertificado.FormattingEnabled = true;
            cbEventoCertificado.Location = new Point(11, 31);
            cbEventoCertificado.Name = "cbEventoCertificado";
            cbEventoCertificado.Size = new Size(191, 23);
            cbEventoCertificado.TabIndex = 0;
            cbEventoCertificado.ValueMember = "id";
            cbEventoCertificado.SelectedIndexChanged += cbEventoCertificado_SelectedIndexChanged;
            cbEventoCertificado.Click += cbEventoCertificado_Click;
            // 
            // eventoBindingSource2
            // 
            eventoBindingSource2.DataSource = typeof(Entidades.Evento);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 79);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Participante";
            // 
            // cbParticipanteCertificado
            // 
            cbParticipanteCertificado.DataSource = participanteBindingSource1;
            cbParticipanteCertificado.DisplayMember = "Nombre";
            cbParticipanteCertificado.FormattingEnabled = true;
            cbParticipanteCertificado.Location = new Point(11, 94);
            cbParticipanteCertificado.Name = "cbParticipanteCertificado";
            cbParticipanteCertificado.Size = new Size(191, 23);
            cbParticipanteCertificado.TabIndex = 2;
            cbParticipanteCertificado.ValueMember = "id";
            cbParticipanteCertificado.SelectedIndexChanged += cbParticipanteCertificado_SelectedChangedIndex;
            cbParticipanteCertificado.Click += cbParticipanteCertificado_Click;
            // 
            // participanteBindingSource1
            // 
            participanteBindingSource1.DataSource = typeof(Entidades.Participante);
            // 
            // eventoBindingSource1
            // 
            eventoBindingSource1.DataSource = typeof(Entidades.Evento);
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(54, 195, 103);
            panelSuperior.Controls.Add(labelPrincipal);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(154, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(764, 48);
            panelSuperior.TabIndex = 4;
            // 
            // panelAsistencias
            // 
            panelAsistencias.BackColor = Color.White;
            panelAsistencias.Controls.Add(panelbtAsistencias);
            panelAsistencias.Controls.Add(panelOpcionesAsistencia);
            panelAsistencias.Location = new Point(55, 61);
            panelAsistencias.Name = "panelAsistencias";
            panelAsistencias.Size = new Size(550, 264);
            panelAsistencias.TabIndex = 3;
            panelAsistencias.Visible = false;
            // 
            // panelbtAsistencias
            // 
            panelbtAsistencias.Location = new Point(253, 82);
            panelbtAsistencias.Name = "panelbtAsistencias";
            panelbtAsistencias.Size = new Size(234, 119);
            panelbtAsistencias.TabIndex = 6;
            // 
            // panelOpcionesAsistencia
            // 
            panelOpcionesAsistencia.BackColor = Color.FromArgb(39, 39, 90);
            panelOpcionesAsistencia.Controls.Add(btGuardarAsistencia);
            panelOpcionesAsistencia.Controls.Add(btTodosAusentes);
            panelOpcionesAsistencia.Controls.Add(btTodosPresentes);
            panelOpcionesAsistencia.Controls.Add(label3);
            panelOpcionesAsistencia.Controls.Add(label4);
            panelOpcionesAsistencia.Controls.Add(cbReunionesAsistencias);
            panelOpcionesAsistencia.Controls.Add(cbEventoAsistencias);
            panelOpcionesAsistencia.Location = new Point(25, 3);
            panelOpcionesAsistencia.Name = "panelOpcionesAsistencia";
            panelOpcionesAsistencia.Size = new Size(161, 261);
            panelOpcionesAsistencia.TabIndex = 5;
            // 
            // btGuardarAsistencia
            // 
            btGuardarAsistencia.FlatAppearance.BorderSize = 0;
            btGuardarAsistencia.FlatStyle = FlatStyle.Flat;
            btGuardarAsistencia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardarAsistencia.ForeColor = Color.White;
            btGuardarAsistencia.Location = new Point(4, 223);
            btGuardarAsistencia.Name = "btGuardarAsistencia";
            btGuardarAsistencia.Size = new Size(155, 34);
            btGuardarAsistencia.TabIndex = 6;
            btGuardarAsistencia.Text = "Guardar";
            btGuardarAsistencia.UseVisualStyleBackColor = true;
            btGuardarAsistencia.Click += btGuardarAsistencia_Click;
            btGuardarAsistencia.MouseEnter += OnMouseEnterBoton;
            btGuardarAsistencia.MouseLeave += OnMouseLeaveBoton;
            // 
            // btTodosAusentes
            // 
            btTodosAusentes.FlatAppearance.BorderSize = 0;
            btTodosAusentes.FlatStyle = FlatStyle.Flat;
            btTodosAusentes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btTodosAusentes.ForeColor = Color.White;
            btTodosAusentes.Location = new Point(3, 189);
            btTodosAusentes.Name = "btTodosAusentes";
            btTodosAusentes.Size = new Size(154, 28);
            btTodosAusentes.TabIndex = 5;
            btTodosAusentes.Text = "Todos Ausente";
            btTodosAusentes.UseVisualStyleBackColor = true;
            btTodosAusentes.Click += btTodosAusentes_Click;
            btTodosAusentes.MouseEnter += OnMouseEnterBoton;
            btTodosAusentes.MouseLeave += OnMouseLeaveBoton;
            // 
            // btTodosPresentes
            // 
            btTodosPresentes.FlatAppearance.BorderSize = 0;
            btTodosPresentes.FlatStyle = FlatStyle.Flat;
            btTodosPresentes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btTodosPresentes.ForeColor = Color.White;
            btTodosPresentes.Location = new Point(4, 152);
            btTodosPresentes.Name = "btTodosPresentes";
            btTodosPresentes.Size = new Size(154, 31);
            btTodosPresentes.TabIndex = 4;
            btTodosPresentes.Text = "Todos Presente";
            btTodosPresentes.UseVisualStyleBackColor = true;
            btTodosPresentes.Click += btTodosPresentes_Click;
            btTodosPresentes.MouseEnter += OnMouseEnterBoton;
            btTodosPresentes.MouseLeave += OnMouseLeaveBoton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 10);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 1;
            label3.Text = "Evento: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 68);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Reunion:";
            // 
            // cbReunionesAsistencias
            // 
            cbReunionesAsistencias.DataSource = reunionBindingSource;
            cbReunionesAsistencias.DisplayMember = "hora";
            cbReunionesAsistencias.FormattingEnabled = true;
            cbReunionesAsistencias.Location = new Point(4, 86);
            cbReunionesAsistencias.Name = "cbReunionesAsistencias";
            cbReunionesAsistencias.Size = new Size(154, 23);
            cbReunionesAsistencias.TabIndex = 2;
            cbReunionesAsistencias.ValueMember = "Id";
            cbReunionesAsistencias.SelectedIndexChanged += cbReunionesAsistencias_SelectedIndexChanged;
            // 
            // cbEventoAsistencias
            // 
            cbEventoAsistencias.DataSource = eventoBindingSource;
            cbEventoAsistencias.DisplayMember = "Nombre";
            cbEventoAsistencias.FormattingEnabled = true;
            cbEventoAsistencias.Location = new Point(4, 28);
            cbEventoAsistencias.Name = "cbEventoAsistencias";
            cbEventoAsistencias.Size = new Size(154, 23);
            cbEventoAsistencias.TabIndex = 0;
            cbEventoAsistencias.ValueMember = "Id";
            cbEventoAsistencias.SelectedIndexChanged += cbEventoAsistencias_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(panelCertificado);
            panel3.Controls.Add(panelAsistencias);
            panel3.Controls.Add(panelABM);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(154, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 373);
            panel3.TabIndex = 5;
            // 
            // labelPrincipal
            // 
            labelPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrincipal.ForeColor = Color.White;
            labelPrincipal.Location = new Point(6, 9);
            labelPrincipal.Name = "labelPrincipal";
            labelPrincipal.Size = new Size(756, 36);
            labelPrincipal.TabIndex = 0;
            labelPrincipal.Text = "label5";
            labelPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 421);
            Controls.Add(panel3);
            Controls.Add(panelSuperior);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panelABM.ResumeLayout(false);
            tcABM.ResumeLayout(false);
            tpEvento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource).EndInit();
            tpReunion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)reunionBindingSource).EndInit();
            tpParticipante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource).EndInit();
            panelCertificado.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)participanteBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventoBindingSource1).EndInit();
            panelSuperior.ResumeLayout(false);
            panelAsistencias.ResumeLayout(false);
            panelOpcionesAsistencia.ResumeLayout(false);
            panelOpcionesAsistencia.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btCerrar;
        private Button btMenuCertificado;
        private Button btAsistencias;
        private Button btABM;
        private TabControl tcABM;
        private TabPage tpEvento;
        private TabPage tpReunion;
        private BindingSource eventoBindingSource;
        private BindingSource reunionBindingSource;
        private DataGridView dataGridView2;
        private TabPage tpParticipante;
        private DataGridView dataGridView3;
        private BindingSource participanteBindingSource;
        private DataGridViewTextBoxColumn tipoEventoDataGridViewTextBoxColumn;
        private Button btAgregarEvento;
        private Button btEliminarEvento;
        private Button btModificarEvento;
        private DataGridViewTextBoxColumn tipoEventoNombreDataGridViewTextBoxColumn;
        private BindingSource eventoBindingSource1;
        private DataGridView dataGridView1;
        private Panel panelCertificado;
        private Label label1;
        private ComboBox cbEventoCertificado;
        private Label label2;
        private ComboBox cbParticipanteCertificado;
        private Button bt_Certificado;
        private BindingSource eventoBindingSource2;
        private BindingSource participanteBindingSource1;
        private Panel panelABM;
        private Button btReunionElim;
        private Button btReunionMod;
        private Button btReunionAgre;
        private Button btElimiarParticipante;
        private Button btModificarParticipante;
        private Button btAgregarParticipante;
        private Panel panelSuperior;
        private Panel panelAsistencias;
        private Panel panelOpcionesAsistencia;
        private Button btGuardarAsistencia;
        private Button btTodosAusentes;
        private Button btTodosPresentes;
        private Label label3;
        private Label label4;
        private ComboBox cbReunionesAsistencias;
        private ComboBox cbEventoAsistencias;
        private Panel panel3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expositorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cantidadHorasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private Panel panel4;
        private Panel panelbtAsistencias;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoParticipanteNombre;
        private Label labelPrincipal;
    }
}