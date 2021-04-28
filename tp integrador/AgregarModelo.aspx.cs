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
    public partial class AgregarModelo : System.Web.UI.Page
    {
        NegocioModelos Nmodelo = new NegocioModelos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
           Boolean comando = false;

            Modelos model = new Modelos();

            model.SetCodMarcaMO(txtCodMarca.Text.Trim());
            model.SetCodModeloMO(txtCodModelo.Text.Trim());
            model.SetCodGammaMO(txtGamma.Text.Trim());
            model.SetNombModeloMO(txtNombre.Text);
            model.SetTipoMO(txtTipo.Text);
            model.SetCantPuertaMO(TxtPuertas.Text);

            comando = Nmodelo.agregarModelos(model);

            if (comando== true)
            {
                lblConfirmado.Text = "Registro exitoso!!";
            }
            else
            {
                lblConfirmado.Text = "ERROR al registrar intente nuevamente";
            }

        }
    }
}