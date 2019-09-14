namespace CoDE_Proyect.CoDE.Empleados
{
    partial class EmpleadosAgregarVideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosAgregarVideoForm));
            this.btnDetener = new System.Windows.Forms.Button();
            this.cboDispositivos = new System.Windows.Forms.ComboBox();
            this.ImgCamara = new System.Windows.Forms.PictureBox();
            this.btnTomarFoto = new System.Windows.Forms.Button();
            this.ImagenLive = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLive)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetener.Location = new System.Drawing.Point(115, 49);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(94, 45);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // cboDispositivos
            // 
            this.cboDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDispositivos.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cboDispositivos.FormattingEnabled = true;
            this.cboDispositivos.Items.AddRange(new object[] {
            "No se detectó ninguna cámara."});
            this.cboDispositivos.Location = new System.Drawing.Point(12, 18);
            this.cboDispositivos.Name = "cboDispositivos";
            this.cboDispositivos.Size = new System.Drawing.Size(197, 25);
            this.cboDispositivos.TabIndex = 0;
            this.cboDispositivos.SelectedIndexChanged += new System.EventHandler(this.cboDispositivos_SelectedIndexChanged);
            // 
            // ImgCamara
            // 
            this.ImgCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ImgCamara.BackgroundImage = global::CoDE_Proyect.Properties.Resources.TomarFoto;
            this.ImgCamara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgCamara.Enabled = false;
            this.ImgCamara.Location = new System.Drawing.Point(226, 31);
            this.ImgCamara.Name = "ImgCamara";
            this.ImgCamara.Size = new System.Drawing.Size(45, 45);
            this.ImgCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgCamara.TabIndex = 12;
            this.ImgCamara.TabStop = false;
            // 
            // btnTomarFoto
            // 
            this.btnTomarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnTomarFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTomarFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomarFoto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTomarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTomarFoto.Location = new System.Drawing.Point(215, 18);
            this.btnTomarFoto.Name = "btnTomarFoto";
            this.btnTomarFoto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTomarFoto.Size = new System.Drawing.Size(171, 76);
            this.btnTomarFoto.TabIndex = 3;
            this.btnTomarFoto.Text = "        \r\n             TOMAR FOTO\r\n\r\n";
            this.btnTomarFoto.UseVisualStyleBackColor = false;
            this.btnTomarFoto.Click += new System.EventHandler(this.btnTomarFoto_Click);
            // 
            // ImagenLive
            // 
            this.ImagenLive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenLive.Location = new System.Drawing.Point(12, 107);
            this.ImagenLive.Name = "ImagenLive";
            this.ImagenLive.Size = new System.Drawing.Size(374, 240);
            this.ImagenLive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenLive.TabIndex = 9;
            this.ImagenLive.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIniciar.Location = new System.Drawing.Point(12, 49);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(94, 45);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // EmpleadosAgregarVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 359);
            this.Controls.Add(this.ImgCamara);
            this.Controls.Add(this.btnTomarFoto);
            this.Controls.Add(this.cboDispositivos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.ImagenLive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmpleadosAgregarVideoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Foto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmpleadosAgregarVideoForm_FormClosing);
            this.Load += new System.EventHandler(this.EmpleadosAgregarVideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.ComboBox cboDispositivos;
        private System.Windows.Forms.Button btnTomarFoto;
        private System.Windows.Forms.PictureBox ImgCamara;
        public System.Windows.Forms.PictureBox ImagenLive;
        private System.Windows.Forms.Button btnIniciar;
    }
}