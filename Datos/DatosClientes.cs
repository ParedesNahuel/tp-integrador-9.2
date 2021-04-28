using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class DatosClientes
    {
        
        
            AccesoDatos ds = new AccesoDatos();

            public int AgregarClientesDAO(Clientes cliente)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametroClienteAgregar(ref comando, cliente);
                return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarClientes");
            }

            

            private void ArmarParametroClienteAgregar(ref SqlCommand comando, Clientes cliente)
            {
                SqlParameter sqlParametro = new SqlParameter();

            sqlParametro = comando.Parameters.Add("@Dni_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetDniCL();
            sqlParametro = comando.Parameters.Add("@Nombre_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetNombreCL();
            sqlParametro = comando.Parameters.Add("@Apellido_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetApellidoCL();
            sqlParametro = comando.Parameters.Add("@nacimiento_cl", SqlDbType.DateTime);
            sqlParametro.Value = cliente.GetAnioGS();
            sqlParametro = comando.Parameters.Add("@Direccion_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetDireccionCL();
            sqlParametro = comando.Parameters.Add("@numero_direccion_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetAlturaDireccionCL();
            sqlParametro = comando.Parameters.Add("@Partido_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetPartidoCL();
            sqlParametro = comando.Parameters.Add("@Cod_postal_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetCodPostalCL();
            sqlParametro = comando.Parameters.Add("@Provincia_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetProvinciaCL();
            sqlParametro = comando.Parameters.Add("@Telefono_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetTelefonoCL();
            sqlParametro = comando.Parameters.Add("@Mail_Cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetMailCL();
            sqlParametro = comando.Parameters.Add("@Estado_Cl", SqlDbType.Bit);
            sqlParametro.Value = cliente.GetEstadoCL();
            sqlParametro = comando.Parameters.Add("@Piso_direccion_cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetPisoCL();
            sqlParametro = comando.Parameters.Add("dep_direccion_cl", SqlDbType.VarChar);
            sqlParametro.Value = cliente.GetDepartamentoCL();    
               
            }
        //----------------------------de aca arranca lo nuevo para actualizar 19/11/20230 10:32 am
        public int ActualizarClienteDAO (Clientes cliente)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosClientesEditar(ref comando, cliente);

            return ds.EjecutarProcedimientoAlmacenado(comando, "spActualizarCliente");

        }
        private void ArmarParametrosClientesEditar(ref SqlCommand comando, Clientes client)
        {
            SqlParameter parametro = new SqlParameter();

            parametro = comando.Parameters.Add("@dni_cl", SqlDbType.VarChar);
            parametro.Value = client.GetDniCL();
            parametro = comando.Parameters.Add("@nombre_cl", SqlDbType.VarChar);
            parametro.Value = client.GetNombreCL();
            parametro = comando.Parameters.Add("@apellido_cl", SqlDbType.VarChar);
            parametro.Value = client.GetApellidoCL();
            parametro = comando.Parameters.Add("@telefono_cl", SqlDbType.VarChar);
            parametro.Value = client.GetTelefonoCL();
            parametro = comando.Parameters.Add("@mail_cl", SqlDbType.VarChar);
            parametro.Value = client.GetMailCL();
            parametro = comando.Parameters.Add("@estado_cl", SqlDbType.Bit);
            parametro.Value = client.GetEstadoCL();

        }


        //----------------------------------------- aca termina lo nuevo 19/11/20230 10:32 am
        public int eliminarClienteDAO(Clientes cliente)
            {
                SqlCommand comando = new SqlCommand();
                ArmarParametroClienteEliminar(ref comando, cliente);
                return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarCliente");
            }

            private void ArmarParametroClienteEliminar(ref SqlCommand comando, Clientes cliente)
            {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = comando.Parameters.Add("@Dni", SqlDbType.VarChar);
            SqlParametros.Value = cliente.GetDniCL();
        }

        public Boolean existeCliente(Clientes cliente)
        {
            string consulta = "select* from Clientes where dni_cl= '" + cliente.GetDniCL() + "'";
            return ds.existe(consulta);
        }

        public DataTable GetTablaClientes()
        {
           /* .....ORIGINAL....> DataTable tabla = ds.obtenerTabla
            ("Clientes", " select dni_cl , nombre_cl ,apellido_cl ,telefono_cl ," +
            "mail_cl   FROM Clientes ");*/
            DataTable tabla = ds.obtenerTabla
            ("Clientes", " select dni_cl , nombre_cl ,apellido_cl ,telefono_cl ,mail_cl" +
            " ,estado_cl  FROM Clientes ");
            return tabla;
        }

        public Clientes GetClientes(Clientes cliente)
        {
            DataTable Tabla = ds.obtenerTabla("Cliente", "select * from Clientes where dni_cl= " + cliente.GetDniCL());
            cliente.SetDniCL(Tabla.Rows[0][0].ToString());
            cliente.SetNombreCL(Tabla.Rows[0][1].ToString());
            return cliente;
        }

        /*
            public Boolean existeCliente(Clientes cliente)
            {
                string consulta = "select* from Clientes where Nombre_Cli= '" + cliente.GetNombreCL() + "'";
                return ds.existe(consulta);
            }

            public DataTable GetTablaClientes()
            {
                DataTable tabla = ds.obtenerTabla("Clientes", "select * from Clientes");
                return tabla;
            }

            public Clientes GetClientes(Clientes cliente)
            {
                DataTable Tabla = ds.obtenerTabla("Cliente", "select * from Clientes where Cod_Cli= " + cliente.GetCodClienteCL());
            cliente.SetCodClienteCL(Tabla.Rows[0][0].ToString());
            cliente.SetNombreCL(Tabla.Rows[0][1].ToString());
               return cliente;
            }*/

    }
}
