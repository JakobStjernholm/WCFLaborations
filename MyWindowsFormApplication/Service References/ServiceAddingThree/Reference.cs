﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWindowsFormApplication.ServiceAddingThree {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceAddingThree.AddingThreeNumbersSoap")]
    public interface AddingThreeNumbersSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        decimal AddThreeNumbers(decimal numberOne, decimal numberTwo, decimal numberThree);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddThreeNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> AddThreeNumbersAsync(decimal numberOne, decimal numberTwo, decimal numberThree);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AddingThreeNumbersSoapChannel : MyWindowsFormApplication.ServiceAddingThree.AddingThreeNumbersSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddingThreeNumbersSoapClient : System.ServiceModel.ClientBase<MyWindowsFormApplication.ServiceAddingThree.AddingThreeNumbersSoap>, MyWindowsFormApplication.ServiceAddingThree.AddingThreeNumbersSoap {
        
        public AddingThreeNumbersSoapClient() {
        }
        
        public AddingThreeNumbersSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddingThreeNumbersSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddingThreeNumbersSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddingThreeNumbersSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal AddThreeNumbers(decimal numberOne, decimal numberTwo, decimal numberThree) {
            return base.Channel.AddThreeNumbers(numberOne, numberTwo, numberThree);
        }
        
        public System.Threading.Tasks.Task<decimal> AddThreeNumbersAsync(decimal numberOne, decimal numberTwo, decimal numberThree) {
            return base.Channel.AddThreeNumbersAsync(numberOne, numberTwo, numberThree);
        }
    }
}