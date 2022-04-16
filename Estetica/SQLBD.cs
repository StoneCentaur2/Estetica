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
                MessageBox.Show("Conexión abierta");
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
        public int BusquedaID(int ID_Buscar)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("SELECT * FROM Citas where ID_Citas = " + ID_Buscar + "", cn);
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
        public int EliminarCita(int ID_Citas)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("DELETE FROM Citas WHERE ID_Citas = " + ID_Citas + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                MessageBox.Show("Cita eliminada");
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.ToString());
            }
            return contador;
        }
        public void LimpiarTablas()
        {
            try
            {
                cmd = new SqlCommand("TRUNCATE TABLE Bitacora", cn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("TRUNCATE TABLE Trabajos", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros eliminados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar. /n Tipo de error: " + ex.ToString());
            }
        }
    }
}
