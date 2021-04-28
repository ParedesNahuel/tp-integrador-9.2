using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Entidades;
using Negocio;

namespace tp_integrador
{
    public partial class AgregarMarca : System.Web.UI.Page
    {
        NegocioMarcas marc = new NegocioMarcas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }

        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            Boolean estado = false;

            estado = marc.AgregarMarcas(txtNombreMarca.Text, txtCodMarca.Text);
            if (estado == true)
            {
                lblConfirmado.Text = "Marcas agregada con exito";
            }
            else
            {
                lblConfirmado.Text = "NO se pudo agregar marca";
            }
        }
    }
}