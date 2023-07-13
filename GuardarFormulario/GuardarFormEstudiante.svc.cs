using DataBaseSQL.Conexiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuardarFormulario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "GuardarFormEstudiante" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione GuardarFormEstudiante.svc o GuardarFormEstudiante.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class GuardarFormEstudiante : IGuardarFormEstudiante
    {
        public void receiveDataForm(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento)
        {
            SaveStudents s = new SaveStudents();
            s.SaveData(nombre, apellido, correo, sexo, direccion, ciudad, requerimiento);
        }
    }
}
