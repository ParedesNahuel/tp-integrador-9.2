using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;
using Negocio;


namespace tp_integrador
{
    public partial class RegistroGestor : System.Web.UI.Page
    {
        negociogestores Ngestor = new negociogestores();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Boolean comando = false;

            Gestores gesto = new Gestores();

            gesto.SetMatriculaGS(txtMatricula.Text.Trim());
            gesto.SetDniGS(txtDni.Text.Trim());
            gesto.SetNombreGS(txtNombre.Text);
            gesto.SetApellidoGS(txtApellido.Text);
            gesto.SetAnioGS(Convert.ToDateTime(txtFecha.Text));///revisar q envie en el correcto
            gesto.SetMailGS(txtMail.Text.Trim());
            gesto.SetNombPerfilGS(txtPerfil.Text.Trim());
            gesto.SetContrasenaGS(txtContrasenia.Text.Trim());
            gesto.SetNivelGS(1);
            gesto.SetEstadoGS(true);

            comando = Ngestor.AgregarGestores(gesto);

            if (comando == true)
            {
                Session["NombreUsuario"] = txtPerfil.Text.Trim();
                Session["contrasena"] = txtContrasenia.Text.Trim();
                Response.Redirect("ConfirmacionGestor.aspx");

            }
            else
            {
                lblConfirmado.Text = "no se registro al gestor reintente"; //por ahora sirve pero cambiar por reponse
            }

        }
    }
}