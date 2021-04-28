using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    class AccesoDatos
    {
        //completar una vez tengamos la base de datos
       // string RutaBDConcecionaria = "Data Source=DESKTOP-9KL61KT\\SQLEXPRESS;Initial Catalog=concesionaria2;Integrated Security=True";
        string RutaBDConcecionaria = "Data Source=OEM-PC\\SQLEXPRESS;Initial Catalog=concesionaria;Integrated Security=True";
        //Data Source = DESKTOP - 9KL61KT\\SQLEXPRESS;Initial Catalog = concesionaria; Integrated Security = True
        public AccesoDatos()
        {
        }

        private SqlConnection obtenerconexion()
        {
            SqlConnection cn = new SqlConnection(RutaBDConcecionaria);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        private SqlDataAdapter obtenerAdaptador(string ConsultasSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(ConsultasSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public DataTable obtenerTabla(string Tabla,string sql)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = obtenerconexion();
            SqlDataAdapter adp = obtenerAdaptador(sql, conexion);
            adp.Fill(ds, Tabla);
            conexion.Close();
            return ds.Tables[Tabla];
        
        }
        public int EjecutarProcedimientoAlmacenado(SqlCommand comando, string NombreSP)
        {
            int FilasCambiadas;
            SqlConnection conexion = obtenerconexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return FilasCambiadas;
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlConnection conexion = obtenerconexion();
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            
            if (datos.Read())
            {
                estado = true;
            }
            return estado;
        }

    }
}
