﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaptorBackground.RaptorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RaptorService.IRaptorAPI")]
    public interface IRaptorAPI {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/CheckEmail", ReplyAction="http://tempuri.org/IRaptorAPI/CheckEmailResponse")]
        bool CheckEmail(string emailAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/CheckEmail", ReplyAction="http://tempuri.org/IRaptorAPI/CheckEmailResponse")]
        System.Threading.Tasks.Task<bool> CheckEmailAsync(string emailAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/RegisterUser", ReplyAction="http://tempuri.org/IRaptorAPI/RegisterUserResponse")]
        bool RegisterUser(string userName, string userCountry, string emailAddress, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/RegisterUser", ReplyAction="http://tempuri.org/IRaptorAPI/RegisterUserResponse")]
        System.Threading.Tasks.Task<bool> RegisterUserAsync(string userName, string userCountry, string emailAddress, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/DeleteUser", ReplyAction="http://tempuri.org/IRaptorAPI/DeleteUserResponse")]
        bool DeleteUser(string userName, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRaptorAPI/DeleteUser", ReplyAction="http://tempuri.org/IRaptorAPI/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(string userName, string Password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRaptorAPIChannel : RaptorBackground.RaptorService.IRaptorAPI, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RaptorAPIClient : System.ServiceModel.ClientBase<RaptorBackground.RaptorService.IRaptorAPI>, RaptorBackground.RaptorService.IRaptorAPI {
        
        public RaptorAPIClient() {
        }
        
        public RaptorAPIClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RaptorAPIClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RaptorAPIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RaptorAPIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckEmail(string emailAddress) {
            return base.Channel.CheckEmail(emailAddress);
        }
        
        public System.Threading.Tasks.Task<bool> CheckEmailAsync(string emailAddress) {
            return base.Channel.CheckEmailAsync(emailAddress);
        }
        
        public bool RegisterUser(string userName, string userCountry, string emailAddress, string Password) {
            return base.Channel.RegisterUser(userName, userCountry, emailAddress, Password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterUserAsync(string userName, string userCountry, string emailAddress, string Password) {
            return base.Channel.RegisterUserAsync(userName, userCountry, emailAddress, Password);
        }
        
        public bool DeleteUser(string userName, string Password) {
            return base.Channel.DeleteUser(userName, Password);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(string userName, string Password) {
            return base.Channel.DeleteUserAsync(userName, Password);
        }
    }
}