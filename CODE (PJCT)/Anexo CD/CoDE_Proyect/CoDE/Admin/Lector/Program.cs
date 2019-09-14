using System;
using System.Windows.Forms;

namespace Escaneo
{
	static class Program2
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Second()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            Neurotec.Biometrics.Nffv Engine = null;

			try
			{
				ElegirLectorForm ElegirLector = new ElegirLectorForm();
				if (ElegirLector.ShowDialog() == DialogResult.OK)
				{
                    try
                    { Engine = new Neurotec.Biometrics.Nffv(ElegirLector.FingerprintDatabase, 
                        ElegirLector.FingerprintDatabasePassword, ElegirLector.ScannerString); }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al inicializar Nffv (NEURO) o al crear/cargar la Base de Datos. \r\n" 
                            + "Verifique si: \r\n - La contraseña es correcta; \r\n - El nombre de la Base de Datos es correcto;" 
                            + "\r\n - Los lectores se están utilizando correctamente. \r \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
                    Application.Run(new EscaneoForm(Engine, ElegirLector.UserDatabase));
                }
            }
			catch (Exception ex)
			{ MessageBox.Show(string.Format("Ocurrió un error: {0}", ex.Message), 
                "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			finally
			{
				if (Engine != null)
				{ Engine.Dispose(); }
			}
		}
	}
}
