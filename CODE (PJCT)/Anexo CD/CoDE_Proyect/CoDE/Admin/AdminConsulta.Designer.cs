namespace CoDE_Proyect.CoDE.Admin
{
    partial class AdminConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminConsulta));
            this.GrupoConsAdmin = new System.Windows.Forms.GroupBox();
            this.lblConsAdmin = new System.Windows.Forms.Button();
            this.txtAdminConsultar = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.VisorGV = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.GrupoConsAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoConsAdmin
            // 
            this.GrupoConsAdmin.Controls.Add(this.lblConsAdmin);
            this.GrupoConsAdmin.Controls.Add(this.txtAdminConsultar);
            this.GrupoConsAdmin.Controls.Add(this.lblAdmin);
            this.GrupoConsAdmin.Controls.Add(this.lblEncontrado);
            this.GrupoConsAdmin.Controls.Add(this.btnEliminar);
            this.GrupoConsAdmin.Controls.Add(this.VisorGV);
            this.GrupoConsAdmin.Location = new System.Drawing.Point(12, 12);
            this.GrupoConsAdmin.Name = "GrupoConsAdmin";
            this.GrupoConsAdmin.Size = new System.Drawing.Size(530, 228);
            this.GrupoConsAdmin.TabIndex = 1;
            this.GrupoConsAdmin.TabStop = false;
            // 
            // lblConsAdmin
            // 
            this.lblConsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            this.lblConsAdmin.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.lblConsAdmin.Enabled = false;
            this.lblConsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConsAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConsAdmin.Location = new System.Drawing.Point(1, 7);
            this.lblConsAdmin.Name = "lblConsAdmin";
            this.lblConsAdmin.Size = new System.Drawing.Size(208, 28);
            this.lblConsAdmin.TabIndex = 0;
            this.lblConsAdmin.Text = "CONSULTAR ADMINISTRADOR";
            this.lblConsAdmin.UseVisualStyleBackColor = false;
            // 
            // txtAdminConsultar
            // 
            this.txtAdminConsultar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminConsultar.Location = new System.Drawing.Point(160, 64);
            this.txtAdminConsultar.Name = "txtAdminConsultar";
            this.txtAdminConsultar.Size = new System.Drawing.Size(212, 25);
            this.txtAdminConsultar.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(16, 65);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(107, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Administrador:";
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.AutoSize = true;
            this.lblEncontrado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncontrado.Location = new System.Drawing.Point(54, 109);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(219, 20);
            this.lblEncontrado.TabIndex = 0;
            this.lblEncontrado.Text = "ESTADO DEL ADMINISTRADOR";
            this.lblEncontrado.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.Location = new System.Drawing.Point(395, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // VisorGV
            // 
            this.VisorGV.AllowUserToAddRows = false;
            this.VisorGV.AllowUserToDeleteRows = false;
            this.VisorGV.AllowUserToOrderColumns = true;
            this.VisorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VisorGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VisorGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(136)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisorGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.VisorGV.Location = new System.Drawing.Point(20, 138);
            this.VisorGV.Name = "VisorGV";
            this.VisorGV.ReadOnly = true;
            this.VisorGV.Size = new System.Drawing.Size(352, 60);
            this.VisorGV.TabIndex = 35;
            this.VisorGV.Visible = false;
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
            this.btnCerrar.TabIndex = 1;
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
            this.btnLimpiar.TabIndex = 2;
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
            this.btnBuscar.Location = new System.Drawing.Point(357, 255);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 40);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // AdminConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(554, 306);
            this.Controls.Add(this.GrupoConsAdmin);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminConsulta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Administrador";
            this.Load += new System.EventHandler(this.AdminConsulta_Load);
            this.GrupoConsAdmin.ResumeLayout(false);
            this.GrupoConsAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VisorGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrupoConsAdmin;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button lblConsAdmin;
        private System.Windows.Forms.TextBox txtAdminConsultar;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.DataGridView VisorGV;
    }
}