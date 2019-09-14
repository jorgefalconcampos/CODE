using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;

namespace CoDE_Proyect
{
    public class SqlHelper
    {
        SqlConnection cn;

        public SqlHelper(string CadenaConexion)
        { cn = new SqlConnection(CadenaConexion); }

        public bool EstadoConexion
        {
            get
            {
                if (cn.State == ConnectionState.Closed)
                {
                    try {
                        using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                            cnn.Open(); return true;
                    }
                    catch
                    { MessageBox.Show("Error al tratar de abrir la conexión.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                } return false;
            } 
        }
    }


    public class ConfigConexion
    {
        Configuration Config;

        public ConfigConexion()
        { Config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); }

        public string ObtenerCadenaCon(string Key)
        { return Config.ConnectionStrings.ConnectionStrings[Key].ConnectionString; }

        public void GuardarCadenaCon(string Key, string Valor)
        {
            Config.ConnectionStrings.ConnectionStrings[Key].ConnectionString = Valor + " Integrated Security=True;";
            Config.ConnectionStrings.ConnectionStrings[Key].ProviderName = "System.Data.SqlClient";
            Config.Save(ConfigurationSaveMode.Modified);
        }
    }


    class Procesos
    {

        //////////////////////////////////////////////////////////////////////

        SmtpClient Cliente = new SmtpClient(CODE.Default.Email_Host, CODE.Default.Email_Puerto);
        MailMessage mensaje = new MailMessage();

        public Procesos()
        {
            Cliente.Credentials = new NetworkCredential(CODE.Default.Email_User, CODE.Default.Email_Pass);
            Cliente.Port = CODE.Default.Email_Puerto; Cliente.EnableSsl = true; Cliente.Host = CODE.Default.Email_Host;
        }

        public void MandarCorreo(MailMessage mensaje)
        { Cliente.Send(mensaje); }

        //////////////////////////////////////////////////////////////////////

        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        public static void SoloNum(KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        public static void Num_Letras(KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
            else if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
            else if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        //////////////////////////////////////////////////////////////////////

        public static void VerficiarSesion()
        {
            if ((SesionDeAdmin.SA == null))
            {
                CerrarSesionPress = false;
                MessageBox.Show("Esta sesión ha expirado, favor de iniciar sesión de nuevo con\r\nsus credenciales de Administrador. La aplicación se reiniciará.",
                "Sesión expirada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); Program.ReiniciarApp(); 
            }
        }

        public static bool CerrarSesionPress = false;

        public static void CerrarSesion(FormClosingEventArgs e)
        {
            DialogResult SalirConfirmar;
            SalirConfirmar = MessageBox.Show("Se perderá la sesión. ¿Continuar?", "¿Desea salir de la aplicación?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((SalirConfirmar == DialogResult.Yes))
            {
                SesionDeAdmin.SA = null;
                SesionDeAdmin.SH = null;
                Inicio FormInicio = new Inicio();
                FormInicio.Show();
            } else { e.Cancel = true; CerrarSesionPress = false; }
        }   

        public static class SesionDeAdmin
        { public static string SA; public static string SH; }

        public static class VerficiacionAdmin
        { public static string Verif; public static string APVerif; }

        public static class Opciones
        { public static string ID; }

        public static string CadenaConexion = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;

        /////////////////////////////////////////


        #region Admin

        public static void AñadirAdmin(string Admin, string Pass)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_AdminInsertar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Administrador", SqlDbType.NVarChar, 50).Value = Admin.Trim();
            cmd.Parameters.Add("@Contraseña", SqlDbType.NVarChar, 300).Value = Pass.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable ConsultarAdmin(string Admin)
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SP_AdminConsulta", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@AdministradorConsulta", SqlDbType.NVarChar, 25).Value = Admin.Trim();
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception)
            { }
            return TablaDeDatos;
        }

        public static void BajaAdmin(string Admin)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_AdminBorrar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@AdministradorBorrar", SqlDbType.NVarChar, 50).Value = Admin.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        #endregion


        //////////////////////////////////////////////////////////////////////


        #region Alumnos

        public static void AñadirAlumno(string Boleta, string Nombre, string AP, string AM, byte[] Imagen,
            string Turno, string Carrera, string Grupo, string NombreTutor, string EmailTutor)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_AlumnoInsertar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Boleta_AlumnoINS", SqlDbType.Int).Value = Convert.ToInt32(Boleta);
            cmd.Parameters.Add("@Nombre_AlumnoINS", SqlDbType.NVarChar, 50).Value = Nombre.Trim();
            cmd.Parameters.Add("@ApellidoP_AlumnoINS", SqlDbType.NVarChar, 50).Value = AP.Trim();
            cmd.Parameters.Add("@ApellidoM_AlumnoINS", SqlDbType.NVarChar, 50).Value = AM.Trim();
            cmd.Parameters.Add("@Foto_AlumnoINS", SqlDbType.Image).Value = Imagen;
            cmd.Parameters.Add("@Turno_AlumnoINS", SqlDbType.VarChar, 25).Value = Turno.Trim();
            cmd.Parameters.Add("@Carrera_AlumnoINS", SqlDbType.VarChar, 40).Value = Carrera.Trim();
            cmd.Parameters.Add("@Grupo_AlumnoINS", SqlDbType.VarChar, 15).Value = Grupo.Trim();
            cmd.Parameters.Add("@NombreTutorINS", SqlDbType.NVarChar, 150).Value = NombreTutor.Trim();
            cmd.Parameters.Add("@Email_TutorINS", SqlDbType.NVarChar, 100).Value = EmailTutor.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        #region Consultas varias

        public static DataTable ConsAlum_1(string Alumno_ID) //Consulta por boleta
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SP_AlumnoBoletaConsulta", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@AlumnoConsulta", SqlDbType.Int).Value = Alumno_ID.Trim();
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static DataTable ConsAlum_2(string Alumno_Turno) //Consulta por turno
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Boleta, Nombre,	ApellidoPaterno, ApellidoMaterno, Turno, Carrera, Grupo, NombreTutor, EmailTutor FROM tb_Alumnos WHERE Turno LIKE '" + Alumno_Turno + "'", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static DataTable ConsAlum_3(string Alumno_Carrera) //Consulta por carrera
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Boleta, Nombre, ApellidoPaterno, ApellidoMaterno, Turno, Carrera, Grupo, NombreTutor, EmailTutor FROM tb_Alumnos WHERE Carrera LIKE '" + Alumno_Carrera + "'", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static DataTable ConsAlum_4(string Alumno_Grupo) //Consulta por grupo
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Boleta, Nombre, ApellidoPaterno, ApellidoMaterno, Turno, Carrera, Grupo, NombreTutor, EmailTutor FROM tb_Alumnos WHERE Grupo LIKE '" + Alumno_Grupo + "'", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        #endregion


        public static void ActualizarAlumno(string Boleta, string Nombre, string AP, string AM, byte[] Imagen,
          string Turno, string Carrera, string Grupo, string NombreTutor, string EmailTutor)
        {
            string sConexion = CadenaConexion;

            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_AlumnoActualizar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Boleta_AlumnoACT", SqlDbType.Int).Value = Convert.ToInt32(Boleta);
            cmd.Parameters.Add("@Nombre_AlumnoACT", SqlDbType.NVarChar, 50).Value = Nombre.Trim();
            cmd.Parameters.Add("@ApellidoP_AlumnoACT", SqlDbType.NVarChar, 50).Value = AP.Trim();
            cmd.Parameters.Add("@ApellidoM_AlumnoACT", SqlDbType.NVarChar, 50).Value = AM.Trim();
            cmd.Parameters.Add("@Foto_AlumnoACT", SqlDbType.Image).Value = Imagen;
            cmd.Parameters.Add("@Turno_AlumnoACT", SqlDbType.VarChar, 25).Value = Turno.Trim();
            cmd.Parameters.Add("@Carrera_AlumnoACT", SqlDbType.VarChar, 40).Value = Carrera.Trim();
            cmd.Parameters.Add("@Grupo_AlumnoACT", SqlDbType.VarChar, 15).Value = Grupo.Trim();
            cmd.Parameters.Add("@NombreTutorACT", SqlDbType.NVarChar, 150).Value = NombreTutor.Trim();
            cmd.Parameters.Add("@Email_TutorACT", SqlDbType.NVarChar, 100).Value = EmailTutor.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void BajaAlumno(string Alumno_ID)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_AlumnoBorrar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BoletaAlumnoBorrar", SqlDbType.Int).Value = Alumno_ID.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        #endregion


        //////////////////////////////////////////////////////////////////////


        #region Empleados

        public static void AñadirEmpleado(string NumEmp, string Nombre, string AP, string AM, byte[] Imagen,
            string Turno, string Email)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_EmpleadoInsertar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NumEmpINS", SqlDbType.NVarChar, 30).Value = NumEmp.Trim();
            cmd.Parameters.Add("@Nombre_EmpleadoINS", SqlDbType.NVarChar, 50).Value = Nombre.Trim(); ;
            cmd.Parameters.Add("@ApellidoP_EmpleadoINS", SqlDbType.NVarChar, 50).Value = AP.Trim();
            cmd.Parameters.Add("@ApellidoM_EmpleadoINS", SqlDbType.NVarChar, 50).Value = AM.Trim();
            cmd.Parameters.Add("@Foto_EmpleadoINS", SqlDbType.Image).Value = Imagen;
            cmd.Parameters.Add("@Turno_EmpleadoINS", SqlDbType.NVarChar, 25).Value = Turno.Trim();
            cmd.Parameters.Add("@Email_EmpleadoINS", SqlDbType.NVarChar, 100).Value = Email.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }


        #region Consultas varias

        public static DataTable ConsEmp_1(string Empleado_ID) //Consulta por num. de empleado
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SP_EmpledoNumConsulta", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@EmpleadoConsulta", SqlDbType.NVarChar, 30).Value = Empleado_ID.Trim();
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static DataTable ConsEmp_2(string Empleado_Turno) //Consulta por turno
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ToString()))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT NumeroEmpleado, Nombre, ApellidoPaterno, ApellidoMaterno, Turno, Email FROM tb_Empleados WHERE Turno LIKE '" + Empleado_Turno + "'", cnn);
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static DataTable ConsEmp_3()
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                string sConexion = CadenaConexion;
                SqlConnection cnn = new SqlConnection(sConexion);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = "SELECT Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS NombreCompleto FROM tb_Empleados";
                SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                AdaptadorDeDatos.Fill(TablaDeDatos);
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        public static AutoCompleteStringCollection ConsEmp_3_1()
        {
            DataTable TablaDeDatos = ConsEmp_3();
            AutoCompleteStringCollection ItemsAutocompletar = new AutoCompleteStringCollection();
            foreach (DataRow row in TablaDeDatos.Rows)
            { ItemsAutocompletar.Add(Convert.ToString(row["NombreCompleto"])); }
            return ItemsAutocompletar;
        }

