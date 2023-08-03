using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadSession();
            deleteSessions();
        }
        private void loadSession()
        {
            String nombre = (String)(Session["Nombre"]);
            String apellido = (String)(Session["Apellido"]);
            // Asignacion de la informacion a los campos HTML respectivos
            LabelUsuario.Text = "Enviado por Sesion: ";
            LabelNombre.Text = "Nombre: " + nombre;
            LabelApellido.Text = " Apellido: " + apellido;

        }
        private void deleteSessions()
        {
            Session.RemoveAll();
            Session.Abandon();
        }

        /*protected void ButtonCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            string sexo, ciudad;
            if (cookie != null)
            {
                sexo = cookie.Values["sexo"];
                ciudad = cookie.Values["ciudad"];
                string informacion = $"Sexo: {sexo}, Ciudad: {ciudad}";
                areaCookie.Text = informacion;
            }
        }*/

        [WebMethod]
        public static String getInformacion(String valor)
        {
            return "Desde el servidor se recibio :" + valor;
        }
    }
}