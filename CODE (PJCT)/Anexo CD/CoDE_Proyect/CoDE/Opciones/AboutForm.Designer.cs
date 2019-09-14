namespace CoDE_Proyect.CoDE.Opciones
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblVer = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.GrupoInfoProd = new System.Windows.Forms.GroupBox();
            this.lblPagina = new System.Windows.Forms.LinkLabel();
            this.ImgCopiarPP = new System.Windows.Forms.PictureBox();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.lblCoDE = new System.Windows.Forms.Label();
            this.btnEntendido = new System.Windows.Forms.Button();
            this.btnSugerir = new System.Windows.Forms.Button();
            this.GrupoInfoProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCopiarPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.Location = new System.Drawing.Point(223, 44);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(45, 15);
            this.lblVer.TabIndex = 0;
            this.lblVer.Text = "Versión";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(203, 21);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Información del producto:";
            // 
            // GrupoInfoProd
            // 
            this.GrupoInfoProd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrupoInfoProd.Controls.Add(this.lblPagina);
            this.GrupoInfoProd.Controls.Add(this.ImgCopiarPP);
            this.GrupoInfoProd.Controls.Add(this.ImgLogo);
            this.GrupoInfoProd.Controls.Add(this.lblVer);
            this.GrupoInfoProd.Controls.Add(this.lblCoDE);
            this.GrupoInfoProd.Location = new System.Drawing.Point(12, 45);
            this.GrupoInfoProd.Name = "GrupoInfoProd";
            this.GrupoInfoProd.Size = new System.Drawing.Size(422, 169);
            this.GrupoInfoProd.TabIndex = 1;
            this.GrupoInfoProd.TabStop = false;
            // 
            // lblPagina
            // 
            this.lblPagina.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lblPagina.AutoSize = true;
            this.lblPagina.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagina.ForeColor = System.Drawing.Color.White;
            this.lblPagina.LinkColor = System.Drawing.Color.Black;
            this.lblPagina.Location = new System.Drawing.Point(10, 145);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(144, 13);
            this.lblPagina.TabIndex = 1;
            this.lblPagina.TabStop = true;
            this.lblPagina.Text = "Visite nuestra página web.";
            this.lblPagina.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPagina_LinkClicked);
            // 
            // ImgCopiarPP
            // 
            this.ImgCopiarPP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgCopiarPP.Image = global::CoDE_Proyect.Properties.Resources.CopiarPortapapeles;
            this.ImgCopiarPP.Location = new System.Drawing.Point(380, 128);
            this.ImgCopiarPP.Name = "ImgCopiarPP";
            this.ImgCopiarPP.Size = new System.Drawing.Size(30, 30);
            this.ImgCopiarPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCopiarPP.TabIndex = 6;
            this.ImgCopiarPP.TabStop = false;
            this.ImgCopiarPP.Tag = "Copiar datos al portapapeles";
            this.ImgCopiarPP.Click += new System.EventHandler(this.ImgCopiarPP_Click);
            // 
            // ImgLogo
            // 
            this.ImgLogo.Image = global::CoDE_Proyect.Properties.Resources.LogoSimple;
            this.ImgLogo.Location = new System.Drawing.Point(13, 21);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(169, 95);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgLogo.TabIndex = 6;
            this.ImgLogo.TabStop = false;
            // 
            // lblCoDE
            // 
            this.lblCoDE.AutoSize = true;
            this.lblCoDE.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoDE.Location = new System.Drawing.Point(201, 21);
            this.lblCoDE.Name = "lblCoDE";
            this.lblCoDE.Size = new System.Drawing.Size(215, 20);
            this.lblCoDE.TabIndex = 0;
            this.lblCoDE.Text = "CoDE - Control De Estudiantes";
            // 
            // btnEntendido
            // 
            this.btnEntendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnEntendido.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEntendido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntendido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEntendido.Location = new System.Drawing.Point(240, 229);
            this.btnEntendido.Name = "btnEntendido";
            this.btnEntendido.Size = new System.Drawing.Size(159, 40);
            this.btnEntendido.TabIndex = 3;
            this.btnEntendido.Text = "ENTENDIDO";
            this.btnEntendido.UseVisualStyleBackColor = false;
            this.btnEntendido.Click += new System.EventHandler(this.btnEntendido_Click);
            // 
            // btnSugerir
            // 
            this.btnSugerir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnSugerir.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSugerir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSugerir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSugerir.Location = new System.Drawing.Point(48, 229);
            this.btnSugerir.Name = "btnSugerir";
            this.btnSugerir.Size = new System.Drawing.Size(159, 40);
            this.btnSugerir.TabIndex = 2;
            this.btnSugerir.Text = "SUGERIR CAMBIOS";
            this.btnSugerir.UseVisualStyleBackColor = false;
            this.btnSugerir.Click += new System.EventHandler(this.btnSugerir_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(446, 286);
            this.Controls.Add(this.btnSugerir);
            this.Controls.Add(this.btnEntendido);
            this.Controls.Add(this.GrupoInfoProd);
            this.Controls.Add(this.lblInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de...";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.GrupoInfoProd.ResumeLayout(false);
            this.GrupoInfoProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCopiarPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox GrupoInfoProd;
        private System.Windows.Forms.Label lblCoDE;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.LinkLabel lblPagina;
        private System.Windows.Forms.PictureBox ImgCopiarPP;
        private System.Windows.Forms.Button btnEntendido;
        private System.Windows.Forms.Button btnSugerir;
    }
}