﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _7App5.SR {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/F4", ReplyAction="http://tempuri.org/IService1/F4Response")]
        int F4(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/F4", ReplyAction="http://tempuri.org/IService1/F4Response")]
        System.Threading.Tasks.Task<int> F4Async(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllElements", ReplyAction="http://tempuri.org/IService1/GetAllElementsResponse")]
        System.Data.DataTable GetAllElements();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllElements", ReplyAction="http://tempuri.org/IService1/GetAllElementsResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetAllElementsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetElementByID", ReplyAction="http://tempuri.org/IService1/GetElementByIDResponse")]
        System.Data.DataTable GetElementByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetElementByID", ReplyAction="http://tempuri.org/IService1/GetElementByIDResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetElementByIDAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : _7App5.SR.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<_7App5.SR.IService1>, _7App5.SR.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int F4(int x, int y) {
            return base.Channel.F4(x, y);
        }
        
        public System.Threading.Tasks.Task<int> F4Async(int x, int y) {
            return base.Channel.F4Async(x, y);
        }
        
        public System.Data.DataTable GetAllElements() {
            return base.Channel.GetAllElements();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetAllElementsAsync() {
            return base.Channel.GetAllElementsAsync();
        }
        
        public System.Data.DataTable GetElementByID(int ID) {
            return base.Channel.GetElementByID(ID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetElementByIDAsync(int ID) {
            return base.Channel.GetElementByIDAsync(ID);
        }
    }
}
