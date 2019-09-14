namespace Escaneo
{
    partial class ElegirLectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElegirLectorForm));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkEscan2 = new System.Windows.Forms.CheckBox();
            this.chkEscan1 = new System.Windows.Forms.CheckBox();
            this.GrupoSeleccion = new System.Windows.Forms.GroupBox();
            this.SeleccionConfig = new System.Windows.Forms.TabControl();
            this.Pagina1 = new System.Windows.Forms.TabPage();
            this.GrupoLista = new System.Windows.Forms.GroupBox();
            this.clbListaEscaner = new System.Windows.Forms.CheckedListBox();
            this.Pagina2 = new System.Windows.Forms.TabPage();
            this.GrupoPag2 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtNombreBDD = new System.Windows.Forms.TextBox();
            this.txtUsuariosBDD = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Button();
            this.lblSeparador = new System.Windows.Forms.Label();
            this.GrupoSeleccion.SuspendLayout();
            this.SeleccionConfig.SuspendLayout();
            this.Pagina1.SuspendLayout();
            this.GrupoLista.SuspendLayout();
            this.Pagina2.SuspendLayout();
            this.GrupoPag2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(6, 43);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(390, 64);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Location = new System.Drawing.Point(222, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 30);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(308, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkEscan2
            // 
            this.chkEscan2.AutoSize = true;
            this.chkEscan2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEscan2.Location = new System.Drawing.Point(129, 127);
            this.chkEscan2.Name = "chkEscan2";
            this.chkEscan2.Size = new System.Drawing.Size(125, 19);
            this.chkEscan2.TabIndex = 2;
            this.chkEscan2.Text = "NEUROtechnology";
            this.chkEscan2.UseVisualStyleBackColor = true;
            this.chkEscan2.CheckedChanged += new System.EventHandler(this.chkEscan2_CheckedChanged);
            // 
            // chkEscan1
            // 
            this.chkEscan1.AutoSize = true;
            this.chkEscan1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEscan1.Location = new System.Drawing.Point(17, 127);
            this.chkEscan1.Name = "chkEscan1";
            this.chkEscan1.Size = new System.Drawing.Size(100, 19);
            this.chkEscan1.TabIndex = 1;
            this.chkEscan1.Text = "CODE Proyect";
            this.chkEscan1.UseVisualStyleBackColor = true;
            this.chkEscan1.CheckedChanged += new System.EventHandler(this.chkEscan1_CheckedChanged);
            // 
            // GrupoSeleccion
            // 
            this.GrupoSeleccion.Controls.Add(this.SeleccionConfig);
            this.GrupoSeleccion.Controls.Add(this.btnCancel);
            this.GrupoSeleccion.Controls.Add(this.btnOK);
            this.GrupoSeleccion.Controls.Add(this.lblSeleccion);
            this.GrupoSeleccion.Controls.Add(this.chkEscan2);
            this.GrupoSeleccion.Controls.Add(this.chkEscan1);
            this.GrupoSeleccion.Controls.Add(this.lblSeparador);
            this.GrupoSeleccion.Controls.Add(this.lblInfo);
            this.GrupoSeleccion.Location = new System.Drawing.Point(12, 12);
            this.GrupoSeleccion.Name = "GrupoSeleccion";
            this.GrupoSeleccion.Size = new System.Drawing.Size(400, 462);
            this.GrupoSeleccion.TabIndex = 0;
            this.GrupoSeleccion.TabStop = false;
            // 
            // SeleccionConfig
            // 
            this.SeleccionConfig.Controls.Add(this.Pagina1);
            this.SeleccionConfig.Controls.Add(this.Pagina2);
            this.SeleccionConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionConfig.ItemSize = new System.Drawing.Size(52, 18);
            this.SeleccionConfig.Location = new System.Drawing.Point(6, 171);
            this.SeleccionConfig.Name = "SeleccionConfig";
            this.SeleccionConfig.SelectedIndex = 0;
            this.SeleccionConfig.Size = new System.Drawing.Size(386, 240);
            this.SeleccionConfig.TabIndex = 3;
            this.SeleccionConfig.SelectedIndexChanged += new System.EventHandler(this.SeleccionConfig_SelectedIndexChanged);
            // 
            // Pagina1
            // 
            this.Pagina1.Controls.Add(this.GrupoLista);
            this.Pagina1.Location = new System.Drawing.Point(4, 22);
            this.Pagina1.Name = "Pagina1";
            this.Pagina1.Padding = new System.Windows.Forms.Padding(3);
            this.Pagina1.Size = new System.Drawing.Size(378, 214);
            this.Pagina1.TabIndex = 0;
            this.Pagina1.Text = "Selección de lector";
            this.Pagina1.UseVisualStyleBackColor = true;
            // 
            // GrupoLista
            // 
            this.GrupoLista.Controls.Add(this.clbListaEscaner);
            this.GrupoLista.Enabled = false;
            this.GrupoLista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.GrupoLista.Location = new System.Drawing.Point(6, 16);
            this.GrupoLista.Name = "GrupoLista";
            this.GrupoLista.Size = new System.Drawing.Size(366, 181);
            this.GrupoLista.TabIndex = 0;
            this.GrupoLista.TabStop = false;
            this.GrupoLista.Text = " Seleccione un escáner ";
            // 
            // clbListaEscaner
            // 
            this.clbListaEscaner.CheckOnClick = true;
            this.clbListaEscaner.Enabled = false;
            this.clbListaEscaner.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbListaEscaner.Location = new System.Drawing.Point(6, 22);
            this.clbListaEscaner.Name = "clbListaEscaner";
            this.clbListaEscaner.Size = new System.Drawing.Size(354, 140);
            this.clbListaEscaner.TabIndex = 0;
            // 
            // Pagina2
            // 
            this.Pagina2.Controls.Add(this.GrupoPag2);
            this.Pagina2.Location = new System.Drawing.Point(4, 22);
            this.Pagina2.Name = "Pagina2";
            this.Pagina2.Padding = new System.Windows.Forms.Padding(3);
            this.Pagina2.Size = new System.Drawing.Size(378, 214);
            this.Pagina2.TabIndex = 1;
            this.Pagina2.Text = "Configuración";
            this.Pagina2.UseVisualStyleBackColor = true;
            // 
            // GrupoPag2
            // 
            this.GrupoPag2.Controls.Add(this.lbl1);
            this.GrupoPag2.Controls.Add(this.txtNombreBDD);
            this.GrupoPag2.Controls.Add(this.txtUsuariosBDD);
            this.GrupoPag2.Controls.Add(this.lbl3);
            this.GrupoPag2.Controls.Add(this.txtPassword);
            this.GrupoPag2.Controls.Add(this.lbl2);
            this.GrupoPag2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoPag2.Location = new System.Drawing.Point(6, 16);
            this.GrupoPag2.Name = "GrupoPag2";
            this.GrupoPag2.Size = new System.Drawing.Size(366, 181);
            this.GrupoPag2.TabIndex = 21;
            this.GrupoPag2.TabStop = false;
            this.GrupoPag2.Text = " Configuración adicional ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl1.Location = new System.Drawing.Point(6, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 15);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Base de Datos de los lectores:";
            // 
            // txtNombreBDD
            // 
            this.txtNombreBDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreBDD.Location = new System.Drawing.Point(171, 42);
            this.txtNombreBDD.Name = "txtNombreBDD";
            this.txtNombreBDD.Size = new System.Drawing.Size(187, 23);
            this.txtNombreBDD.TabIndex = 3;
            this.txtNombreBDD.Text = "FingerprintDB.CSharpSample.dat";
            // 
            // txtUsuariosBDD
            // 
            this.txtUsuariosBDD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuariosBDD.Location = new System.Drawing.Point(169, 122);
            this.txtUsuariosBDD.Name = "txtUsuariosBDD";
            this.txtUsuariosBDD.Size = new System.Drawing.Size(189, 23);
            this.txtUsuariosBDD.TabIndex = 7;
            this.txtUsuariosBDD.Text = "CODE_Proyect_TempDB.xml";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl3.Location = new System.Drawing.Point(6, 125);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(141, 15);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Base de Datos (recientes):";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(169, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl2.Location = new System.Drawing.Point(6, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 15);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Contraseña:";
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblSeleccion.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lblSeleccion.Enabled = false;
            this.lblSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSeleccion.Location = new System.Drawing.Point(1, 7);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(167, 28);
            this.lblSeleccion.TabIndex = 0;
            this.lblSeleccion.Text = "SELECCIONAR LECTOR";
            this.lblSeleccion.UseVisualStyleBackColor = false;
            // 
            // lblSeparador
            // 
            this.lblSeparador.AutoSize = true;
            this.lblSeparador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeparador.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSeparador.Location = new System.Drawing.Point(13, 91);
            this.lblSeparador.Name = "lblSeparador";
            this.lblSeparador.Size = new System.Drawing.Size(372, 16);
            this.lblSeparador.TabIndex = 0;
            this.lblSeparador.Text = "____________________________________________________";
            // 
            // ElegirLectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 486);
            this.Controls.Add(this.GrupoSeleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirLectorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione un lector";
            this.Load += new System.EventHandler(this.ChooseScannerForm_Load);
            this.GrupoSeleccion.ResumeLayout(false);
            this.GrupoSeleccion.PerformLayout();
            this.SeleccionConfig.ResumeLayout(false);
            this.Pagina1.ResumeLayout(false);
            this.GrupoLista.ResumeLayout(false);
            this.Pagina2.ResumeLayout(false);
            this.GrupoPag2.ResumeLayout(false);
            this.GrupoPag2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkEscan2;
        private System.Windows.Forms.CheckBox chkEscan1;
        private System.Windows.Forms.GroupBox GrupoSeleccion;
        private System.Windows.Forms.Button lblSeleccion;
        private System.Windows.Forms.Label lblSeparador;
        private System.Windows.Forms.TabControl SeleccionConfig;
        private System.Windows.Forms.TabPage Pagina1;
        private System.Windows.Forms.GroupBox GrupoLista;
        private System.Windows.Forms.CheckedListBox clbListaEscaner;
        private System.Windows.Forms.TabPage Pagina2;
        private System.Windows.Forms.GroupBox GrupoPag2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtNombreBDD;
        private System.Windows.Forms.TextBox txtUsuariosBDD;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbl2;
    }
}