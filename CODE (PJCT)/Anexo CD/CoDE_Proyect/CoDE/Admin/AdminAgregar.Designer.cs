namespace CoDE_Proyect.CoDE.Admin
{
    partial class AdminAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAgregar));
            this.GrupoLogin = new System.Windows.Forms.GroupBox();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNuevoAdmin = new System.Windows.Forms.Button();
            this.txtAmin = new System.Windows.Forms.TextBox();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblRepPass = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.GrupoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoLogin
            // 
            this.GrupoLogin.Controls.Add(this.chkMostrarPass);
            this.GrupoLogin.Controls.Add(this.PictureBox1);
            this.GrupoLogin.Controls.Add(this.lblNuevoAdmin);
            this.GrupoLogin.Controls.Add(this.txtAmin);
            this.GrupoLogin.Controls.Add(this.txtRepPass);
            this.GrupoLogin.Controls.Add(this.txtPass);
            this.GrupoLogin.Controls.Add(this.lblRepPass);
            this.GrupoLogin.Controls.Add(this.lblPass);
            this.GrupoLogin.Controls.Add(this.lblAdministrador);
            this.GrupoLogin.Location = new System.Drawing.Point(12, 12);
            this.GrupoLogin.Name = "GrupoLogin";
            this.GrupoLogin.Size = new System.Drawing.Size(530, 229);
            this.GrupoLogin.TabIndex = 0;
            this.GrupoLogin.TabStop = false;
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarPass.Location = new System.Drawing.Point(246, 192);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(128, 19);
            this.chkMostrarPass.TabIndex = 4;
            this.chkMostrarPass.Text = "Mostrar contraseña";
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Admin;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Enabled = false;
            this.PictureBox1.Location = new System.Drawing.Point(387, 59);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(130, 130);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 14;
            this.PictureBox1.TabStop = false;
            // 
            // lblNuevoAdmin
            // 
            this.lblNuevoAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblNuevoAdmin.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lblNuevoAdmin.Enabled = false;
            this.lblNuevoAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNuevoAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNuevoAdmin.Location = new System.Drawing.Point(1, 7);
            this.lblNuevoAdmin.Name = "lblNuevoAdmin";
            this.lblNuevoAdmin.Size = new System.Drawing.Size(181, 28);
            this.lblNuevoAdmin.TabIndex = 0;
            this.lblNuevoAdmin.Text = "NUEVO ADMINISTRADOR";
            this.lblNuevoAdmin.UseVisualStyleBackColor = false;
            // 
            // txtAmin
            // 
            this.txtAmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmin.Location = new System.Drawing.Point(160, 64);
            this.txtAmin.Name = "txtAmin";
            this.txtAmin.Size = new System.Drawing.Size(212, 25);
            this.txtAmin.TabIndex = 1;
            // 
            // txtRepPass
            // 
            this.txtRepPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepPass.Location = new System.Drawing.Point(160, 158);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.Size = new System.Drawing.Size(212, 25);
            this.txtRepPass.TabIndex = 3;
            this.txtRepPass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(160, 108);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 25);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblRepPass
            // 
            this.lblRepPass.AutoSize = true;
            this.lblRepPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepPass.Location = new System.Drawing.Point(16, 159);
            this.lblRepPass.Name = "lblRepPass";
            this.lblRepPass.Size = new System.Drawing.Size(138, 20);
            this.lblRepPass.TabIndex = 0;
            this.lblRepPass.Text = "Repetir Contraseña:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(16, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(16, 65);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(107, 20);
            this.lblAdministrador.TabIndex = 0;
            this.lblAdministrador.Text = "Administrador:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrar.Location = new System.Drawing.Point(85, 255);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Location = new System.Drawing.Point(221, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 40);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAñadir.Location = new System.Drawing.Point(357, 255);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(110, 40);
            this.btnAñadir.TabIndex = 7;
            this.btnAñadir.Text = "AÑADIR";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // AdminAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 306);
            this.Controls.Add(this.GrupoLogin);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAñadir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir nuevo administrador";
            this.GrupoLogin.ResumeLayout(false);
            this.GrupoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoLogin;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button lblNuevoAdmin;
        private System.Windows.Forms.TextBox txtAmin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblRepPass;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.CheckBox chkMostrarPass;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}