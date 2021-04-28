using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pantalla_de_pruebas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["NombreUsuario"] != null)
            {
                LblNombreGestor.Text = Session["NombreUsuario"].ToString(); //probar si recibe bien el session
            }
            
            
        }
    }
}