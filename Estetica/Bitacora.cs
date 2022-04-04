using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Estetica
{
    public partial class Bitacora : Form
    {
        SqlConnection conexion = new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
        public Bitacora()
        {
            InitializeComponent();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "SELECT * FROM Bitacora";
            SqlCommand comando = new SqlCommand(sql, conexion);
            dataGridView1.DataSource = comando.ExecuteReader();
            conexion.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
