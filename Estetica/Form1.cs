using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estetica
{
    public partial class Principal : Form
    {
        SqlConnection conexion = new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
        BaseDeDatos BD = new BaseDeDatos();
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
                citas.ShowDialog();
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
                venta.ShowDialog();
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
            try
            {
                conexion.Open();
                MessageBox.Show("Su conexión es exitosa");
                conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión");
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Inicio_de_sesion_Click(object sender, EventArgs e) //Inicio de sesión de usuarios
        {
            if (Usuario.Text == "" && Contraseña.Text == "")
            {
                MessageBox.Show("Favor de escribir en los campos correspondientes", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                string buscando = Usuario.Text;
                SqlDataReader lector = null;
                string sql = "SELECT Nombre FROM Empleados WHERE Nombre LIKE '" + buscando + "' LIMIT 1";
                conexion.Open();
                
                try
                {
                    SqlCommand comando = new SqlCommand(sql, conexion);
                    lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        if (Contraseña.Text == "admin")
                        {
                            while (lector.Read())
                            {
                                Usuario.Text = lector.GetString(0);
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
                catch (MySqlException error)
                {
                    MessageBox.Show("Error en la busqueda " + error.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