        public static DataTable ConsEmp_4(string Empleado_NombreCompleto) //Consulta por nombres
        {
            DataTable TablaDeDatos = new DataTable();
            try
            {
                {
                    string sConexion = CadenaConexion;
                    SqlConnection cnn = new SqlConnection(sConexion);
                    SqlCommand cmd = new SqlCommand("SELECT NumeroEmpleado, Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS NombreCompleto, Turno, Email FROM tb_Empleados WHERE Nombre + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno LIKE '%" + Empleado_NombreCompleto + "%'");
                    cmd.Connection = cnn;
                    SqlDataAdapter AdaptadorDeDatos = new SqlDataAdapter(cmd);
                    AdaptadorDeDatos.Fill(TablaDeDatos);
                    cnn.Close();
                }
            }
            catch (Exception) { }
            return TablaDeDatos;
        }

        #endregion


        public static void ActualizarEmpleado(string NumEmp, string Nombre, string AP, string AM, byte[] Imagen,
           string Turno, string Email)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_EmpleadoActualizar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NumEmpACT", SqlDbType.NVarChar, 30).Value = NumEmp.Trim();
            cmd.Parameters.Add("@Nombre_EmpleadoACT", SqlDbType.NVarChar, 50).Value = Nombre.Trim(); ;
            cmd.Parameters.Add("@ApellidoP_EmpleadoACT", SqlDbType.NVarChar, 50).Value = AP.Trim();
            cmd.Parameters.Add("@ApellidoM_EmpleadoACT", SqlDbType.NVarChar, 50).Value = AM.Trim();
            cmd.Parameters.Add("@Foto_EmpleadoACT", SqlDbType.Image).Value = Imagen;
            cmd.Parameters.Add("@Turno_EmpleadoACT", SqlDbType.NVarChar, 25).Value = Turno.Trim();
            cmd.Parameters.Add("@Email_EmpleadoACT", SqlDbType.NVarChar, 100).Value = Email.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void EliminarEmpleadoCLASE(string NumEmpBorrar)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("SP_EmpleadoBorrar", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NumEmpleadoBorrar", SqlDbType.NVarChar, 30).Value = NumEmpBorrar.Trim();
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        #endregion


        //////////////////////////////////////////////////////////////////////

        public static void EliminarTurnoCLASE(string Turno)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("DELETE FROM tb_Alumnos WHERE Turno = '" + Turno + "' DELETE FROM tb_Empleados WHERE Turno = '" + Turno + "'", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();
        }

        public static void EliminarCarreraCLASE(string Carrera)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("DELETE FROM tb_Alumnos WHERE Turno = '" + Carrera + "'", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();
        }

        public static void EliminarGrupoCLASE(string Grupo)
        {
            string sConexion = CadenaConexion;
            SqlConnection cnn = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("DELETE FROM tb_Alumnos WHERE Grupo = '" + Grupo + "'", cnn);
            cmd.CommandType = CommandType.Text;
            cnn.Open(); cmd.ExecuteNonQuery(); cnn.Close();
        }
    }
}

