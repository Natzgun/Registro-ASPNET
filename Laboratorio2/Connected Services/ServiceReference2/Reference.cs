﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio2.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IServiceSave")]
    public interface IServiceSave {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSave/receiveData", ReplyAction="http://tempuri.org/IServiceSave/receiveDataResponse")]
        void receiveDataForm(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSave/receiveData", ReplyAction="http://tempuri.org/IServiceSave/receiveDataResponse")]
        System.Threading.Tasks.Task receiveDataAsync(string[] data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSaveChannel : Laboratorio2.ServiceReference2.IServiceSave, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSaveClient : System.ServiceModel.ClientBase<Laboratorio2.ServiceReference2.IServiceSave>, Laboratorio2.ServiceReference2.IServiceSave {
        
        public ServiceSaveClient() {
        }
        
        public ServiceSaveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSaveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSaveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSaveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void receiveDataForm(string nombre, string apellido, string correo, string sexo, string direccion, string ciudad, string requerimiento) {
            base.Channel.receiveDataForm(nombre,apellido,correo,sexo,direccion,ciudad,requerimiento);
        }
        
        public System.Threading.Tasks.Task receiveDataAsync(string[] data) {
            return base.Channel.receiveDataAsync(data);
        }
    }
}
