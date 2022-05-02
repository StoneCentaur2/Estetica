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
            dataGridView1.DataSource = BD.CargarCitas();
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
            if (RBNum_Tel.Checked == true)
            {
                Nom.Text = "";
                TipoTrabajo.Text = "";
                Hora.Text = "";

                if (Num_tel.Text == "")
                {
                    MessageBox.Show("Favor de ingresar los datos a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ID_Buscar.Text == "")
                {
                    MessageBox.Show("Favor de ingresar el ID de la cita a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    string Fila = "Num_tel";
                    conexion.Open();
                    if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                    {
                        MessageBox.Show(BD.ModificaciónEnCitas(Fila, Num_tel.Text, Convert.ToInt32(ID_Buscar.Text)));
                        Num_tel.Text = "";
                        ID_Buscar.Text = "";
                        dataGridView1.DataSource = BD.CargarCitas();
                        RBNum_Tel.Checked = false;
                        Num_tel.Enabled = false;
                        ID_Buscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cita no encontrada");
                    }
                    conexion.Close();
                }
            }
            else if (RBNom.Checked == true)
            {
                Num_tel.Text = "";
                TipoTrabajo.Text = "";
                Hora.Text = "";

                if (Nom.Text == "")
                {
                    MessageBox.Show("Favor de ingresar los datos a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ID_Buscar.Text == "")
                {
                    MessageBox.Show("Favor de ingresar el ID de la cita a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    string Fila = "Nombre";
                    conexion.Open();
                    if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                    {
                        MessageBox.Show(BD.ModificaciónEnCitas(Fila, Nom.Text, Convert.ToInt32(ID_Buscar.Text)));
                        Nom.Text = "";
                        ID_Buscar.Text = "";
                        RBNom.Checked = false;
                        dataGridView1.DataSource = BD.CargarCitas();
                        Nom.Enabled = false;
                        ID_Buscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cita no encontrada");
                    }
                    conexion.Close();
                }
            }
            else if (RBFecha.Checked == true)
            {
                Num_tel.Text = "";
                Nom.Text = "";
                TipoTrabajo.Text = "";

                if (Hora.Text == "")
                {
                    MessageBox.Show("Favor de ingresar los datos a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ID_Buscar.Text == "")
                {
                    MessageBox.Show("Favor de ingresar el ID de la cita a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    string FilaFecha = "Fecha";
                    string FilaHora = "Hora";
                    conexion.Open();
                    if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                    {
                        if (BD.RegistroCitas(dateTimePicker1.Text, Hora.Text) == 0)
                        {
                            MessageBox.Show(BD.ModificaciónEnCitas(FilaFecha, dateTimePicker1.Text, Convert.ToInt32(ID_Buscar.Text)));
                            BD.ModificaciónEnCitas(FilaHora, Hora.Text, Convert.ToInt32(ID_Buscar.Text));
                            Hora.Text = "";
                            ID_Buscar.Text = "";
                            RBFecha.Checked = false;
                            dataGridView1.DataSource = BD.CargarCitas();
                            Hora.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            ID_Buscar.Enabled = false;
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
            else if (RBTrabajo.Checked == true)
            {
                Num_tel.Text = "";
                Nom.Text = "";
                Hora.Text = "";

                if (TipoTrabajo.Text == "")
                {
                    MessageBox.Show("Favor de ingresar los datos a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (ID_Buscar.Text == "")
                {
                    MessageBox.Show("Favor de ingresar el ID de la cita a modificar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    string Fila = "TipoTrabajo";
                    conexion.Open();
                    if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                    {
                        MessageBox.Show(BD.ModificaciónEnCitas(Fila, TipoTrabajo.Text, Convert.ToInt32(ID_Buscar.Text)));
                        TipoTrabajo.Text = "";
                        ID_Buscar.Text = "";
                        RBTrabajo.Checked = false;
                        dataGridView1.DataSource = BD.CargarCitas();
                        TipoTrabajo.Enabled = false;
                        ID_Buscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cita no encontrada");
                    }
                    conexion.Close();
                }
            }
        }

        private void OpModificiar_CheckedChanged(object sender, EventArgs e)
        {
            //Radiobotton
            RBNum_Tel.Visible = true;
            RBNom.Visible = true;
            RBFecha.Visible = true;
            RBTrabajo.Visible = true;
            //De busqueda
            label6.Visible = true;
            ID_Buscar.Visible = true;
            //Contenido de texto
            Num_tel.Text = "";
            Nom.Text = "";
            TipoTrabajo.Text = "";
            Hora.Text = "";
            ID_Buscar.Text = "";
            //RadioBotton de seleccion
            Eliminar_Cita.Enabled = false;
            Ingresar.Enabled = false;
            Modificar_Cita.Enabled = true;
        }

        private void OpEliminarC_CheckedChanged(object sender, EventArgs e)
        {
            //Radiobotton
            RBNum_Tel.Visible = false;
            RBNom.Visible = false;
            RBFecha.Visible = false;
            RBTrabajo.Visible = false;
            //De interaccion
            Num_tel.Enabled = false;
            Nom.Enabled = false;
            dateTimePicker1.Enabled = false;
            TipoTrabajo.Enabled = false;
            Hora.Enabled = false;
            ID_Buscar.Enabled = true;
            //De busqueda
            label6.Visible = true;
            ID_Buscar.Visible = true;
            //Contenido de texto
            Num_tel.Text = "";
            Nom.Text = "";
            TipoTrabajo.Text = "";
            Hora.Text = "";
            ID_Buscar.Text = "";
            //RadioBotton de seleccion
            Modificar_Cita.Enabled = false;
            Ingresar.Enabled = false;
            Eliminar_Cita.Enabled = true;
        }

        private void Eliminar_Cita_Click(object sender, EventArgs e)
        {
            if (ID_Buscar.Text == "")
            {
                MessageBox.Show("Favor de ingresar ID de la cita para buscar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (BD.BusquedaID(Convert.ToInt32(ID_Buscar.Text)) == 1)
                {

                    BD.EliminarCita(Convert.ToInt32(ID_Buscar.Text));
                }
                else
                {
                    MessageBox.Show("Cita no encontrada");
                }
            }
          ID_Buscar.Text = "";
          dataGridView1.DataSource = BD.CargarCitas();
        }

        private void rB_ingresar_CheckedChanged(object sender, EventArgs e)
        {
            //Radiobotton
            RBNum_Tel.Visible = false;
            RBNom.Visible = false;
            RBFecha.Visible = false;
            RBTrabajo.Visible = false;
            //De interaccion
            Num_tel.Enabled = true;
            Nom.Enabled = true;
            dateTimePicker1.Enabled = true;
            TipoTrabajo.Enabled = true;
            Hora.Enabled = true;
            //De busqueda
            label6.Visible = false;
            ID_Buscar.Visible = false;
            //Contenido de texto
            Num_tel.Text = "";
            Nom.Text = "";
            TipoTrabajo.Text = "";
            Hora.Text = "";
            ID_Buscar.Text = "";
            //RadioBotton de seleccion
            Modificar_Cita.Enabled = false;
            Eliminar_Cita.Enabled = false;
            Ingresar.Enabled = true;
        }

        private void RBNum_Tel_CheckedChanged(object sender, EventArgs e)
        {
            Nom.Enabled = false;
            dateTimePicker1.Enabled = false;
            TipoTrabajo.Enabled = false;
            Hora.Enabled = false;
            Num_tel.Enabled = true;
        }

        private void RBNom_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = false;
            dateTimePicker1.Enabled = false;
            TipoTrabajo.Enabled = false;
            Hora.Enabled = false;
            Nom.Enabled = true;
        }

        private void RBFecha_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = false;
            Nom.Enabled = false;
            TipoTrabajo.Enabled = false;
            Hora.Enabled = true;
            dateTimePicker1.Enabled = true;
        }

        private void RBTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            Num_tel.Enabled = false;
            Nom.Enabled = false;
            dateTimePicker1.Enabled = false;
            Hora.Enabled = false;
            TipoTrabajo.Enabled = true;
        }
    }
}
