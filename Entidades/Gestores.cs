using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gestores
    {
        string Matricula;
        string DNI;
        string Nombre;
        string Apellido;
        DateTime Año;
        string Mail;
        string NombPerfil;
        string Contrasena;
        int Nivel;
        bool Estado;
        
        public Gestores()
        {
            //por aca nos quedamos.
        }

        /*public string MatriculaGS { get => Matricula; set => Matricula = value; }
        public string NombreGS { get => Nombre; set => Nombre = value; }
        public string ApellidoGS { get => Apellido; set => Apellido = value; }
        public DateTime AñoGS { get => Año; set => Año = value; }
        public string DNIGS { get => DNI; set => DNI = value; }
        public string MailGS { get => Mail; set => Mail = value; }
        public string NumGestorGS { get => NumGestor; set => NumGestor = value; }
        public string ContraseñaGS { get => Contraseña; set => Contraseña = value; }*/


        public string GetMatriculaGS() { return Matricula; }
        public void SetMatriculaGS(string matriculaGS ) { Matricula = matriculaGS; }
        public string GetDniGS() { return DNI; }
        public void SetDniGS(string DNIGS) { DNI = DNIGS; }
        public string GetNombreGS() { return Nombre; }
        public void SetNombreGS(string NombreGS ) { Nombre = NombreGS; }
        public string GetApellidoGS() { return Apellido; }
        public void SetApellidoGS(string ApellidoGS) { Apellido = ApellidoGS; }
        public DateTime GetAnioGS() { return Año; }
        public void SetAnioGS( DateTime Nanio) { Año = Nanio; }
        public string GetMailGS() { return Mail; }
        public void SetMailGS(string MailGS) { Mail = MailGS; }
        public string GetNombPerfilGS() { return NombPerfil; }
        public void SetNombPerfilGS(string NombPerfilGS) { NombPerfil = NombPerfilGS; }
        public string GetContrasenaGS() { return Contrasena; }
        public void SetContrasenaGS(string ContrasenaGS) { Contrasena = ContrasenaGS; }
        public int GetNivelGS() { return Nivel; }
        public void SetNivelGS (int NivelGS) { Nivel = NivelGS; }
        public bool GetEstadoGS() { return Estado; }
        public void SetEstadoGS (Boolean EstadoGS) { Estado = EstadoGS; }
    }
}
