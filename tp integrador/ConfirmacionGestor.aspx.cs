using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_integrador
{
    public partial class ConfirmacionGestor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null && Session["contrasena"] != null)
            {
                lblPerfil.Text = Session["NombreUsuario"].ToString();
                lblContrasenia.Text = Session["contrasena"].ToString();
            }
        }
    }
}