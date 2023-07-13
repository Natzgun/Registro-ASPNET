using DataBaseSQL.Conexiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQL
{
    class DBConnection
    {
        public static void Main(string[] args)
        {
            DBConnection db = new DBConnection();
            db.query();
            db.querySave();
            Console.ReadKey();
        }

        private void query ()
        {
            Ciudades city = new Ciudades();
            IList<String> cities = city.getCities();
            if (cities == null)
            {
                Console.WriteLine("La base de datos esta vacia");
                return;
            }
            foreach (String c in cities)                                 
            {
                Console.WriteLine(c);
            }
        }
        private void querySave()
        {
            SaveStudents ss = new SaveStudents();
            ss.SaveData("Erick", "Malcoaccha", "uwu@unsa.edu.pe", "Masculino", "Calle dean valdivia", "Arequipa","Aqui deberia ir algo");
        }
    }
}