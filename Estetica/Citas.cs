using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Estetica
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        BaseDeDatos BD = new BaseDeDatos();
        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (Nom.Text == "" || Num_tel.Text == "" || TipoTrabajo.Text == "" || Hora.Text == "")
            {
                MessageBox.Show("Favor de ingresar datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Random random = new Random();
                string ingresar = "insert into Citas values (" + random.Next(10000, 10000001) + ", '" + Nom.Text + "', '" + Num_tel.Text + "','" + dateTimePicker1.Text + "', '" + TipoTrabajo + "','" + Hora.Text + "')";
                if (BD.executecommand(ingresar))
                {
                    MessageBox.Show("Cita ingresada correctamente");
                    dataGridView1.DataSource = BD.SelectDataTable("select * from Citas");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                Nom.Text = "";
                Num_tel.Text = "";
                TipoTrabajo.Text = "";
                Hora.Text = "";
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) //Solo números sin espacios
        {
                if ((e.KeyChar >= 32 && e.KeyChar <=47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
                {
                    MessageBox.Show("Favor de solo escribir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //Solo Letras y espacios
            {
                    if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
                    {
                        MessageBox.Show("Favor de solo escribir letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                        return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //Solo números sin espacios
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Favor de solo escribir números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e) //Puros numeros
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
            dataGridView1.DataSource = BD.SelectDataTable("select * from Citas");
        }
    }
}
