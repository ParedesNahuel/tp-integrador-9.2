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
    public class negociogestores
    {
        public DataTable getTabla()
        {
            datosgestor dato = new datosgestor();
            return dato.GetTablaGestores();
        }

        /*public Gestores get(Gestores cod)
        {
            datosgestor dato = new datosgestor();
            Gestores ges = new Gestores();
            ges.SetMatriculaGS(cod);
            return dato.getGestores(ges);
        }*/

        public Gestores get(Gestores ges)
        {
            datosgestor dato = new datosgestor();
            return dato.getGestores(ges);

        }

        public bool verificargestor(string nombrePer, string contrasena)
        {
            Gestores ges = new Gestores();

            ges.SetNombPerfilGS(nombrePer);
            ges.SetContrasenaGS(contrasena);
            datosgestor dtg = new datosgestor();
            if(dtg.existegestor(ges) == true)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }

        public bool EliminarGestores(string cod)
        {
            //Validar si existente 
           datosgestor dato = new datosgestor();
           Gestores ges = new Gestores();
            ges.SetMatriculaGS(cod);
            int op = dato.EliminarGestores(ges);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool AgregarGestores(Gestores ges)
        {
            int cantFilas = 0;

            datosgestor dato = new datosgestor();
            if (dato.existegestor(ges) == false)
            {
                cantFilas = dato.AgregarGestores(ges);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;

        }

    }
}
