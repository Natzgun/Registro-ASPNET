using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GuardarFormulario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IGuardarFormEstudiante" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IGuardarFormEstudiante
    {
        [OperationContract]
        void receiveDataForm(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento);
    }
}
