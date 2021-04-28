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
    public class datosgestor
    {
        AccesoDatos ds = new AccesoDatos();

       /* public Gestores getGestores(Gestores ges)
        {
            DataTable tabla = ds.obtenerTabla("Gestores", "Select * from Gestores where matricula=" + ges.GetMatriculaGS());
            ges.SetMatriculaGS(tabla.Rows[0][0].ToString());
            ges.SetDniGS(tabla.Rows[0][1].ToString());
            ges.SetNombreGS(tabla.Rows[0][2].ToString());
            ges.SetApellidoGS(tabla.Rows[0][3].ToString());
            ges.SetAnioGS(Convert.ToDateTime(tabla.Rows[0][4]));
            ges.SetMailGS(tabla.Rows[0][5].ToString());
            ges.SetNombPerfilGS(tabla.Rows[0][6].ToString());
            ges.SetContrasenaGS(tabla.Rows[0][7].ToString());
            ges.SetNivelGS(Convert.ToInt32(tabla.Rows[0][8].ToString()));
            ges.SetEstadoGS(Convert.ToBoolean(tabla.Rows[0][9].ToString()));
            return ges;
        }*/

        public Gestores getGestores(Gestores ges)

        {

            DataTable tabla = ds.obtenerTabla("Gestores", "Select * from Gestores where nombre_perfil_ge = '" + ges.GetNombPerfilGS() + "'");

            ges.SetMatriculaGS(tabla.Rows[0][0].ToString());
            ges.SetDniGS(tabla.Rows[0][1].ToString());
            ges.SetNombreGS(tabla.Rows[0][2].ToString());
            ges.SetApellidoGS(tabla.Rows[0][3].ToString());
            ges.SetAnioGS(Convert.ToDateTime(tabla.Rows[0][4]));
            ges.SetMailGS(tabla.Rows[0][5].ToString());
            ges.SetNombPerfilGS(tabla.Rows[0][6].ToString());
            ges.SetContrasenaGS(tabla.Rows[0][7].ToString());
            ges.SetNivelGS(Convert.ToInt32(tabla.Rows[0][8].ToString()));
            ges.SetEstadoGS(Convert.ToBoolean(tabla.Rows[0][9].ToString()));
            return ges;

        }


        public Boolean existegestor(Gestores ges)
        {
            string consulta = "select Nombre_Perfil_ge, Contrasena_ge from Gestores where Nombre_Perfil_ge='" + ges.GetNombPerfilGS() + "' and Contrasena_ge='" + ges.GetContrasenaGS() + "'";
            return ds.existe(consulta);
        }
        public DataTable GetTablaGestores()
        {

           DataTable tabla = ds.obtenerTabla("Gestores", "Select * from Gestores");
           // DataTable tabla = ds.obtenerTabla("Gestores", "SELECT matricula_ge AS Matricula, dni_ge AS DNI, nombre_ge AS Nombre, apellido_ge AS Apellido, nacimiento_ge AS Nacimiento, mail_ge AS Mail, nombre_perfil_ge AS [Nombre de perfil] FROM Gestores");
            return tabla;
        }
        public int EliminarGestores(Gestores ges)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGestorEliminar(ref comando, ges);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarGestores");
        }
        private void ArmarParametrosGestorEliminar(ref SqlCommand Comando, Gestores ges)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@MATRICULA", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetMatriculaGS();
        }
        public int AgregarGestores(Gestores ges)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGestoresAgregar(ref comando, ges);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarGestores");
        }

        
        private void ArmarParametrosGestoresAgregar(ref SqlCommand Comando, Gestores ges)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@MATRICULA_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetMatriculaGS();
            SqlParametros = Comando.Parameters.Add("@DNI_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetDniGS();
            SqlParametros = Comando.Parameters.Add("@NOMBRE_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetNombreGS();
            SqlParametros = Comando.Parameters.Add("@APELLIDO_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetApellidoGS();
            SqlParametros = Comando.Parameters.Add("@nacimiento_ge", SqlDbType.DateTime);
            SqlParametros.Value = ges.GetAnioGS();//no estoy seguro si esta bien aplicado esto pero creo que devuelve bien la fecha
            SqlParametros = Comando.Parameters.Add("@MAIL_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetMailGS();
            SqlParametros = Comando.Parameters.Add("@NOMBRE_PERFIL_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetNombPerfilGS();
            SqlParametros = Comando.Parameters.Add("@CONTRASENA_ge", SqlDbType.VarChar);
            SqlParametros.Value = ges.GetContrasenaGS();
            SqlParametros = Comando.Parameters.Add("@NIVEL_ge", SqlDbType.Int);
            SqlParametros.Value = ges.GetNivelGS();
            SqlParametros = Comando.Parameters.Add("@ESTADO_ge", SqlDbType.Bit);
            SqlParametros.Value = ges.GetEstadoGS();

        }
    }
}
