namespace Escaneo
{
	partial class EscaneoForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscaneoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verÚltimosRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.regresarYSeleccionarLectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informarDeUnErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImagenHuellaEx = new System.Windows.Forms.PictureBox();
            this.GrupoHuella = new System.Windows.Forms.GroupBox();
            this.lblMensajeHuella = new System.Windows.Forms.Label();
            this.Visor = new System.Windows.Forms.DataGridView();
            this.BarraProgreso = new System.Windows.Forms.ProgressBar();
            this.btnEscanearHuellaE = new System.Windows.Forms.Button();
            this.btnEscanearHuellaA = new System.Windows.Forms.Button();
            this.btnGuardarHuellaE = new System.Windows.Forms.Button();
            this.btnGuardarHuellaA = new System.Windows.Forms.Button();
            this.btnVerificarHuellaE = new System.Windows.Forms.Button();
            this.btnVerificarHuellaA = new System.Windows.Forms.Button();
            this.GrupoLabel = new System.Windows.Forms.GroupBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.RegistrosBDD = new System.Windows.Forms.ListBox();
            this.GrupoBDD = new System.Windows.Forms.GroupBox();
            this.btnEliminarRegistro = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenHuellaEx)).BeginInit();
            this.GrupoHuella.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).BeginInit();
            this.GrupoLabel.SuspendLayout();
            this.GrupoBDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAToolStripMenuItem,
            this.toolStripSeparator2,
            this.lectorToolStripMenuItem,
            this.toolStripSeparator4,
            this.sesiónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarAToolStripMenuItem
            // 
            this.registrarAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.registrarAToolStripMenuItem.Name = "registrarAToolStripMenuItem";
            this.registrarAToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.registrarAToolStripMenuItem.Text = "Registrar a...";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.CheckOnClick = true;
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.alumnoToolStripMenuItem.Text = "Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.CheckOnClick = true;
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // lectorToolStripMenuItem
            // 
            this.lectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verÚltimosRegistrosToolStripMenuItem,
            this.limpiarBaseDeDatosToolStripMenuItem,
            this.toolStripSeparator1,
            this.regresarYSeleccionarLectorToolStripMenuItem});
            this.lectorToolStripMenuItem.Name = "lectorToolStripMenuItem";
            this.lectorToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.lectorToolStripMenuItem.Text = "Configuración";
            // 
            // verÚltimosRegistrosToolStripMenuItem
            // 
            this.verÚltimosRegistrosToolStripMenuItem.Checked = true;
            this.verÚltimosRegistrosToolStripMenuItem.CheckOnClick = true;
            this.verÚltimosRegistrosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verÚltimosRegistrosToolStripMenuItem.Name = "verÚltimosRegistrosToolStripMenuItem";
            this.verÚltimosRegistrosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.verÚltimosRegistrosToolStripMenuItem.Text = "Ver últimos registros";
            this.verÚltimosRegistrosToolStripMenuItem.Click += new System.EventHandler(this.verÚltimosRegistrosToolStripMenuItem_Click_1);
            // 
            // limpiarBaseDeDatosToolStripMenuItem
            // 
            this.limpiarBaseDeDatosToolStripMenuItem.Name = "limpiarBaseDeDatosToolStripMenuItem";
            this.limpiarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.limpiarBaseDeDatosToolStripMenuItem.Text = "Limpiar últimos registros";
            this.limpiarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.limpiarBaseDeDatosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // regresarYSeleccionarLectorToolStripMenuItem
            // 
            this.regresarYSeleccionarLectorToolStripMenuItem.Name = "regresarYSeleccionarLectorToolStripMenuItem";
            this.regresarYSeleccionarLectorToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.regresarYSeleccionarLectorToolStripMenuItem.Text = "Regresar y seleccionar lector";
            this.regresarYSeleccionarLectorToolStripMenuItem.Click += new System.EventHandler(this.regresarYSeleccionarLectorToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(147, 6);
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sesiónToolStripMenuItem.Text = "Sesión...";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.informaciónToolStripMenuItem.Text = "Información...";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informarDeUnErrorToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informarDeUnErrorToolStripMenuItem
            // 
            this.informarDeUnErrorToolStripMenuItem.Name = "informarDeUnErrorToolStripMenuItem";
            this.informarDeUnErrorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.informarDeUnErrorToolStripMenuItem.Text = "Informar de un error";
            this.informarDeUnErrorToolStripMenuItem.Click += new System.EventHandler(this.informarDeUnErrorToolStripMenuItem_Click);
            // 
            // ImagenHuellaEx
            // 
            this.ImagenHuellaEx.BackColor = System.Drawing.Color.Transparent;
            this.ImagenHuellaEx.BackgroundImage = global::CoDE_Proyect.Properties.Resources.AñadirHuella;
            this.ImagenHuellaEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenHuellaEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenHuellaEx.Location = new System.Drawing.Point(14, 25);
            this.ImagenHuellaEx.Name = "ImagenHuellaEx";
            this.ImagenHuellaEx.Size = new System.Drawing.Size(189, 189);
            this.ImagenHuellaEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenHuellaEx.TabIndex = 5;
            this.ImagenHuellaEx.TabStop = false;
            // 
            // GrupoHuella
            // 
            this.GrupoHuella.Controls.Add(this.lblMensajeHuella);
            this.GrupoHuella.Controls.Add(this.Visor);
            this.GrupoHuella.Controls.Add(this.BarraProgreso);
            this.GrupoHuella.Controls.Add(this.ImagenHuellaEx);
            this.GrupoHuella.Controls.Add(this.btnEscanearHuellaA);
            this.GrupoHuella.Controls.Add(this.btnGuardarHuellaA);
            this.GrupoHuella.Controls.Add(this.btnVerificarHuellaA);
            this.GrupoHuella.Controls.Add(this.GrupoLabel);
            this.GrupoHuella.Controls.Add(this.btnEscanearHuellaE);
            this.GrupoHuella.Controls.Add(this.btnGuardarHuellaE);
            this.GrupoHuella.Controls.Add(this.btnVerificarHuellaE);
            this.GrupoHuella.Location = new System.Drawing.Point(12, 32);
            this.GrupoHuella.Name = "GrupoHuella";
            this.GrupoHuella.Size = new System.Drawing.Size(395, 270);
            this.GrupoHuella.TabIndex = 0;
            this.GrupoHuella.TabStop = false;
            // 
            // lblMensajeHuella
            // 
            this.lblMensajeHuella.AutoSize = true;
            this.lblMensajeHuella.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeHuella.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeHuella.Location = new System.Drawing.Point(213, 234);
            this.lblMensajeHuella.Name = "lblMensajeHuella";
            this.lblMensajeHuella.Size = new System.Drawing.Size(98, 15);
            this.lblMensajeHuella.TabIndex = 0;
            this.lblMensajeHuella.Text = "Estatus de huella.";
            this.lblMensajeHuella.Visible = false;
            // 
            // Visor
            // 
            this.Visor.AllowUserToAddRows = false;
            this.Visor.AllowUserToDeleteRows = false;
            this.Visor.AllowUserToOrderColumns = true;
            this.Visor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Visor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Visor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Visor.Location = new System.Drawing.Point(375, 250);
            this.Visor.Name = "Visor";
            this.Visor.ReadOnly = true;
            this.Visor.RowHeadersWidth = 40;
            this.Visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Visor.RowTemplate.Height = 75;
            this.Visor.RowTemplate.ReadOnly = true;
            this.Visor.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Visor.Size = new System.Drawing.Size(15, 15);
            this.Visor.TabIndex = 0;
            this.Visor.Visible = false;
            // 
            // BarraProgreso
            // 
            this.BarraProgreso.Location = new System.Drawing.Point(14, 234);
            this.BarraProgreso.Name = "BarraProgreso";
            this.BarraProgreso.Size = new System.Drawing.Size(189, 15);
            this.BarraProgreso.TabIndex = 0;
            // 
            // btnEscanearHuellaE
            // 
            this.btnEscanearHuellaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnEscanearHuellaE.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEscanearHuellaE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanearHuellaE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEscanearHuellaE.Location = new System.Drawing.Point(215, 40);
            this.btnEscanearHuellaE.Name = "btnEscanearHuellaE";
            this.btnEscanearHuellaE.Size = new System.Drawing.Size(165, 45);
            this.btnEscanearHuellaE.TabIndex = 1;
            this.btnEscanearHuellaE.Text = "ESCANEAR HUELLA";
            this.btnEscanearHuellaE.UseVisualStyleBackColor = false;
            this.btnEscanearHuellaE.Visible = false;
            this.btnEscanearHuellaE.Click += new System.EventHandler(this.btnEscanearHuellaE_Click);
            // 
            // btnEscanearHuellaA
            // 
            this.btnEscanearHuellaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnEscanearHuellaA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEscanearHuellaA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscanearHuellaA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEscanearHuellaA.Location = new System.Drawing.Point(215, 40);
            this.btnEscanearHuellaA.Name = "btnEscanearHuellaA";
            this.btnEscanearHuellaA.Size = new System.Drawing.Size(165, 45);
            this.btnEscanearHuellaA.TabIndex = 1;
            this.btnEscanearHuellaA.Text = "ESCANEAR HUELLA";
            this.btnEscanearHuellaA.UseVisualStyleBackColor = false;
            this.btnEscanearHuellaA.Visible = false;
            this.btnEscanearHuellaA.Click += new System.EventHandler(this.btnEscanearHuella_Click);
            // 
            // btnGuardarHuellaE
            // 
            this.btnGuardarHuellaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnGuardarHuellaE.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarHuellaE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHuellaE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarHuellaE.Location = new System.Drawing.Point(215, 95);
            this.btnGuardarHuellaE.Name = "btnGuardarHuellaE";
            this.btnGuardarHuellaE.Size = new System.Drawing.Size(165, 49);
            this.btnGuardarHuellaE.TabIndex = 2;
            this.btnGuardarHuellaE.Text = "GUARDAR HUELLA";
            this.btnGuardarHuellaE.UseVisualStyleBackColor = false;
            this.btnGuardarHuellaE.Visible = false;
            this.btnGuardarHuellaE.Click += new System.EventHandler(this.btnGuardarHuellaE_Click);
            // 
            // btnGuardarHuellaA
            // 
            this.btnGuardarHuellaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnGuardarHuellaA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardarHuellaA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHuellaA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarHuellaA.Location = new System.Drawing.Point(215, 95);
            this.btnGuardarHuellaA.Name = "btnGuardarHuellaA";
            this.btnGuardarHuellaA.Size = new System.Drawing.Size(165, 49);
            this.btnGuardarHuellaA.TabIndex = 2;
            this.btnGuardarHuellaA.Text = "GUARDAR HUELLA";
            this.btnGuardarHuellaA.UseVisualStyleBackColor = false;
            this.btnGuardarHuellaA.Visible = false;
            this.btnGuardarHuellaA.Click += new System.EventHandler(this.btnGuardarHuella_Click);
            // 
            // btnVerificarHuellaE
            // 
            this.btnVerificarHuellaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnVerificarHuellaE.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerificarHuellaE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarHuellaE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerificarHuellaE.Location = new System.Drawing.Point(215, 155);
            this.btnVerificarHuellaE.Name = "btnVerificarHuellaE";
            this.btnVerificarHuellaE.Size = new System.Drawing.Size(165, 45);
            this.btnVerificarHuellaE.TabIndex = 3;
            this.btnVerificarHuellaE.Text = "VERIFICAR HUELLA";
            this.btnVerificarHuellaE.UseVisualStyleBackColor = false;
            this.btnVerificarHuellaE.Visible = false;
            this.btnVerificarHuellaE.Click += new System.EventHandler(this.btnVerificarHuellaE_Click);
            // 
            // btnVerificarHuellaA
            // 
            this.btnVerificarHuellaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnVerificarHuellaA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerificarHuellaA.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarHuellaA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerificarHuellaA.Location = new System.Drawing.Point(215, 155);
            this.btnVerificarHuellaA.Name = "btnVerificarHuellaA";
            this.btnVerificarHuellaA.Size = new System.Drawing.Size(165, 45);
            this.btnVerificarHuellaA.TabIndex = 3;
            this.btnVerificarHuellaA.Text = "VERIFICAR HUELLA";
            this.btnVerificarHuellaA.UseVisualStyleBackColor = false;
            this.btnVerificarHuellaA.Visible = false;
            this.btnVerificarHuellaA.Click += new System.EventHandler(this.btnVerificarHuella_Click);
            // 
            // GrupoLabel
            // 
            this.GrupoLabel.Controls.Add(this.lblTexto);
            this.GrupoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoLabel.Location = new System.Drawing.Point(216, 18);
            this.GrupoLabel.Name = "GrupoLabel";
            this.GrupoLabel.Size = new System.Drawing.Size(164, 196);
            this.GrupoLabel.TabIndex = 6;
            this.GrupoLabel.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTexto.Location = new System.Drawing.Point(3, 21);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(161, 135);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Seleccione un tipo de \r\nregistro para continuar.\r\nHaga clic en:        \r\n\r\nOpcion" +
    "es > Configuración > \r\nRegistro\r\n\r\ny seleccione un tipo de\r\nregistro para trabaj" +
    "ar.";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrosBDD
            // 
            this.RegistrosBDD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrosBDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegistrosBDD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrosBDD.FormattingEnabled = true;
            this.RegistrosBDD.ItemHeight = 17;
            this.RegistrosBDD.Location = new System.Drawing.Point(6, 18);
            this.RegistrosBDD.Name = "RegistrosBDD";
            this.RegistrosBDD.Size = new System.Drawing.Size(189, 189);
            this.RegistrosBDD.TabIndex = 0;
            this.RegistrosBDD.SelectedIndexChanged += new System.EventHandler(this.lbDatabase_SelectedIndexChanged);
            // 
            // GrupoBDD
            // 
            this.GrupoBDD.Controls.Add(this.btnEliminarRegistro);
            this.GrupoBDD.Controls.Add(this.RegistrosBDD);
            this.GrupoBDD.Location = new System.Drawing.Point(413, 32);
            this.GrupoBDD.Name = "GrupoBDD";
            this.GrupoBDD.Size = new System.Drawing.Size(201, 270);
            this.GrupoBDD.TabIndex = 0;
            this.GrupoBDD.TabStop = false;
            // 
            // btnEliminarRegistro
            // 
            this.btnEliminarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarRegistro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminarRegistro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRegistro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminarRegistro.Location = new System.Drawing.Point(6, 224);
            this.btnEliminarRegistro.Name = "btnEliminarRegistro";
            this.btnEliminarRegistro.Size = new System.Drawing.Size(189, 32);
            this.btnEliminarRegistro.TabIndex = 1;
            this.btnEliminarRegistro.Text = "ELIMINAR REGISTRO";
            this.btnEliminarRegistro.UseVisualStyleBackColor = false;
            this.btnEliminarRegistro.Click += new System.EventHandler(this.btnEliminarRegistro_Click);
            // 
            // EscaneoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(626, 319);
            this.Controls.Add(this.GrupoBDD);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.GrupoHuella);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EscaneoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escanear huella";
            this.Load += new System.EventHandler(this.EscaneoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenHuellaEx)).EndInit();
            this.GrupoHuella.ResumeLayout(false);
            this.GrupoHuella.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).EndInit();
            this.GrupoLabel.ResumeLayout(false);
            this.GrupoLabel.PerformLayout();
            this.GrupoBDD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informarDeUnErrorToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImagenHuellaEx;
        private System.Windows.Forms.GroupBox GrupoHuella;
        private System.Windows.Forms.Label lblMensajeHuella;
        private System.Windows.Forms.Button btnGuardarHuellaA;
        private System.Windows.Forms.Button btnEscanearHuellaA;
        private System.Windows.Forms.Button btnVerificarHuellaA;
        private System.Windows.Forms.ListBox RegistrosBDD;
        private System.Windows.Forms.ToolStripMenuItem lectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verÚltimosRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.GroupBox GrupoBDD;
        private System.Windows.Forms.Button btnEliminarRegistro;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem regresarYSeleccionarLectorToolStripMenuItem;
        private System.Windows.Forms.DataGridView Visor;
        private System.Windows.Forms.ProgressBar BarraProgreso;
        private System.Windows.Forms.Button btnVerificarHuellaE;
        private System.Windows.Forms.Button btnEscanearHuellaE;
        private System.Windows.Forms.Button btnGuardarHuellaE;
        private System.Windows.Forms.GroupBox GrupoLabel;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.ToolStripMenuItem registrarAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

