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
                    Random random = new Random();
                    //Inserción de la cita
                    MessageBox.Show(BD.insertarCitas(Convert.ToInt32(random.Next(10000, 10000001)), Convert.ToInt32(Num_tel.Text), Nom.Text, dateTimePicker1.Text, TipoTrabajo.Text, Hora.Text));
                    
                    //Para que cargue los datos que se han guardado
                    string query = "SELECT * FROM Citas";
                    SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                    dataGridView1.DataSource = dt;
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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de solo escribir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Modificar_Cita_Click(object sender, EventArgs e)
        {
            if (Num_tel.Text == "" || Nom.Text == "" || TipoTrabajo.Text == "" || Hora.Text == "")
            {
                MessageBox.Show("Favor de ingresar datos a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                conexion.Open();
                if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                {
                    if (BD.RegistroCitas(dateTimePicker1.Text, Hora.Text) == 0)
                    {

                        Num_tel.Text = "";
                        Nom.Text = "";
                        TipoTrabajo.Text = "";
                        Hora.Text = "";
                        ID_Buscar.Text = "";
                        string query = "SELECT * FROM Citas";
                        SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Fecha ya apartada");
                    }
                }
                else
                {
                    MessageBox.Show("Cita no encontrada");
                }
                conexion.Close();
            }
        }

        private void OpModificiar_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = true;
            Nom.Enabled = true;
            dateTimePicker1.Enabled = true;
            TipoTrabajo.Enabled = true;
            Hora.Enabled = true;
            label6.Visible = true;
            ID_Buscar.Visible = true;
            Eliminar_Cita.Enabled = false;
            Ingresar.Enabled = false;
            Modificar_Cita.Enabled = true;
        }

        private void OpEliminarC_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = false;
            Nom.Enabled = false;
            dateTimePicker1.Enabled = false;
            TipoTrabajo.Enabled = false;
            Hora.Enabled = false;
            label6.Visible = true;
            ID_Buscar.Visible = true;
            Modificar_Cita.Enabled = false;
            Ingresar.Enabled = false;
            Eliminar_Cita.Enabled = true;
        }

        private void Eliminar_Cita_Click(object sender, EventArgs e)
        {
            if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
            {

                BD.EliminarCita(Convert.ToInt32(ID_Buscar.Text));
            }
            else
            {
                MessageBox.Show("Cita no encontrada");
            }
            ID_Buscar.Text = "";
            string query = "SELECT * FROM Citas";
            SqlDataAdapter cmd = new SqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rB_ingresar_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = true;
            Nom.Enabled = true;
            dateTimePicker1.Enabled = true;
            TipoTrabajo.Enabled = true;
            Hora.Enabled = true;
            label6.Visible = false;
            ID_Buscar.Visible = false;
            Modificar_Cita.Enabled = false;
            Eliminar_Cita.Enabled = false;
            Ingresar.Enabled = true;
        }
    }
}
