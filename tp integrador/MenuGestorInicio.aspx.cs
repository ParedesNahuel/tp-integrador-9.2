using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace tp_integrador
{
    public partial class WFGestor : System.Web.UI.Page
    {
        negociogestores negges = new negociogestores();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            bool estado = false;
            Gestores perfil = new Gestores();

            estado = negges.verificargestor(txtNombre.Text.Trim(), txtContrasenia.Text.Trim());
            if (estado == true)
            {

                Session["NombreUsuario"] = txtNombre.Text.Trim();


                perfil.SetNombPerfilGS(txtNombre.Text);
               negges.get(perfil);
                Session["NivelUsuario"] = perfil.GetNivelGS();

                if (perfil.GetNivelGS() == 1)
                {
                    Response.Redirect("MenuGestoria.aspx");
                    
                }
                else
                {
                    Response.Redirect("MenuGestoriaMaster.aspx");

                }
            }
            else
            {
                lblConfirmado.Text = "mal ingresado el nombre o la contraseña";

            }
        }

        
    }
}