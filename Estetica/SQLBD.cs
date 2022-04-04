using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Estetica
{
     class SQLBD
    {
        readonly SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public SQLBD()
        {
            try
            {
                cn= new SqlConnection("Data source=.\\sqlexpress; initial catalog=Estetica; user id=Orlando; Password=admin;");
                cn.Open();
                MessageBox.Show("Conexión con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en: " + ex.ToString());
            }
        }
        public string insertarCitas(int ID_Citas, int Num_Tel, string Nombre, string Fecha, string TipoTrabajo, string Hora)
        {
            string salida = "Cita ingresa correctamente";
            try
            {
                cmd = new SqlCommand("insert into Citas values(" + ID_Citas + ", " + Num_Tel + ", '" + Nombre + "', '" + Fecha + "', '" + TipoTrabajo + "', '" + Hora + "')",cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se ingreso" + ex.ToString();
            }
            return salida;
        }
        public int RegistroCitas(string Fecha, string Hora)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Citas where Fecha + Hora = '" + Fecha + "' + '" + Hora + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar coincidencia, tipo: " + ex.ToString());
            }
            return contador;
        }
    }
}
