namespace CoDE_Proyect.CoDE.Opciones
{
    partial class ConexionConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexionConfig));
            this.GrupoConfig = new System.Windows.Forms.GroupBox();
            this.btnProbar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.PictureBox();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.PictureBox();
            this.lblConfig = new System.Windows.Forms.Button();
            this.txtBDD = new System.Windows.Forms.TextBox();
            this.lblBDD = new System.Windows.Forms.Label();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnVerActuales = new System.Windows.Forms.Button();
            this.GrupoConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoConfig
            // 
            this.GrupoConfig.Controls.Add(this.btnProbar);
            this.GrupoConfig.Controls.Add(this.Editar);
            this.GrupoConfig.Controls.Add(this.cboServer);
            this.GrupoConfig.Controls.Add(this.lblServidor);
            this.GrupoConfig.Controls.Add(this.btnGuardar);
            this.GrupoConfig.Controls.Add(this.Info);
            this.GrupoConfig.Controls.Add(this.lblConfig);
            this.GrupoConfig.Controls.Add(this.txtBDD);
            this.GrupoConfig.Controls.Add(this.lblBDD);
            this.GrupoConfig.Controls.Add(this.lblSeparador);
            this.GrupoConfig.Controls.Add(this.lblInfo);
            this.GrupoConfig.Location = new System.Drawing.Point(12, 12);
            this.GrupoConfig.Name = "GrupoConfig";
            this.GrupoConfig.Size = new System.Drawing.Size(363, 296);
            this.GrupoConfig.TabIndex = 2;
            this.GrupoConfig.TabStop = false;
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnProbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProbar.Location = new System.Drawing.Point(119, 253);
            this.btnProbar.Margin = new System.Windows.Forms.Padding(1);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(131, 30);
            this.btnProbar.TabIndex = 42;
            this.btnProbar.Text = "PROBAR CONEXIÓN";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // Editar
            // 
            this.Editar.BackgroundImage = global::CoDE_Proyect.Properties.Resources.Editar;
            this.Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.Location = new System.Drawing.Point(308, 185);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(28, 28);
            this.Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editar.TabIndex = 41;
            this.Editar.TabStop = false;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // cboServer
            // 
            this.cboServer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(111, 146);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(225, 25);
            this.cboServer.TabIndex = 21;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(25, 151);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(53, 15);
            this.lblServidor.TabIndex = 20;
            this.lblServidor.Text = "Servidor:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(252, 253);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(98, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Info
            // 
            this.Info.BackgroundImage = global::CoDE_Proyect.Properties.Resources.IconoInfo1;
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Info.Location = new System.Drawing.Point(335, 13);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(22, 22);
            this.Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Info.TabIndex = 19;
            this.Info.TabStop = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // lblConfig
            // 
            this.lblConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblConfig.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lblConfig.Enabled = false;
            this.lblConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfig.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfig.Location = new System.Drawing.Point(1, 7);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(230, 28);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "CONFIGURACIÓN DE CONEXIÓN";
            this.lblConfig.UseVisualStyleBackColor = false;
            // 
            // txtBDD
            // 
            this.txtBDD.Enabled = false;
            this.txtBDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBDD.Location = new System.Drawing.Point(113, 190);
            this.txtBDD.Name = "txtBDD";
            this.txtBDD.Size = new System.Drawing.Size(189, 23);
            this.txtBDD.TabIndex = 1;
            this.txtBDD.Text = "CODE";
            // 
            // lblBDD
            // 
            this.lblBDD.AutoSize = true;
            this.lblBDD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDD.Location = new System.Drawing.Point(25, 193);
            this.lblBDD.Name = "lblBDD";
            this.lblBDD.Size = new System.Drawing.Size(82, 15);
            this.lblBDD.TabIndex = 0;
            this.lblBDD.Text = "Base de datos:";
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.BackColor = System.Drawing.Color.Transparent;
            this.lblSeparador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeparador.Location = new System.Drawing.Point(13, 108);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(337, 16);
            this.lblSeparador.TabIndex = 0;
            this.lblSeparador.Text = "_______________________________________________";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 48);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(346, 69);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnVerActuales
            // 
            this.btnVerActuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnVerActuales.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerActuales.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVerActuales.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerActuales.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerActuales.Location = new System.Drawing.Point(13, 311);
            this.btnVerActuales.Name = "btnVerActuales";
            this.btnVerActuales.Size = new System.Drawing.Size(154, 20);
            this.btnVerActuales.TabIndex = 43;
            this.btnVerActuales.Text = "+ Mostrar valores actuales";
            this.btnVerActuales.UseVisualStyleBackColor = false;
            this.btnVerActuales.Click += new System.EventHandler(this.btnVerActuales_Click);
            // 
            // ConexionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(387, 336);
            this.Controls.Add(this.btnVerActuales);
            this.Controls.Add(this.GrupoConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConexionConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de coexión";
            this.Load += new System.EventHandler(this.ConexionConfig_Load);
            this.GrupoConfig.ResumeLayout(false);
            this.GrupoConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoConfig;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox Info;
        private System.Windows.Forms.Button lblConfig;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtBDD;
        private System.Windows.Forms.Label lblBDD;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.PictureBox Editar;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnVerActuales;
    }
}