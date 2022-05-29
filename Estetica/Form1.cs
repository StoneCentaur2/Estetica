using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estetica
{
    public partial class Principal : Form
    {
        SqlConnection conexion = new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
        public Principal()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Citas_Click(object sender, EventArgs e)
        {
            if (Usuario.Visible == false)
            {
                Form p = new Principal();
                p.Close();
                Citas citas = new Citas();
                citas.Show();
            }
            else
            {
                MessageBox.Show("Favor de iniciar sesión primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Ventas_Click(object sender, EventArgs e)
        {
            if (Usuario.Visible == false)
            {
                Form p = new Principal();
                p.Close();
                Form venta = new Trabajos();
                venta.Show();
            }
            else
            {
                MessageBox.Show("Favor de iniciar sesión primero", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Conexion_Click(object sender, EventArgs e)
        {
            SQLBD cn = new SQLBD();
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Inicio_de_sesion_Click(object sender, EventArgs e) //Inicio de sesión de usuarios
        {
            if (Usuario.Text == "" || Contraseña.Text == "")
            {
                MessageBox.Show("Favor de escribir en los campos correspondientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                //Busqueda del Usuario en la base de datos con su comando
                string buscando = Usuario.Text;
                SqlDataReader lector = null;
                string sql = "SELECT Usuario FROM Empleados WHERE Usuario ='" + buscando + "'";

                //Busqueda de la contraseña en la base de datos con su comando
                string buscandoContra = Contraseña.Text;
                SqlDataReader lectorContra = null;
                string sqlContra = "SELECT Contraseña FROM Empleados WHERE Contraseña ='" + buscandoContra + "'";
                //Apertura de sql
                conexion.Open();
                
                try
                {
                    //comando de sql para ejecutar en sql en busqueda del Usuario
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                            while (lector.Read())
                        {
                            Usuario.Text = lector.GetString(0);
                        }
                        //se hizo una cierre y apertura de comando, para que los lea de forma separada cada comando
                        conexion.Close();
                        conexion.Open();
                        
                        //comando de sql para ejecutar en sql en busqueda de la Contraseña
                        SqlCommand comandoContra = new SqlCommand(sqlContra, conexion);
                            lectorContra = comandoContra.ExecuteReader();

                        if (lectorContra.HasRows)
                        {
                            while (lectorContra.Read())
                            {
                                Contraseña.Text = lectorContra.GetString(0);
                            }
                            MessageBox.Show("Sesión iniciada");
                            label1.Visible = false;
                            label2.Visible = false;
                            Usuario.Visible = false;
                            Contraseña.Visible = false;
                            Inicio_de_sesion.Visible = false;
                            Usuario.Text = "";
                            Contraseña.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado, favor de verificar usuario");
                    }
                }
                catch (SqlException error)
                {
                    MessageBox.Show("Error en la busqueda " + error.Message);
                }
                finally
                {
                    if (buscando == "Maria")
                    {
                        Bitacora.Visible = true;
                    }
                    conexion.Close();
                }
            }
        }

        private void Bitacora_Click(object sender, EventArgs e)
        {
            if (Usuario.Visible == false)
            {
                Form p = new Principal();
                p.Close();
                Bitacora B = new Bitacora();
                B.Show();
            }
            else
            {
                MessageBox.Show("Favor de iniciar sesión como administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
