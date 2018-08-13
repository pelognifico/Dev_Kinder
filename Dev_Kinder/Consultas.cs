using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dev_Kinder
{
    class Consultas
    {
        private string cadena = @"Data Source = (localdb)\Carlos99; Initial Catalog = db_kinder; Integrated Security = true";
        public SqlConnection cn;
        public SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public SqlCommand cmd;
        public SqlDataReader leer;

        private void Conectar()
        {
            cn = new SqlConnection(cadena);
        }
        //Constructor
        public Consultas()
        {
            Conectar();
        }
        //Consultar
        public void Consultar_datos(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, cn);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //Eliminar Datos
        public bool Eliminar_datos(string tabla, string condicion)
        {
            cn.Open();
            string sql = "DELETE FROM " + tabla + " WHERE " + condicion;
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Actualizar
        public bool Actualizar_datos(string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "UPDATE " + tabla + " SET " + campos + " WHERE " + condicion;
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Cosultar 2
        public DataTable Consultar2(string tabla)
        {
            string sql = "SELECT * FROM " + tabla;
            da = new SqlDataAdapter(sql, cn);
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
        }
        //Insertar Datos
        public bool Insertar_datos(string sql)
        {
            cn.Open();
            cmd = new SqlCommand(sql, cn);
            int i = cmd.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }          
        }
        //verificar
        public bool Verificar(string sql)
        {
            cn.Open();
            cmd = new SqlCommand(sql, cn);
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                cn.Close();
                return true;
            }
            else
            {
                cn.Close();
                return false;
            }
        }
    }
}
