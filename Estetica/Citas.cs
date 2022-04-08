using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estetica
{
    public partial class Citas : Form
    {
        SqlConnection conexion = new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
        SQLBD BD = new SQLBD();
        public Citas()
        {
            InitializeComponent();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (Num_tel.Text == "" || Nom.Text == "" || TipoTrabajo.Text == "" || Hora.Text == "")
            {
                MessageBox.Show("Favor de ingresar datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Compartación si hay alguna cita con la misma fecha y hora
                if (BD.RegistroCitas(dateTimePicker1.Text,Hora.Text)==0)
                {
                    //Creación de ID de la cita
                    Random random = new Random();
                    //Inserción de la cita
                    MessageBox.Show(BD.insertarCitas(Convert.ToInt32(random.Next(10000, 10000001)), Convert.ToInt32(Num_tel.Text), Nom.Text, dateTimePicker1.Text, TipoTrabajo.Text, Hora.Text));
                    //Para que cargue los datos que se han guardado
                    string query = "SELECT * FROM Citas";
                    SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    dataGridView1.DataSource = dt;
                    //Vaciar los datos de los textboxs
                    Num_tel.Text = "";
                    Nom.Text = "";
                    TipoTrabajo.Text = "";
                    Hora.Text = "";
                }
                else
                {
                    MessageBox.Show("Fecha ya apartada");
                }
            }
        }
        //Texto de Tipo de trabajo
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //Solo Letras y espacios
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de solo escribir letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Texto de Numero telefonico
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Solo números sin espacios
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de solo escribir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Texto de Nombres
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //Solo Letras y espacios
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de solo escribir letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        //Texto de las horas
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) //Solo números
            {
                    if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                    {
                        MessageBox.Show("Favor de solo escribir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
                    }
            }

        private void Citas_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Citas";
            SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
