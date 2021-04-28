using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class NegocioGamma
    {
        public DataTable getTabla()
        {
            DatosGamma dato = new DatosGamma();
            return dato.getTablaGammas();
        }

        public Gammas get(string cod)
        {
            DatosGamma dato = new DatosGamma();
            Gammas gam = new Gammas();
            gam.SetCodGammaGA(cod);
            return dato.GetGammas(gam);
        }

        public bool eliminarGammas(string cod)
        {
            //Validar si existente 
            DatosGamma dato = new DatosGamma();
            Gammas gam = new Gammas ();
            gam.SetCodGammaGA(cod);
            int op = dato.eliminarGammas(gam);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarGammas(String nomb)
        {
            int cantFilas = 0;

            Gammas gam = new Gammas();
            gam.SetNombGammaGA(nomb);

            DatosGamma dato = new DatosGamma();
            if (dato.existeGammas(gam) == false)
            {
                cantFilas = dato.agregarGamma(gam);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }
}
