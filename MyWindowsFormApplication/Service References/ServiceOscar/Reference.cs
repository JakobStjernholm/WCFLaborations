﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWindowsFormApplication.ServiceOscar {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceOscar.OscarServiceSoap")]
    public interface OscarServiceSoap {
        
        // CODEGEN: Generating message contract since element name GetAllYearsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllYears", ReplyAction="*")]
        MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse GetAllYears(MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllYears", ReplyAction="*")]
        System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse> GetAllYearsAsync(MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest request);
        
        // CODEGEN: Generating message contract since element name year from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWinnerForSelectedYear", ReplyAction="*")]
        MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse GetWinnerForSelectedYear(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetWinnerForSelectedYear", ReplyAction="*")]
        System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse> GetWinnerForSelectedYearAsync(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllYearsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllYears", Namespace="http://tempuri.org/", Order=0)]
        public MyWindowsFormApplication.ServiceOscar.GetAllYearsRequestBody Body;
        
        public GetAllYearsRequest() {
        }
        
        public GetAllYearsRequest(MyWindowsFormApplication.ServiceOscar.GetAllYearsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllYearsRequestBody {
        
        public GetAllYearsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllYearsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllYearsResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyWindowsFormApplication.ServiceOscar.GetAllYearsResponseBody Body;
        
        public GetAllYearsResponse() {
        }
        
        public GetAllYearsResponse(MyWindowsFormApplication.ServiceOscar.GetAllYearsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllYearsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyWindowsFormApplication.ServiceOscar.ArrayOfString GetAllYearsResult;
        
        public GetAllYearsResponseBody() {
        }
        
        public GetAllYearsResponseBody(MyWindowsFormApplication.ServiceOscar.ArrayOfString GetAllYearsResult) {
            this.GetAllYearsResult = GetAllYearsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWinnerForSelectedYearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWinnerForSelectedYear", Namespace="http://tempuri.org/", Order=0)]
        public MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequestBody Body;
        
        public GetWinnerForSelectedYearRequest() {
        }
        
        public GetWinnerForSelectedYearRequest(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWinnerForSelectedYearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string year;
        
        public GetWinnerForSelectedYearRequestBody() {
        }
        
        public GetWinnerForSelectedYearRequestBody(string year) {
            this.year = year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetWinnerForSelectedYearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetWinnerForSelectedYearResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponseBody Body;
        
        public GetWinnerForSelectedYearResponse() {
        }
        
        public GetWinnerForSelectedYearResponse(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetWinnerForSelectedYearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetWinnerForSelectedYearResult;
        
        public GetWinnerForSelectedYearResponseBody() {
        }
        
        public GetWinnerForSelectedYearResponseBody(string GetWinnerForSelectedYearResult) {
            this.GetWinnerForSelectedYearResult = GetWinnerForSelectedYearResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OscarServiceSoapChannel : MyWindowsFormApplication.ServiceOscar.OscarServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OscarServiceSoapClient : System.ServiceModel.ClientBase<MyWindowsFormApplication.ServiceOscar.OscarServiceSoap>, MyWindowsFormApplication.ServiceOscar.OscarServiceSoap {
        
        public OscarServiceSoapClient() {
        }
        
        public OscarServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OscarServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OscarServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OscarServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse MyWindowsFormApplication.ServiceOscar.OscarServiceSoap.GetAllYears(MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest request) {
            return base.Channel.GetAllYears(request);
        }
        
        public MyWindowsFormApplication.ServiceOscar.ArrayOfString GetAllYears() {
            MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest inValue = new MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest();
            inValue.Body = new MyWindowsFormApplication.ServiceOscar.GetAllYearsRequestBody();
            MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse retVal = ((MyWindowsFormApplication.ServiceOscar.OscarServiceSoap)(this)).GetAllYears(inValue);
            return retVal.Body.GetAllYearsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse> MyWindowsFormApplication.ServiceOscar.OscarServiceSoap.GetAllYearsAsync(MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest request) {
            return base.Channel.GetAllYearsAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetAllYearsResponse> GetAllYearsAsync() {
            MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest inValue = new MyWindowsFormApplication.ServiceOscar.GetAllYearsRequest();
            inValue.Body = new MyWindowsFormApplication.ServiceOscar.GetAllYearsRequestBody();
            return ((MyWindowsFormApplication.ServiceOscar.OscarServiceSoap)(this)).GetAllYearsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse MyWindowsFormApplication.ServiceOscar.OscarServiceSoap.GetWinnerForSelectedYear(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest request) {
            return base.Channel.GetWinnerForSelectedYear(request);
        }
        
        public string GetWinnerForSelectedYear(string year) {
            MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest inValue = new MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest();
            inValue.Body = new MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequestBody();
            inValue.Body.year = year;
            MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse retVal = ((MyWindowsFormApplication.ServiceOscar.OscarServiceSoap)(this)).GetWinnerForSelectedYear(inValue);
            return retVal.Body.GetWinnerForSelectedYearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse> MyWindowsFormApplication.ServiceOscar.OscarServiceSoap.GetWinnerForSelectedYearAsync(MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest request) {
            return base.Channel.GetWinnerForSelectedYearAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearResponse> GetWinnerForSelectedYearAsync(string year) {
            MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest inValue = new MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequest();
            inValue.Body = new MyWindowsFormApplication.ServiceOscar.GetWinnerForSelectedYearRequestBody();
            inValue.Body.year = year;
            return ((MyWindowsFormApplication.ServiceOscar.OscarServiceSoap)(this)).GetWinnerForSelectedYearAsync(inValue);
        }
    }
}