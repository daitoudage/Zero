﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero.Service.FileUploadService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FileUploadService.FileUploadServiceSoap")]
    public interface FileUploadServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Zero.Service.FileUploadService.HelloWorldResponse HelloWorld(Zero.Service.FileUploadService.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Zero.Service.FileUploadService.HelloWorldResponse> HelloWorldAsync(Zero.Service.FileUploadService.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 image 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Upload", ReplyAction="*")]
        Zero.Service.FileUploadService.UploadResponse Upload(Zero.Service.FileUploadService.UploadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Upload", ReplyAction="*")]
        System.Threading.Tasks.Task<Zero.Service.FileUploadService.UploadResponse> UploadAsync(Zero.Service.FileUploadService.UploadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Zero.Service.FileUploadService.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Zero.Service.FileUploadService.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Zero.Service.FileUploadService.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Zero.Service.FileUploadService.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Upload", Namespace="http://tempuri.org/", Order=0)]
        public Zero.Service.FileUploadService.UploadRequestBody Body;
        
        public UploadRequest() {
        }
        
        public UploadRequest(Zero.Service.FileUploadService.UploadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public byte[] image;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string path;
        
        public UploadRequestBody() {
        }
        
        public UploadRequestBody(byte[] image, string path) {
            this.image = image;
            this.path = path;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadResponse", Namespace="http://tempuri.org/", Order=0)]
        public Zero.Service.FileUploadService.UploadResponseBody Body;
        
        public UploadResponse() {
        }
        
        public UploadResponse(Zero.Service.FileUploadService.UploadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UploadResult;
        
        public UploadResponseBody() {
        }
        
        public UploadResponseBody(bool UploadResult) {
            this.UploadResult = UploadResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FileUploadServiceSoapChannel : Zero.Service.FileUploadService.FileUploadServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileUploadServiceSoapClient : System.ServiceModel.ClientBase<Zero.Service.FileUploadService.FileUploadServiceSoap>, Zero.Service.FileUploadService.FileUploadServiceSoap {
        
        public FileUploadServiceSoapClient() {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileUploadServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zero.Service.FileUploadService.HelloWorldResponse Zero.Service.FileUploadService.FileUploadServiceSoap.HelloWorld(Zero.Service.FileUploadService.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Zero.Service.FileUploadService.HelloWorldRequest inValue = new Zero.Service.FileUploadService.HelloWorldRequest();
            inValue.Body = new Zero.Service.FileUploadService.HelloWorldRequestBody();
            Zero.Service.FileUploadService.HelloWorldResponse retVal = ((Zero.Service.FileUploadService.FileUploadServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Zero.Service.FileUploadService.HelloWorldResponse> Zero.Service.FileUploadService.FileUploadServiceSoap.HelloWorldAsync(Zero.Service.FileUploadService.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Zero.Service.FileUploadService.HelloWorldResponse> HelloWorldAsync() {
            Zero.Service.FileUploadService.HelloWorldRequest inValue = new Zero.Service.FileUploadService.HelloWorldRequest();
            inValue.Body = new Zero.Service.FileUploadService.HelloWorldRequestBody();
            return ((Zero.Service.FileUploadService.FileUploadServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zero.Service.FileUploadService.UploadResponse Zero.Service.FileUploadService.FileUploadServiceSoap.Upload(Zero.Service.FileUploadService.UploadRequest request) {
            return base.Channel.Upload(request);
        }
        
        public bool Upload(byte[] image, string path) {
            Zero.Service.FileUploadService.UploadRequest inValue = new Zero.Service.FileUploadService.UploadRequest();
            inValue.Body = new Zero.Service.FileUploadService.UploadRequestBody();
            inValue.Body.image = image;
            inValue.Body.path = path;
            Zero.Service.FileUploadService.UploadResponse retVal = ((Zero.Service.FileUploadService.FileUploadServiceSoap)(this)).Upload(inValue);
            return retVal.Body.UploadResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Zero.Service.FileUploadService.UploadResponse> Zero.Service.FileUploadService.FileUploadServiceSoap.UploadAsync(Zero.Service.FileUploadService.UploadRequest request) {
            return base.Channel.UploadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Zero.Service.FileUploadService.UploadResponse> UploadAsync(byte[] image, string path) {
            Zero.Service.FileUploadService.UploadRequest inValue = new Zero.Service.FileUploadService.UploadRequest();
            inValue.Body = new Zero.Service.FileUploadService.UploadRequestBody();
            inValue.Body.image = image;
            inValue.Body.path = path;
            return ((Zero.Service.FileUploadService.FileUploadServiceSoap)(this)).UploadAsync(inValue);
        }
    }
}
