using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using Laboratorio2.ServiceReference1;
using Laboratorio2.ServiceReference2;
using System.ServiceModel;
using Laboratorio2.ServiceReference3;
using System.Web.Services;
using System.Data.SqlClient;

namespace Laboratorio2
{
    public partial class FormStudents : System.Web.UI.Page
    {
        protected void Page_load(object sender, EventArgs e)
        {
            // cargar_ciudades();
            String[] ciudades = serviceCall();

            for (int i = 0; i < ciudades.Length; i++)
            {
                ListItem item = new ListItem(ciudades[i], ciudades[i]);
                DropDownList1.Items.Add(item);
            }
        }

        private String[] serviceCall()
        {
            Service1Client client = new Service1Client();
            String[] ciudades = client.getCiudades();
            Array.Sort(ciudades);
            return ciudades;
        }

        private void sendData(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            GuardarFormEstudianteClient send = new GuardarFormEstudianteClient();
            send.receiveDataForm(nombre, apellido, correo, sexo, direccion, ciudad, requerimiento);
        }
        protected void ButtonSend_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string lastName = apellidoInput.Text;
            string email = emailInput.Text;
            string radioInpt = radioM.Checked ? "Masculino" : "Femenino";
            string address = addressInput.Text;
            string city = DropDownList1.SelectedValue;
            string reqArea = requiredArea.Text;

            string[] info = new string[7] { name, lastName, email, radioInpt, address, city, reqArea };
            string[] tags = { "Nombre: ", "Apellido: ", "Correo: ", "Sexo: ", "Direccion: ", "Ciudad: ", "Requerimiento: " };

            // En esta parte llamaraemos al servicio para almacenar los datos
            sendData(name, lastName, email, radioInpt, address, city, reqArea );
            
            for (int i = 0; i < info.Length; i++)
            {
                if (info[i] == "")
                {
                    List<string> infoList = new List<string>(info);
                    infoList.RemoveAt(i);
                    info = infoList.ToArray();

                    List<string> tagList = new List<string>(tags);
                    tagList.RemoveAt(i);
                    tags = tagList.ToArray();
                }

            }

            for (int i = 0; i < info.Length; i++)
            {
                Literal literal = new Literal();
                literal.Text = "<p class='mb-1'>" + tags[i] + info[i] + "</p>";
                datosDiv.Controls.Add(literal);
            }

            // Aqui vamos a hacer todo lo relacionado con Cookies
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie.Values["Sexo"] = radioInpt;
            cookie.Values["Ciudad"] = city;
            cookie.HttpOnly = false;
            Response.Cookies.Add(cookie);
            createSession(name, lastName);
            Response.Redirect("Auxiliar");

        }

        private void createSession(String nombre, String apellido)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellido;
        }

        [WebMethod]
        public static String getInfo(String name, String lastname)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FormStundents;Integrated Security=True";

            string query = "SELECT COUNT(*) FROM DataAlumnos WHERE Nombre = @name AND Apellidos = @lastname";

            int count = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
            }

            if (count > 0)
            {
                return "El usuario " + name + " " + lastname + " ya está registrado.";
            }
            else
            {
                return "El usuario " + name + " " + lastname + " no está registrado.";
            }

        }
    }
}