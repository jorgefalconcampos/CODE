using System;
using System.Text;
using System.Windows.Forms;
using Neurotec.Biometrics;

namespace Escaneo
{
    public partial class ElegirLectorForm : Form
    {
        private string EscaneresCODE = string.Empty;
        private string EscaneresNEURO = string.Empty;
        private string Escaner = string.Empty;
        string ValorSeleccion = string.Empty;

        public ElegirLectorForm()
        { InitializeComponent(); }

        private void ChooseScannerForm_Load(object sender, EventArgs e)
        { clbListaEscaner.Items.Add("Seleccione uno de los proveedores de lector de huella."); }

        private void chkEscan1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEscan1.Checked == true)
            {
                EscaneresCODE = "UareU";
                ValorSeleccion = "OK";
                chkEscan2.Checked = false;
                GrupoLista.Enabled = true;
                clbListaEscaner.Enabled = true;

                if (EscaneresCODE.Length > 0)
                {
                    string[] TodosModulos = EscaneresCODE.Split(new char[] { ';' });
                    clbListaEscaner.Items.Clear();
                    clbListaEscaner.Items.AddRange(TodosModulos);
                }
                else
                {
                    clbListaEscaner.Items.Add("No se encontraron módulos de escáner de CODE.");
                    clbListaEscaner.Enabled = false; ValorSeleccion = string.Empty;
                }
            }
            else { GrupoLista.Enabled = false; clbListaEscaner.Items.Clear(); clbListaEscaner.Enabled = false; }
        }

        private void chkEscan2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEscan2.Checked == true)
            {
                ValorSeleccion = "OK";
                EscaneresNEURO = Nffv.GetAvailableScannerModules();
                chkEscan1.Checked = false;
                GrupoLista.Enabled = true;
                clbListaEscaner.Enabled = true;

                if (EscaneresNEURO.Length > 0)
                {
                    string[] TodosModulos = EscaneresNEURO.Split(new char[] { ';' });
                    clbListaEscaner.Items.Clear(); clbListaEscaner.Items.AddRange(TodosModulos);
                }
                else
                {
                    clbListaEscaner.Items.Add("No se encontraron módulos de escáner de NEURO.");
                    clbListaEscaner.Enabled = false; ValorSeleccion = string.Empty;
                }
            }
            else { GrupoLista.Enabled = false; clbListaEscaner.Items.Clear(); clbListaEscaner.Enabled = false; }
        }

		public string ScannerString
		{ get { return Escaner; }
        }

		public string FingerprintDatabase
		{ get { return txtNombreBDD.Text; }
            set { txtNombreBDD.Text = value; }
		}

		public string FingerprintDatabasePassword
		{ get { return txtPassword.Text; }
			set { txtPassword.Text = value; } }

		public string UserDatabase
		{ get { return txtUsuariosBDD.Text; }
			set { txtUsuariosBDD.Text = value; }
		}

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if ((EscaneresNEURO.Length > 0) || (EscaneresCODE.Length > 0))
                {
                    StringBuilder EscanerSel = new StringBuilder();
                    foreach (string ItemSel in clbListaEscaner.CheckedItems)
                    {
                        if (EscanerSel.Length > 0)
                        { EscanerSel.Append(";"); }
                        EscanerSel.Append(ItemSel);
                    }
                    Escaner = EscanerSel.ToString(); Close();
                }

                if ((ValorSeleccion == string.Empty) && ((EscaneresCODE.Trim() == string.Empty) || (EscaneresNEURO.Trim() == string.Empty)))
                {
                    MessageBox.Show("No se seleccionó ningún lector. Posiblemente se le notificará de este error más adelante, aún así se mostrará la ventana de escaneo...",
                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch { MessageBox.Show("Ocurrió un error inesperado.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }

        private void SeleccionConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeleccionConfig.SelectedTab == Pagina2)
            {
                DialogResult Pagina2;
                Pagina2 = MessageBox.Show("Atención: No se recomienda modificar las siguientes opciones, de lo contrario la configuración puede ser incorrecta,"
                    + " no se podrá acceder a la Base de Datos NEURO y podría haber un problema con el lector.",
                    "¡Atención!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (Pagina2 == DialogResult.OK)
                { SeleccionConfig.SelectedTab = Pagina1; }
            }
        }
    }
}
