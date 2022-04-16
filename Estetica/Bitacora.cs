using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Estetica
{
    public partial class Bitacora : Form
    {
        SqlConnection conexion = new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
        SQLBD BD = new SQLBD();
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Bitacora";
            SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Respaldar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("backup database Estetica to disk = 'C:\\Recuperación de base de datos\\BDEstetica_Respaldo.bak'", conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Respaldo realizado");
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar el respaldo, Error: " + ex.ToString());
            }

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            BD.LimpiarTablas(); 
            string query = "SELECT * FROM Bitacora";
            SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
