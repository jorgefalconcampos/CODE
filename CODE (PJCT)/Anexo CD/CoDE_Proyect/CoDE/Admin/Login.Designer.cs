namespace CoDE_Proyect
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.GrupoLogin = new System.Windows.Forms.GroupBox();
            this.lblNombreSesion = new System.Windows.Forms.Label();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblForgotPass = new System.Windows.Forms.LinkLabel();
            this.lbl_IniSesion = new System.Windows.Forms.Button();
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informarDeUnErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.olvidéMiContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ayudaAuditivaAAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAA = new System.Windows.Forms.PictureBox();
            this.iniciarSesiónSinConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.GrupoLogin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSiguiente.Location = new System.Drawing.Point(267, 313);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 40);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Location = new System.Drawing.Point(151, 313);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegresar.Location = new System.Drawing.Point(35, 313);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 40);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // GrupoLogin
            // 
            this.GrupoLogin.Controls.Add(this.lblNombreSesion);
            this.GrupoLogin.Controls.Add(this.chkMostrarPass);
            this.GrupoLogin.Controls.Add(this.lblHora);
            this.GrupoLogin.Controls.Add(this.lblForgotPass);
            this.GrupoLogin.Controls.Add(this.lbl_IniSesion);
            this.GrupoLogin.Controls.Add(this.txtAdministrador);
            this.GrupoLogin.Controls.Add(this.txtPass);
            this.GrupoLogin.Controls.Add(this.lblPass);
            this.GrupoLogin.Controls.Add(this.lblIntentos);
            this.GrupoLogin.Controls.Add(this.lblAdmin);
            this.GrupoLogin.Location = new System.Drawing.Point(12, 39);
            this.GrupoLogin.Name = "GrupoLogin";
            this.GrupoLogin.Size = new System.Drawing.Size(378, 259);
            this.GrupoLogin.TabIndex = 1;
            this.GrupoLogin.TabStop = false;
            // 
            // lblNombreSesion
            // 
            this.lblNombreSesion.AutoSize = true;
            this.lblNombreSesion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSesion.Location = new System.Drawing.Point(337, 16);
            this.lblNombreSesion.Name = "lblNombreSesion";
            this.lblNombreSesion.Size = new System.Drawing.Size(16, 13);
            this.lblNombreSesion.TabIndex = 0;
            this.lblNombreSesion.Text = ". .";
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarPass.Location = new System.Drawing.Point(221, 150);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(128, 19);
            this.chkMostrarPass.TabIndex = 3;
            this.chkMostrarPass.Text = "Mostrar contraseña";
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(352, 16);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(16, 13);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = ". .";
            this.lblHora.Visible = false;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.White;
            this.lblForgotPass.LinkColor = System.Drawing.Color.Black;
            this.lblForgotPass.Location = new System.Drawing.Point(17, 233);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(115, 13);
            this.lblForgotPass.TabIndex = 4;
            this.lblForgotPass.TabStop = true;
            this.lblForgotPass.Text = "Olvidé mi contraseña";
            this.lblForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgotPass_LinkClicked);
            // 
            // lbl_IniSesion
            // 
            this.lbl_IniSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lbl_IniSesion.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lbl_IniSesion.Enabled = false;
            this.lbl_IniSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_IniSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IniSesion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_IniSesion.Location = new System.Drawing.Point(1, 7);
            this.lbl_IniSesion.Name = "lbl_IniSesion";
            this.lbl_IniSesion.Size = new System.Drawing.Size(119, 28);
            this.lbl_IniSesion.TabIndex = 0;
            this.lbl_IniSesion.Text = "INICIE SESIÓN";
            this.lbl_IniSesion.UseVisualStyleBackColor = false;
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministrador.Location = new System.Drawing.Point(129, 75);
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(220, 25);
            this.txtAdministrador.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(129, 119);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(220, 25);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(16, 120);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntentos.Location = new System.Drawing.Point(233, 230);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(133, 17);
            this.lblIntentos.TabIndex = 0;
            this.lblIntentos.Text = "Intentos restantes: 3";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(16, 76);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(107, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrador:";
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.iniciarSesiónSinConexiónToolStripMenuItem});
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.administradorToolStripMenuItem.Text = "Opciones";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.toolStripMenuItem1.Text = "Regresar al Inicio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informarDeUnErrorToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator2,
            this.olvidéMiContraseñaToolStripMenuItem,
            this.toolStripSeparator1,
            this.ayudaAuditivaAAToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // informarDeUnErrorToolStripMenuItem
            // 
            this.informarDeUnErrorToolStripMenuItem.Name = "informarDeUnErrorToolStripMenuItem";
            this.informarDeUnErrorToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.informarDeUnErrorToolStripMenuItem.Text = "Informar de un error";
            this.informarDeUnErrorToolStripMenuItem.Click += new System.EventHandler(this.informarDeUnErrorToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // olvidéMiContraseñaToolStripMenuItem
            // 
            this.olvidéMiContraseñaToolStripMenuItem.Name = "olvidéMiContraseñaToolStripMenuItem";
            this.olvidéMiContraseñaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.olvidéMiContraseñaToolStripMenuItem.Text = "Olvidé mi contraseña";
            this.olvidéMiContraseñaToolStripMenuItem.Click += new System.EventHandler(this.olvidéMiContraseñaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // ayudaAuditivaAAToolStripMenuItem
            // 
            this.ayudaAuditivaAAToolStripMenuItem.Checked = true;
            this.ayudaAuditivaAAToolStripMenuItem.CheckOnClick = true;
            this.ayudaAuditivaAAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ayudaAuditivaAAToolStripMenuItem.Name = "ayudaAuditivaAAToolStripMenuItem";
            this.ayudaAuditivaAAToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ayudaAuditivaAAToolStripMenuItem.Text = "Ayuda Auditiva (AA)";
            this.ayudaAuditivaAAToolStripMenuItem.Click += new System.EventHandler(this.ayudaAuditivaAAToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAA
            // 
            this.btnAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.btnAA.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Sonido;
            this.btnAA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAA.Location = new System.Drawing.Point(351, 0);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(24, 24);
            this.btnAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAA.TabIndex = 11;
            this.btnAA.TabStop = false;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // iniciarSesiónSinConexiónToolStripMenuItem
            // 
            this.iniciarSesiónSinConexiónToolStripMenuItem.Name = "iniciarSesiónSinConexiónToolStripMenuItem";
            this.iniciarSesiónSinConexiónToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.iniciarSesiónSinConexiónToolStripMenuItem.Text = "Iniciar sesión sin conexión";
            this.iniciarSesiónSinConexiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónSinConexiónToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(402, 369);
            this.Controls.Add(this.btnAA);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.GrupoLogin);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.GrupoLogin.ResumeLayout(false);
            this.GrupoLogin.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox GrupoLogin;
        private System.Windows.Forms.LinkLabel lblForgotPass;
        private System.Windows.Forms.Button lbl_IniSesion;
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informarDeUnErrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox chkMostrarPass;
        public System.Windows.Forms.Label lblHora;
        public System.Windows.Forms.Label lblNombreSesion;
        private System.Windows.Forms.PictureBox btnAA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ayudaAuditivaAAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem olvidéMiContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónSinConexiónToolStripMenuItem;
    }
}