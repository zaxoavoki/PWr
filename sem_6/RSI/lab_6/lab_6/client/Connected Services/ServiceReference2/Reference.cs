﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IAsyncCCalculator")]
    public interface IAsyncCCalculator {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAsyncCCalculator/Fun1")]
        void Fun1(string s1);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IAsyncCCalculator/Fun1")]
        System.Threading.Tasks.Task Fun1Async(string s1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsyncCCalculator/Fun2", ReplyAction="http://tempuri.org/IAsyncCCalculator/Fun2Response")]
        void Fun2(string s2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsyncCCalculator/Fun2", ReplyAction="http://tempuri.org/IAsyncCCalculator/Fun2Response")]
        System.Threading.Tasks.Task Fun2Async(string s2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAsyncCCalculatorChannel : client.ServiceReference2.IAsyncCCalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsyncCCalculatorClient : System.ServiceModel.ClientBase<client.ServiceReference2.IAsyncCCalculator>, client.ServiceReference2.IAsyncCCalculator {
        
        public AsyncCCalculatorClient() {
        }
        
        public AsyncCCalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsyncCCalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsyncCCalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsyncCCalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Fun1(string s1) {
            base.Channel.Fun1(s1);
        }
        
        public System.Threading.Tasks.Task Fun1Async(string s1) {
            return base.Channel.Fun1Async(s1);
        }
        
        public void Fun2(string s2) {
            base.Channel.Fun2(s2);
        }
        
        public System.Threading.Tasks.Task Fun2Async(string s2) {
            return base.Channel.Fun2Async(s2);
        }
    }
}
