using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {
        private string CodPostal;
        private string Nombre;
        private string Apellido;
        private DateTime Anio;
        private string DNI;
        private string Telefono;
        //  private string VehiculoElegido;<<<<<<<<<<< revisar por ahi sirve 20/11 22.00
        private string Direccion;
        private string Departamento;
        private string Partido;
        private string Provincia;
        private string Piso;
        private string Mail;
        private string AlturaDireccion;
        private Boolean Estado;

        public Clientes()
        {

        }

   
        public string GetCodPostalCL()
        {
            return CodPostal;
        }
        public void SetCodPostalCL(string NuevoCodPostal)
        {
            CodPostal = NuevoCodPostal;
        }

        public string GetDepartamentoCL()
        {
            return Departamento;
        }
        public void SetDepartamentoCL(string NuevoDep)
        {
           Departamento=NuevoDep;
        }

        public string GetNombreCL()
        {
            return Nombre;
        }
        public void SetNombreCL(string NuevoNombre)
        {
            Nombre = NuevoNombre;
        }

        public string GetApellidoCL()
        {
            return Apellido;
        }
        public void SetApellidoCL(string NuevoApellido)
        {
            Apellido = NuevoApellido;
        }

        public string GetPisoCL()
        {
            return Piso;
        }
        public void SetPisoCL(string NuevoPiso)
        {
           Piso=NuevoPiso;
        }

        public DateTime GetAnioGS()
        {
            return Anio;
        }
        public void SetAnioGS(DateTime NuevoAnio)
        {
            Anio = NuevoAnio;
        }

        public string GetDniCL()
        {
            return DNI;
        }
        public void SetDniCL(string NuevoDNI)
        {
            DNI = NuevoDNI;
        }

        public string GetTelefonoCL()
        {
            return Telefono;
        }
        public void SetTelefonoCL(string NuevoTelefono)
        {
            Telefono = NuevoTelefono;
        }

       /* public string GetVehiculoElegidoCL() <<<<<<<<<<<<por ahi sirve 20/11 22.00
        {
            return VehiculoElegido;
        }
        public void SetVehiculoElegidoCL(string NuevoVehiculo)
        {
            VehiculoElegido = NuevoVehiculo;
        }*/

        public string GetDireccionCL()
        {
            return Direccion;
        }
        public void SetDireccionCL(string NuevoDireccion)
        {
            Direccion = NuevoDireccion;
        }

        public string GetAlturaDireccionCL()
        {
            return AlturaDireccion;
        }
        public void SetAlturaDireccionCL(string NuevaAlturaDireccion)
        {
            AlturaDireccion= NuevaAlturaDireccion;
        }

        public string GetPartidoCL()
        {
            return Partido;
        }
        public void SetPartidoCL(string NuevoPartido)
        {
            Partido = NuevoPartido;
        }

        public string GetProvinciaCL()
        {
            return Provincia;
        }
        public void SetProvinciaCL(string NuevoProvincia)
        {
            Provincia = NuevoProvincia;
        }

        public string GetMailCL()
        {
            return Mail;
        }
        public void SetMailCL(string NuevoMail)
        {
            Mail = NuevoMail;
        }

        public Boolean GetEstadoCL()
        {
            return Estado;
        }
        public void SetEstadoCL(Boolean NuevoEstado)
        {
            Estado = NuevoEstado;
        }
    }
}
        