﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bancolombia.referenciaServicioWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="referenciaServicioWeb.esteMiWebServicesSoap")]
    public interface esteMiWebServicesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtOperaciones", ReplyAction="*")]
        double mtOperaciones(double Intereses, double Dias);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mtOperaciones", ReplyAction="*")]
        System.Threading.Tasks.Task<double> mtOperacionesAsync(double Intereses, double Dias);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface esteMiWebServicesSoapChannel : Bancolombia.referenciaServicioWeb.esteMiWebServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class esteMiWebServicesSoapClient : System.ServiceModel.ClientBase<Bancolombia.referenciaServicioWeb.esteMiWebServicesSoap>, Bancolombia.referenciaServicioWeb.esteMiWebServicesSoap {
        
        public esteMiWebServicesSoapClient() {
        }
        
        public esteMiWebServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public esteMiWebServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public esteMiWebServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public esteMiWebServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double mtOperaciones(double Intereses, double Dias) {
            return base.Channel.mtOperaciones(Intereses, Dias);
        }
        
        public System.Threading.Tasks.Task<double> mtOperacionesAsync(double Intereses, double Dias) {
            return base.Channel.mtOperacionesAsync(Intereses, Dias);
        }
    }
}