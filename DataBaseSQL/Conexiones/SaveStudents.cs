using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace DataBaseSQL.Conexiones
{
    public class SaveStudents : ISaveStudents
    {
        public void SaveData(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            String validar_sexo = sexo;
            if (validar_sexo == "Masculino")
                validar_sexo = "M";
            else
                validar_sexo = "F";
            string cadena_conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FormStundents;Integrated Security=True";
            string nombreCiudad = ciudad;
            int? idCiudad = ObtenerIdCiudad(nombreCiudad, cadena_conexion);
            if (idCiudad != -1)
            {
                // Insertar datos en la tabla DataAlumnos
                string insertQuery = "INSERT INTO [dbo].[DataAlumnos] (Nombre, Apellidos, Email, Sexo, Direccion, CodeCiudad, Requerimiento) VALUES (@Nombre, @Apellidos, @Email, @Sexo, @Direccion, @CodeCiudad, @Requerimiento)";

                using (SqlConnection connection = new SqlConnection(cadena_conexion))
                {
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellidos", apellido);
                        command.Parameters.AddWithValue("@Email", correo);
                        command.Parameters.AddWithValue("@Sexo", validar_sexo);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@CodeCiudad", idCiudad);
                        command.Parameters.AddWithValue("@Requerimiento", requerimiento);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                // Alguna esxcepcion que por el mommento no es necesario :v
            }

        }
        public static int? ObtenerIdCiudad(string ciudadElegida, string conexion)
        {
            int idCiudad = -1; // Valor predeterminado en caso de no encontrar la ciudad
            string consulta = "SELECT Id FROM [dbo].[DataCiudad] WHERE Ciudad = @Ciudad";
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(consulta, connection))
                {
                    command.Parameters.AddWithValue("@Ciudad", ciudadElegida);

                    connection.Open();
                    int? ciudadId = (int?)command.ExecuteScalar();
                    connection.Close();
                    return ciudadId;
                }
            }

            
        }
    }
}
