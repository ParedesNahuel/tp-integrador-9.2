using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gammas
    {
        private string CodGamma;
        private string NombGamma;
        private string Descripcion;
        private Boolean Estado;

        public Gammas()
        {

        }

        /* public string CodGammaGS { get => CodGamma; set => CodGamma = value; }
         public string GammaGS { get => Gamma; set => Gamma = value; }
         public string DescripcionGS { get => Descripcion; set => Descripcion = value; }
         public float CostoGS { get => Costo; set => Costo = value; }
         public bool EstadoGS { get => Estado; set => Estado = value; }*/
        public string GetCodGammaGA()
        {
            return CodGamma;
        }
        public void SetCodGammaGA(string NuevoCodGA)
        {
            CodGamma = NuevoCodGA;
        }

        public string GetNombGammaGA()
        {
            return NombGamma;
        }
        public void SetNombGammaGA(string NuevoNombGA)
        {
            NombGamma = NuevoNombGA;
        }

        public string GetDescripcionGA()
        {
            return Descripcion;
        }
        public void SetDescripcionGA(string NuevoDescripcion)
        {
            Descripcion = NuevoDescripcion;
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
