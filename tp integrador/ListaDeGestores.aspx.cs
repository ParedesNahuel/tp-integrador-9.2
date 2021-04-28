using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;

namespace tp_integrador
{
    public partial class ListaDeGestores : System.Web.UI.Page
    {
      negociogestores neg = new negociogestores();
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlDataSource1.SelectCommand = "SELECT matricula_ge AS Matricula, dni_ge AS DNI, nombre_ge AS Nombre, apellido_ge AS Apellido, nacimiento_ge AS Nacimiento, mail_ge AS Mail, nombre_perfil_ge AS [Nombre de perfil] FROM Gestores";
            if (!IsPostBack)
            {
                DataTable  tablaGestores = neg.getTabla();
                grvgestores.DataSource = tablaGestores;
                grvgestores.DataBind();
            }
        }

        protected void grvgestores_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            negociogestores neg = new negociogestores();
            string s_matricula = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_it_matricula")).Text;

            Gestores ges = new Gestores();

            ges.SetMatriculaGS(s_matricula);


            neg.EliminarGestores(s_matricula);

            DataTable tablaGestores = neg.getTabla();
            grvgestores.DataSource = tablaGestores;
            grvgestores.DataBind();
        }

        protected void grvgestores_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvgestores.EditIndex = e.NewEditIndex;
            DataTable tablaGestores = neg.getTabla();
            grvgestores.DataSource = tablaGestores;
            grvgestores.DataBind();

        }

        protected void grvgestores_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvgestores.EditIndex = -1;
            DataTable tablaGestores = neg.getTabla();
            grvgestores.DataSource = tablaGestores;
            grvgestores.DataBind();
        }

        protected void grvgestores_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_matricula = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_matricula")).Text;
            String s_dni = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_dni")).Text;
            String s_nombre = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text;
            String s_apellido = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_eit_apellido")).Text;
            //string s_nacimiento = Convert.ToString((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_apellido"));
            DateTime s_nacimiento = Convert.ToDateTime(((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_nacimiento")).Text);
            //string s_nacimiento = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_nacimiento")).Text;
            String s_mail = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_mail")).Text;
            String s_perfil = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_eit_perfil")).Text;
            string s_contrasena = ((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_dni")).Text;
            int s_nivel = Convert.ToInt32(((Label)grvgestores.Rows[e.RowIndex].FindControl("lbl_eit_dni")).Text);
            Boolean s_estado = true;

            //negociogestores neg = negociogestores();
            Gestores ges = new Gestores();
            ges.SetMatriculaGS(s_matricula);
            ges.SetDniGS(s_dni);
            ges.SetNombreGS(s_nombre);
            ges.SetApellidoGS(s_apellido);
            ges.SetAnioGS(s_nacimiento);
            //ges.GetAnioGS(); 
           // ges.SetAnioGS(Convert.ToDateTime(s_nacimiento));
            ges.SetMailGS(s_mail);
            ges.SetNombPerfilGS(s_perfil);
            ges.SetContrasenaGS(s_contrasena);
            ges.SetNivelGS(s_nivel);
            ges.SetEstadoGS(s_estado);

            negociogestores nego = new negociogestores();

            nego.AgregarGestores(ges);
            grvgestores.EditIndex = -1;
            DataTable tablaGestores = neg.getTabla();
            grvgestores.DataSource = tablaGestores;
            grvgestores.DataBind();
        }
    }
}
        /* protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
         {
             grvgestores.EditIndex = e.NewEditIndex;

             DataTable tablaGestores = neg.getTabla();
             grvgestores.DataSource = tablaGestores; 
             grvgestores.DataBind();
            /* grvgestores.EditIndex = e.NewEditIndex;
             SqlDataSource1.SelectCommand = "SELECT * FROM Gestores";*/


        /*protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string s_matricula = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_matricula_ge")).Text;
            string s_dni = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_dni_ge")).Text;
            string s_nombre = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_nombre_ge")).Text;
            string s_apellido = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_apellido_ge")).Text;
            string s_nacimiento = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_nacimiento_ge")).Text;
            string s_mail = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_mail_ge")).Text;
            string s_perfil = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_perfil_ge")).Text;
            string s_contrasena = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_contrasena_ge")).Text;
            string s_nivel = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_nivel_ge")).Text;
            string s_estado = ((Label)grvgestores.Rows[e.NewSelectedIndex].FindControl("lbl_estado_ge")).Text;
        }*/

       /* protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvgestores.EditIndex = -1;
            SqlDataSource1.SelectCommand = "SELECT * FROM Gestores";

        }*/


        /* protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
         {
             negociogestores ges = new negociogestores();
             string s_matricula = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_matricula_ge")).Text;
             string s_dni = ((Label)grvgestores.Rows[e.RowIndex].FindControl("txt_dnied_ge")).Text;
             string s_nombre = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_nombre_ge")).Text;
             string s_apellido = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_apellido_ge")).Text;
             DateTime s_nacimiento = Convert.ToDateTime(((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_nacimientoed_ge")).Text);
             string s_mail = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_mail_ge")).Text;
             string s_perfil = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_perfil_ge")).Text;
             string s_contrasena = ((TextBox)grvgestores.Rows[e.RowIndex].FindControl("ltxt_contrasena_ge")).Text;
             int s_nivel = Convert.ToInt32(((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_nivel_ge")).Text);
             bool s_estado =  Convert.ToBoolean(((TextBox)grvgestores.Rows[e.RowIndex].FindControl("txt_estado_ge")).Text);
             Gestores GE = new Gestores();
             GE.SetDniGS(s_dni);
             GE.SetMatriculaGS(s_matricula);
             GE.SetNombreGS(s_nombre);
             GE.SetApellidoGS(s_apellido);
             GE.SetAnioGS(s_nacimiento);
             GE.SetMailGS(s_mail);
             GE.SetNombPerfilGS(s_perfil);
             GE.SetContrasenaGS(s_contrasena);
             GE.SetNivelGS(s_nivel);
             GE.SetEstadoGS(s_estado);
             grvgestores.EditIndex = -1;
             ges.AgregarGestores(GE);
             SqlDataSource1.SelectCommand = "SELECT * FROM Gestores";*/


    /*protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //negociogestores neg = new negociogestores();
        string s_matricula = ((Label)grvgestores.Rows[e.RowIndex].FindControl("txt_matricula_ge")).Text;

        Gestores ges = new Gestores();

        ges.SetMatriculaGS(s_matricula);


        neg.EliminarGestores(s_matricula);

        DataTable tablaGestores = neg.getTabla();
        grvgestores.DataSource = tablaGestores;
        grvgestores.DataBind();
    }*/

