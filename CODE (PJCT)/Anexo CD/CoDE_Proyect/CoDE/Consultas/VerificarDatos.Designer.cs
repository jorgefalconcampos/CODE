namespace CoDE_Proyect.CoDE.Consultas
{
    partial class VerificarDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificarDatos));
            this.lblNumBoleta = new System.Windows.Forms.Label();
            this.txtAlumnoBol = new System.Windows.Forms.TextBox();
            this.Visor = new System.Windows.Forms.DataGridView();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.GrupoVerificar = new System.Windows.Forms.GroupBox();
            this.ImgAlumno = new System.Windows.Forms.PictureBox();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informarDeUnErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaAuditivaAAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAA = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).BeginInit();
            this.GrupoVerificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlumno)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumBoleta
            // 
            this.lblNumBoleta.AutoSize = true;
            this.lblNumBoleta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoleta.Location = new System.Drawing.Point(23, 73);
            this.lblNumBoleta.Name = "lblNumBoleta";
            this.lblNumBoleta.Size = new System.Drawing.Size(92, 15);
            this.lblNumBoleta.TabIndex = 6;
            this.lblNumBoleta.Text = "Num. de boleta:";
            // 
            // txtAlumnoBol
            // 
            this.txtAlumnoBol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumnoBol.Location = new System.Drawing.Point(123, 70);
            this.txtAlumnoBol.Name = "txtAlumnoBol";
            this.txtAlumnoBol.Size = new System.Drawing.Size(187, 23);
            this.txtAlumnoBol.TabIndex = 7;
            this.txtAlumnoBol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlumnoBol_KeyPress);
            // 
            // Visor
            // 
            this.Visor.AllowUserToAddRows = false;
            this.Visor.AllowUserToDeleteRows = false;
            this.Visor.AllowUserToResizeRows = false;
            this.Visor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Visor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Visor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Visor.DefaultCellStyle = dataGridViewCellStyle1;
            this.Visor.Location = new System.Drawing.Point(6, 112);
            this.Visor.Name = "Visor";
            this.Visor.ReadOnly = true;
            this.Visor.RowHeadersWidth = 24;
            this.Visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Visor.RowTemplate.Height = 10;
            this.Visor.RowTemplate.ReadOnly = true;
            this.Visor.Size = new System.Drawing.Size(648, 71);
            this.Visor.TabIndex = 8;
            this.Visor.Visible = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerificar.Location = new System.Drawing.Point(527, 191);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(125, 34);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar datos";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Visible = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // GrupoVerificar
            // 
            this.GrupoVerificar.Controls.Add(this.ImgAlumno);
            this.GrupoVerificar.Controls.Add(this.lblEncontrado);
            this.GrupoVerificar.Controls.Add(this.btnVerificar);
            this.GrupoVerificar.Controls.Add(this.Visor);
            this.GrupoVerificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoVerificar.Location = new System.Drawing.Point(12, 32);
            this.GrupoVerificar.Name = "GrupoVerificar";
            this.GrupoVerificar.Size = new System.Drawing.Size(660, 250);
            this.GrupoVerificar.TabIndex = 10;
            this.GrupoVerificar.TabStop = false;
            // 
            // ImgAlumno
            // 
            this.ImgAlumno.BackColor = System.Drawing.Color.Transparent;
            this.ImgAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgAlumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgAlumno.Enabled = false;
            this.ImgAlumno.Location = new System.Drawing.Point(563, 19);
            this.ImgAlumno.Name = "ImgAlumno";
            this.ImgAlumno.Size = new System.Drawing.Size(80, 80);
            this.ImgAlumno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgAlumno.TabIndex = 24;
            this.ImgAlumno.TabStop = false;
            this.ImgAlumno.Visible = false;
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrado.Location = new System.Drawing.Point(10, 82);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(68, 20);
            this.lblEncontrado.TabIndex = 10;
            this.lblEncontrado.Text = "ESTADO ";
            this.lblEncontrado.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAToolStripMenuItem,
            this.toolStripSeparator3,
            this.sesiónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // irAToolStripMenuItem
            // 
            this.irAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúPrincipalToolStripMenuItem,
            this.toolStripSeparator5,
            this.consultaToolStripMenuItem,
            this.alumnosToolStripMenuItem1,
            this.empleadosToolStripMenuItem1});
            this.irAToolStripMenuItem.Name = "irAToolStripMenuItem";
            this.irAToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.irAToolStripMenuItem.Text = "Ir a...";
            // 
            // menúPrincipalToolStripMenuItem
            // 
            this.menúPrincipalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menúPrincipalToolStripMenuItem.Name = "menúPrincipalToolStripMenuItem";
            this.menúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.menúPrincipalToolStripMenuItem.Text = "Menú Principal";
            this.menúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menúPrincipalToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(151, 6);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.consultaToolStripMenuItem.Text = "Consultas";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // alumnosToolStripMenuItem1
            // 
            this.alumnosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.alumnosToolStripMenuItem1.Name = "alumnosToolStripMenuItem1";
            this.alumnosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.alumnosToolStripMenuItem1.Text = "Alumnos...";
            this.alumnosToolStripMenuItem1.Click += new System.EventHandler(this.alumnosToolStripMenuItem1_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(114, 6);
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.sesiónToolStripMenuItem.Text = "Sesión...";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.informaciónToolStripMenuItem.Text = "Información...";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.consultarAlumnoToolStripMenuItem,
            this.eliminarAlumnoToolStripMenuItem});
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarToolStripMenuItem.Text = "Nuevo Alumno...";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // consultarAlumnoToolStripMenuItem
            // 
            this.consultarAlumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.consultarAlumnoToolStripMenuItem.Name = "consultarAlumnoToolStripMenuItem";
            this.consultarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultarAlumnoToolStripMenuItem.Text = "Consultar Alumno";
            this.consultarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlumnoToolStripMenuItem_Click);
            // 
            // eliminarAlumnoToolStripMenuItem
            // 
            this.eliminarAlumnoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.eliminarAlumnoToolStripMenuItem.Name = "eliminarAlumnoToolStripMenuItem";
            this.eliminarAlumnoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.eliminarAlumnoToolStripMenuItem.Text = "Eliminar Alumno...";
            this.eliminarAlumnoToolStripMenuItem.Click += new System.EventHandler(this.eliminarAlumnoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informarDeUnErrorToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.ayudaAuditivaAAToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informarDeUnErrorToolStripMenuItem
            // 
            this.informarDeUnErrorToolStripMenuItem.Name = "informarDeUnErrorToolStripMenuItem";
            this.informarDeUnErrorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.informarDeUnErrorToolStripMenuItem.Text = "Informar de un error";
            this.informarDeUnErrorToolStripMenuItem.Click += new System.EventHandler(this.informarDeUnErrorToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // ayudaAuditivaAAToolStripMenuItem
            // 
            this.ayudaAuditivaAAToolStripMenuItem.Checked = true;
            this.ayudaAuditivaAAToolStripMenuItem.CheckOnClick = true;
            this.ayudaAuditivaAAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ayudaAuditivaAAToolStripMenuItem.Name = "ayudaAuditivaAAToolStripMenuItem";
            this.ayudaAuditivaAAToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ayudaAuditivaAAToolStripMenuItem.Text = "Ayuda Auditiva (AA)";
            // 
            // btnAA
            // 
            this.btnAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnAA.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Sonido;
            this.btnAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAA.Location = new System.Drawing.Point(633, 0);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(24, 24);
            this.btnAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAA.TabIndex = 13;
            this.btnAA.TabStop = false;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Location = new System.Drawing.Point(91, 294);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 35);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "REGRESAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Location = new System.Drawing.Point(267, 294);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(443, 294);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 35);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VerificarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 344);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAA);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblNumBoleta);
            this.Controls.Add(this.txtAlumnoBol);
            this.Controls.Add(this.GrupoVerificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerificarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar datos del alumno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerificarDatos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Visor)).EndInit();
            this.GrupoVerificar.ResumeLayout(false);
            this.GrupoVerificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAlumno)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumBoleta;
        private System.Windows.Forms.TextBox txtAlumnoBol;
        private System.Windows.Forms.DataGridView Visor;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox GrupoVerificar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informarDeUnErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ayudaAuditivaAAToolStripMenuItem;
        private System.Windows.Forms.PictureBox btnAA;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEncontrado;
        public System.Windows.Forms.PictureBox ImgAlumno;
    }
}