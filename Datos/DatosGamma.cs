using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class DatosGamma
    {
        AccesoDatos ds = new AccesoDatos();
        public Gammas GetGammas(Gammas gam)
        {
            DataTable tabla = ds.obtenerTabla("Gammas", "Select * from Gammas where CodGamma=" + gam.GetCodGammaGA());
            gam.SetCodGammaGA(tabla.Rows[0][0].ToString());
            gam.SetNombGammaGA(tabla.Rows[0][1].ToString());
            gam.SetDescripcionGA(tabla.Rows[0][2].ToString());
            gam.SetEstadoCL(Convert.ToBoolean(tabla.Rows[0][3].ToString()));
            return gam;
        }

        public Boolean existeGammas(Gammas gam)
        {
            String consulta = "Select * from Gammas where Patente='" + gam.GetNombGammaGA ()+ "'";
            return ds.existe(consulta);
        }

        public DataTable getTablaGammas()
        {

            DataTable tabla = ds.obtenerTabla("Gammas", "Select * from Gammas");
            return tabla;
        }

        public int eliminarGammas(Gammas gam)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGammasEliminar(ref comando, gam);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarGammas");
        }


        public int agregarGamma(Gammas gam)
        {


            SqlCommand comando = new SqlCommand();
            ArmarParametrosGammasAgregar(ref comando, gam);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarGammas");
        }

        private void ArmarParametrosGammasEliminar(ref SqlCommand Comando, Gammas gam)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CODGAMMAS", SqlDbType.VarChar);
            SqlParametros.Value = gam.GetCodGammaGA();
        }

        private void ArmarParametrosGammasAgregar(ref SqlCommand Comando, Gammas gam)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CODGAMMA", SqlDbType.VarChar);
            SqlParametros.Value = gam.GetCodGammaGA();
            SqlParametros = Comando.Parameters.Add("@NOMGAMMA", SqlDbType.VarChar);
            SqlParametros.Value = gam.GetNombGammaGA();
            SqlParametros = Comando.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar);
            SqlParametros.Value = gam.GetDescripcionGA();
            SqlParametros = Comando.Parameters.Add("@ESTADOGAM", SqlDbType.Binary);
            SqlParametros.Value = gam.GetEstadoCL();
        }

    }
}
