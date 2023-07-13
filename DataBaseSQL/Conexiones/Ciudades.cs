using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseSQL.Conexiones
{
    public class Ciudades : ICiudades
    {
        public IList<String> getCities()
        {
            IList<String> ciudadesDB = new List<String>();
            // cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FormStundents;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            //SqlConnection connection = new SqlConnection(cadenaConexion);
            string conexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FormStundents;Integrated Security=True";
            string consulta = "SELECT Ciudad FROM [dbo].[DataCiudad]";
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null ;
            try
            {
                connection = new SqlConnection(conexion);
                connection.Open();
                cmd = new SqlCommand(consulta, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ciudad = reader.GetString(0); 
                    ciudadesDB.Add(ciudad);
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                connection.Close();
                connection.Dispose();
                
            }
            return ciudadesDB;
        }
    }
}
