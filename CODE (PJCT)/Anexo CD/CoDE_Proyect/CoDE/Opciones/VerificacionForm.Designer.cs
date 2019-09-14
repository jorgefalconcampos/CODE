namespace CoDE_Proyect.CoDE.Opciones
{
    partial class VerificacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificacionForm));
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.GrupoVerificacion = new System.Windows.Forms.GroupBox();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblVerificacion = new System.Windows.Forms.Button();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.GrupoVerificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(27, 68);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(320, 34);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Antes de iniciar, tenemos que verificar que es usted.  \r\nEscriba su contraseña pa" +
    "ra poder continuar.\r\n";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(6, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Verifique su identidad\r\n";
            // 
            // btnVerificar
            // 
            this.btnVerificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnVerificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerificar.Location = new System.Drawing.Point(278, 240);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(73, 38);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "OK";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // GrupoVerificacion
            // 
            this.GrupoVerificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrupoVerificacion.Controls.Add(this.Editar);
            this.GrupoVerificacion.Controls.Add(this.chkMostrarPass);
            this.GrupoVerificacion.Controls.Add(this.txtAdministrador);
            this.GrupoVerificacion.Controls.Add(this.txtPass);
            this.GrupoVerificacion.Controls.Add(this.lblPass);
            this.GrupoVerificacion.Controls.Add(this.lblAdmin);
            this.GrupoVerificacion.Controls.Add(this.lblVerificacion);
            this.GrupoVerificacion.Controls.Add(this.lblSeparador);
            this.GrupoVerificacion.Controls.Add(this.btnVerificar);
            this.GrupoVerificacion.Controls.Add(this.lblTitulo);
            this.GrupoVerificacion.Controls.Add(this.lblTexto);
            this.GrupoVerificacion.Location = new System.Drawing.Point(12, 12);
            this.GrupoVerificacion.Name = "GrupoVerificacion";
            this.GrupoVerificacion.Size = new System.Drawing.Size(374, 288);
            this.GrupoVerificacion.TabIndex = 0;
            this.GrupoVerificacion.TabStop = false;
            // 
            // Editar
            // 
            this.Editar.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Editar;
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.Location = new System.Drawing.Point(319, 133);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(32, 32);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 39;
            this.Editar.TabStop = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarPass.Location = new System.Drawing.Point(223, 211);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(128, 19);
            this.chkMostrarPass.TabIndex = 3;
            this.chkMostrarPass.Text = "Mostrar contraseña";
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.Enabled = false;
            this.txtAdministrador.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdministrador.Location = new System.Drawing.Point(139, 138);
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(177, 27);
            this.txtAdministrador.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(139, 178);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(212, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(23, 181);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(23, 141);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(107, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrador:";
            // 
            // lblVerificacion
            // 
            this.lblVerificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblVerificacion.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lblVerificacion.Enabled = false;
            this.lblVerificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVerificacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblVerificacion.Location = new System.Drawing.Point(1, 7);
            this.lblVerificacion.Name = "lblVerificacion";
            this.lblVerificacion.Size = new System.Drawing.Size(166, 28);
            this.lblVerificacion.TabIndex = 0;
            this.lblVerificacion.Text = "UN ÚLTIMO PASO...";
            this.lblVerificacion.UseVisualStyleBackColor = false;
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeparador.Location = new System.Drawing.Point(17, 102);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(337, 16);
            this.lblSeparador.TabIndex = 0;
            this.lblSeparador.Text = "_______________________________________________";
            // 
            // VerificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 312);
            this.Controls.Add(this.GrupoVerificacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 351);
            this.MinimumSize = new System.Drawing.Size(414, 351);
            this.Name = "VerificacionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificación de identidad";
            this.Load += new System.EventHandler(this.VerificacionEscaneo_Load);
            this.GrupoVerificacion.ResumeLayout(false);
            this.GrupoVerificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox GrupoVerificacion;
        private System.Windows.Forms.Button lblVerificacion;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.CheckBox chkMostrarPass;
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox Editar;
    }
}