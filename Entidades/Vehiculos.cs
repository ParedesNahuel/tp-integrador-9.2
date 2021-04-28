using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculos
    {
        private string Patente;
        private string CodMarca;
        private string CodModelo;
        private string Color;
        private string gamma;  //----------------------agregado 19/11 12:13 termina misma linea
        private Boolean Estado;
        public Vehiculos()
        {

        }

        //<<<<<<<<<<<<<<<<<<<<<      Contuna por aca >>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        public string GetPatenteVE()
        {
            return Patente;
        }
        public void SetPatenteVE(string NuevoPatenteVE)
        {
            Patente = NuevoPatenteVE;
        }
        public string GetCodMarcaVE()
        {
            return CodMarca;
        }
        public void SetCodMarcaVE(string NuevoCodMarcaVE)
        {
            CodMarca = NuevoCodMarcaVE;
        }
        //----------------------agregado 19/11 12:13
        public string GetGammaVE()
        {
            return gamma;
        }

        public void SetGammaVE( string Ngamma)
        {
            gamma = Ngamma;
        }
        //----------------------termina agregado 19/11 12:13
        public string GetModeloVE()
        {
            return CodModelo;
        }
        public void SetModeloVE(string NuevoModeloVE)
        {
            CodModelo = NuevoModeloVE;
        }

        public string GetColorVE()
        {
            return Color;
        }
        public void SetColorVE(string NuevoColorVE)
        {
            Color = NuevoColorVE;
        }

        public Boolean GetEstadoVE()
        {
            return Estado;
        }
        public void SetEstadoVE(Boolean NuevoEstado)
        {
            Estado = NuevoEstado;
        }
    }
}
