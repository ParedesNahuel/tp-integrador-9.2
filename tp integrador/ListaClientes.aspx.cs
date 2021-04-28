using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using System.Data;

namespace tp_integrador
{
    public partial class ListaClientes : System.Web.UI.Page
    {
        NegocioClientes neg = new NegocioClientes();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTable tablaMarcas = neg.getTabla();
                grdClientes.DataSource = tablaMarcas;
                grdClientes.DataBind();
            }

            if (Session["NombreUsuario"] != null)
            {
                lblUsuario.Text = Session["NombreUsuario"].ToString();
            }
        }



        protected void grdClientes_RowEditing(object sender, GridViewEditEventArgs e)
        {


            grdClientes.EditIndex = e.NewEditIndex;
            DataTable tablaclientes = neg.getTabla();
            grdClientes.DataSource = tablaclientes;
            grdClientes.DataBind();
        }

        protected void grdClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            NegocioClientes neg = new NegocioClientes();

            String dni_cl = ((Label)grdClientes.Rows[e.RowIndex].FindControl("lblDni")).Text;

            Clientes cli = new Clientes();

            cli.SetDniCL(dni_cl);


           // neg.eliminarClientes(dni_cl);

            DataTable tablaMarcas = neg.getTabla();
            grdClientes.DataSource = tablaMarcas;
            grdClientes.DataBind();

        }

        protected void grdClientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_dni = ((Label)grdClientes.Rows[e.RowIndex].FindControl("lblDni")).Text;
            String s_nombre = ((TextBox)grdClientes.Rows[e.RowIndex].FindControl("TbNombre")).Text;
            String s_apellido = ((TextBox)grdClientes.Rows[e.RowIndex].FindControl("TbApellido")).Text;
            String s_telefono = ((TextBox)grdClientes.Rows[e.RowIndex].FindControl("tbTelefono")).Text;
            String s_mail = ((TextBox)grdClientes.Rows[e.RowIndex].FindControl("TbMail")).Text;

            NegocioClientes neg = new NegocioClientes();
            Clientes cli = new Clientes();
            cli.SetDniCL(s_dni);
            cli.SetNombreCL(s_nombre);
            cli.SetApellidoCL(s_apellido);
            cli.SetTelefonoCL(s_telefono);
            cli.SetMailCL(s_mail);


          //  neg.AgregarClientes(s_dni, s_nombre, s_apellido, s_telefono, s_mail);

            grdClientes.EditIndex = -1;


            DataTable tablaMarcas = neg.getTabla();
            grdClientes.DataSource = tablaMarcas;
            grdClientes.DataBind();

        }
    }
}