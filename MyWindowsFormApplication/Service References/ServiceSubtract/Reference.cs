﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWindowsFormApplication.ServiceSubtract {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSubtract.SubtractTwoNumbersSoap")]
    public interface SubtractTwoNumbersSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubtractNumbers", ReplyAction="*")]
        decimal SubtractNumbers(decimal numberOne, decimal numberTwo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubtractNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> SubtractNumbersAsync(decimal numberOne, decimal numberTwo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SubtractTwoNumbersSoapChannel : MyWindowsFormApplication.ServiceSubtract.SubtractTwoNumbersSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SubtractTwoNumbersSoapClient : System.ServiceModel.ClientBase<MyWindowsFormApplication.ServiceSubtract.SubtractTwoNumbersSoap>, MyWindowsFormApplication.ServiceSubtract.SubtractTwoNumbersSoap {
        
        public SubtractTwoNumbersSoapClient() {
        }
        
        public SubtractTwoNumbersSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SubtractTwoNumbersSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubtractTwoNumbersSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SubtractTwoNumbersSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal SubtractNumbers(decimal numberOne, decimal numberTwo) {
            return base.Channel.SubtractNumbers(numberOne, numberTwo);
        }
        
        public System.Threading.Tasks.Task<decimal> SubtractNumbersAsync(decimal numberOne, decimal numberTwo) {
            return base.Channel.SubtractNumbersAsync(numberOne, numberTwo);
        }
    }
}
