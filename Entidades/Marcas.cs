using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marcas
    {
        private string CodMarca;
        private string NombMarca;
        public Marcas()
        {

        }

        /*public string CodMarcaGS { get => CodMarca; set => CodMarca = value; }
        public string MarcaGS { get => Marca; set => Marca = value; }*/
        public string GetCodMarcaMA()
        {
            return CodMarca;
        }
        public void SetCodMarcaMA(string NuevoCodMA)
        {
            CodMarca = NuevoCodMA;
        }

        public string GetNombMarcaMA()
        {
            return NombMarca;
        }
        public void SetNombMarcaMA(string NuevoNombMA)
        {
            NombMarca = NuevoNombMA;
        }
    }
}
