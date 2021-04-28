using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class NegocioClientes
    {
        public DataTable getTabla()
        {
            DatosClientes dao = new DatosClientes();
            return dao.GetTablaClientes();
        }

        public bool eliminarClientes(string dnicliente)
        {
            if (dnicliente == null)
            {
                return false;
            }

            DatosClientes dao = new DatosClientes();
            Clientes Cliente = new Clientes();
            Cliente.SetDniCL(dnicliente);
            int op = dao.eliminarClienteDAO(Cliente);

            if (op == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------de aca arranca lo nuevo para actualizar 19/11/20230 10:32 am
        public bool ActualizarClientes (Clientes client)
        {
            if (client.GetDniCL() == null)
            {
                return false;
            }

            DatosClientes dao = new DatosClientes();

            int op = dao.ActualizarClienteDAO(client);

            if (op==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //----------------------------------------- aca termina lo nuevo 19/11/20230 10:32 am

        //----------------------------------------- aca comienza el cambio del dia 20/11/2020 22.00
       /* public bool AgregarClientes(string dni, string Nombre, string apellido, string telefono, string mail)
        {
            int cantFilas = 0;

            Clientes Cliente = new Clientes();
            Cliente.SetDniCL(dni);
            Cliente.SetNombreCL(Nombre);
            Cliente.SetApellidoCL(apellido);
            Cliente.SetTelefonoCL(telefono);
            Cliente.SetMailCL(mail);

            DatosClientes dao = new DatosClientes();
            if (dao.existeCliente(Cliente) == false)
            {
                cantFilas = dao.AgregarClientesDAO(Cliente);
            }
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public bool AgregarClientes(Clientes Cliente)
        {
            int cantFilas = 0;


            DatosClientes dao = new DatosClientes();
            if (dao.existeCliente(Cliente) == false)
            {
                cantFilas = dao.AgregarClientesDAO(Cliente);
            }
            if (cantFilas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //----------------------------------------- aca termina lo nuevo 20/11/20230 22:00 am
        public Clientes get (Clientes client)
        {
            DatosClientes dato = new DatosClientes();
            return dato.GetClientes( client);
        }
       
    }
}

