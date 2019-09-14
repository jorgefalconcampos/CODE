namespace CoDE_Proyect.CoDE.Alumnos
{
    partial class AlumnosConsultarPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosConsultarPreview));
            this.btnOK = new System.Windows.Forms.Button();
            this.ImgHuellaPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgHuellaPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Location = new System.Drawing.Point(77, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(160, 40);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ImgHuellaPreview
            // 
            this.ImgHuellaPreview.BackColor = System.Drawing.Color.Transparent;
            this.ImgHuellaPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgHuellaPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgHuellaPreview.Enabled = false;
            this.ImgHuellaPreview.Location = new System.Drawing.Point(12, 12);
            this.ImgHuellaPreview.Name = "ImgHuellaPreview";
            this.ImgHuellaPreview.Size = new System.Drawing.Size(290, 280);
            this.ImgHuellaPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgHuellaPreview.TabIndex = 33;
            this.ImgHuellaPreview.TabStop = false;
            // 
            // AlumnosConsultarPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 354);
            this.Controls.Add(this.ImgHuellaPreview);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlumnosConsultarPreview";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huella";
            this.Load += new System.EventHandler(this.AlumHuellaPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgHuellaPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.PictureBox ImgHuellaPreview;
    }
}