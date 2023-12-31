﻿using DataBaseSQL.Conexiones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ProjectService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IList<String> getCiudades()
        {
            IList<String> ciudades = new List<String>();
            
            Ciudades c = new Ciudades();
            ciudades = c.getCities();
            // En un servicio no usar Server.MapPath como es en el caso de FormStundents
            /* string ruta_base = AppDomain.CurrentDomain.BaseDirectory;
            string ruta_ciudades = Path.Combine(ruta_base, "Data", "CiudadesPeru.txt");

            string[] cities = File.ReadAllLines(ruta_ciudades);
            ciudades = new List<string>(cities); */
    
            return ciudades;
        }
    }
}
