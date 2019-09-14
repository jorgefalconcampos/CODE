namespace CoDE_Proyect.CoDE.Opciones
{
    partial class CambiarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPass));
            this.GrupoLogin = new System.Windows.Forms.GroupBox();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblRepPass = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Button();
            this.lblRazon = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.GrupoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoLogin
            // 
            this.GrupoLogin.Controls.Add(this.Editar);
            this.GrupoLogin.Controls.Add(this.txtRepPass);
            this.GrupoLogin.Controls.Add(this.lblRepPass);
            this.GrupoLogin.Controls.Add(this.txtUsuario);
            this.GrupoLogin.Controls.Add(this.txtPass);
            this.GrupoLogin.Controls.Add(this.lblPass);
            this.GrupoLogin.Controls.Add(this.lblUsuario);
            this.GrupoLogin.Controls.Add(this.chkMostrarPass);
            this.GrupoLogin.Controls.Add(this.lblTexto);
            this.GrupoLogin.Controls.Add(this.lblDesc);
            this.GrupoLogin.Controls.Add(this.btnOK);
            this.GrupoLogin.Controls.Add(this.lblSeparador);
            this.GrupoLogin.Controls.Add(this.lbl_Pass);
            this.GrupoLogin.Controls.Add(this.lblRazon);
            this.GrupoLogin.Location = new System.Drawing.Point(12, 12);
            this.GrupoLogin.Name = "GrupoLogin";
            this.GrupoLogin.Size = new System.Drawing.Size(506, 337);
            this.GrupoLogin.TabIndex = 1;
            this.GrupoLogin.TabStop = false;
            // 
            // Editar
            // 
            this.Editar.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Editar;
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.Location = new System.Drawing.Point(384, 156);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(32, 32);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 42;
            this.Editar.TabStop = false;
            this.Editar.Visible = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // txtRepPass
            // 
            this.txtRepPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepPass.Location = new System.Drawing.Point(222, 231);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.Size = new System.Drawing.Size(194, 25);
            this.txtRepPass.TabIndex = 3;
            this.txtRepPass.UseSystemPasswordChar = true;
            this.txtRepPass.Visible = false;
            // 
            // lblRepPass
            // 
            this.lblRepPass.AutoSize = true;
            this.lblRepPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPass.Location = new System.Drawing.Point(78, 232);
            this.lblRepPass.Name = "lblRepPass";
            this.lblRepPass.Size = new System.Drawing.Size(138, 20);
            this.lblRepPass.TabIndex = 0;
            this.lblRepPass.Text = "Repetir Contraseña:";
            this.lblRepPass.Visible = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(220, 163);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 25);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(222, 197);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(194, 25);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(84, 198);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(132, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Nueva Contraseña:";
            this.lblPass.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(74, 164);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(140, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Nombre de usuario:";
            this.lblUsuario.Visible = false;
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarPass.Location = new System.Drawing.Point(288, 262);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(128, 19);
            this.chkMostrarPass.TabIndex = 4;
            this.chkMostrarPass.Text = "Mostrar contraseña";
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            this.chkMostrarPass.Visible = false;
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(19, 74);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(471, 51);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = resources.GetString("lblTexto.Text");
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(6, 47);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(182, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Modifique su contraseña";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Location = new System.Drawing.Point(421, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(73, 38);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeparador.Location = new System.Drawing.Point(21, 124);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(456, 16);
            this.lblSeparador.TabIndex = 0;
            this.lblSeparador.Text = "________________________________________________________________";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Pass.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lbl_Pass.Enabled = false;
            this.lbl_Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Pass.Location = new System.Drawing.Point(1, 7);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(187, 28);
            this.lbl_Pass.TabIndex = 0;
            this.lbl_Pass.Text = "CAMBIAR PASSWORD";
            this.lbl_Pass.UseVisualStyleBackColor = false;
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRazon.Location = new System.Drawing.Point(7, 312);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(39, 15);
            this.lblRazon.TabIndex = 0;
            this.lblRazon.Text = "Razon";
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNueva.Location = new System.Drawing.Point(137, 202);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(257, 45);
            this.btnNueva.TabIndex = 1;
            this.btnNueva.Text = "SOLICITAR NUEVA CONTRASEÑA";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // CambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 361);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.GrupoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CambiarPass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.CambiarPass_Load);
            this.GrupoLogin.ResumeLayout(false);
            this.GrupoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoLogin;
        private System.Windows.Forms.Button lbl_Pass;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.CheckBox chkMostrarPass;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblRepPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox Editar;
    }
}