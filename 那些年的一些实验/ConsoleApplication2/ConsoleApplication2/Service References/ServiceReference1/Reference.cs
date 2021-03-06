﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", ConfigurationName="ServiceReference1.FileExtractService")]
    public interface FileExtractService {
        
        // CODEGEN: 参数“createGTaskResult”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="ERIP_ExtractAgent_GK/FileExtractService/createGTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_OutputMessageResponse createGTask(ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_InputMessageRequest request);
        
        // CODEGEN: 参数“createFTaskResult”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="ERIP_ExtractAgent_GK/FileExtractService/createFTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_OutputMessageResponse createFTask(ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_InputMessageRequest request);
        
        // CODEGEN: 参数“returnGTransResultResult”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="ERIP_ExtractAgent_GK/FileExtractService/returnGTransResult", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_OutputMessageResponse returnGTransResult(ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_InputMessageRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent")]
    public enum SecurityLevel {
        
        /// <remarks/>
        none,
        
        /// <remarks/>
        interior,
        
        /// <remarks/>
        privacy,
        
        /// <remarks/>
        secret,
        
        /// <remarks/>
        topsecret,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createGTask", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_createGTask_InputMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string folder;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string gFilename;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string pFilename;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string validate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string dataID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string destinationID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public System.Nullable<SecurityLevel> securityLevel;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string signature;
        
        public FileExtractService_createGTask_InputMessageRequest() {
        }
        
        public FileExtractService_createGTask_InputMessageRequest(string folder, string gFilename, string pFilename, string validate, string dataID, string destinationID, string clientID, System.Nullable<SecurityLevel> securityLevel, string signature) {
            this.folder = folder;
            this.gFilename = gFilename;
            this.pFilename = pFilename;
            this.validate = validate;
            this.dataID = dataID;
            this.destinationID = destinationID;
            this.clientID = clientID;
            this.securityLevel = securityLevel;
            this.signature = signature;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createGTaskResponse", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_createGTask_OutputMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool createGTaskResult;
        
        public FileExtractService_createGTask_OutputMessageResponse() {
        }
        
        public FileExtractService_createGTask_OutputMessageResponse(bool createGTaskResult) {
            this.createGTaskResult = createGTaskResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createFTask", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_createFTask_InputMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string folder;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=1)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] filenames;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string validate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string destinationID;
        
        public FileExtractService_createFTask_InputMessageRequest() {
        }
        
        public FileExtractService_createFTask_InputMessageRequest(string folder, string[] filenames, string validate, string destinationID) {
            this.folder = folder;
            this.filenames = filenames;
            this.validate = validate;
            this.destinationID = destinationID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="createFTaskResponse", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_createFTask_OutputMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool createFTaskResult;
        
        public FileExtractService_createFTask_OutputMessageResponse() {
        }
        
        public FileExtractService_createFTask_OutputMessageResponse(bool createFTaskResult) {
            this.createFTaskResult = createFTaskResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="returnGTransResult", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_returnGTransResult_InputMessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string dataID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string destinationID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string clientID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string signature;
        
        public FileExtractService_returnGTransResult_InputMessageRequest() {
        }
        
        public FileExtractService_returnGTransResult_InputMessageRequest(string dataID, string result, string destinationID, string clientID, string signature) {
            this.dataID = dataID;
            this.result = result;
            this.destinationID = destinationID;
            this.clientID = clientID;
            this.signature = signature;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="returnGTransResultResponse", WrapperNamespace="http://www.caecc.casc/civet/ics/extractagent", IsWrapped=true)]
    public partial class FileExtractService_returnGTransResult_OutputMessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.caecc.casc/civet/ics/extractagent", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool returnGTransResultResult;
        
        public FileExtractService_returnGTransResult_OutputMessageResponse() {
        }
        
        public FileExtractService_returnGTransResult_OutputMessageResponse(bool returnGTransResultResult) {
            this.returnGTransResultResult = returnGTransResultResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FileExtractServiceChannel : ConsoleApplication2.ServiceReference1.FileExtractService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FileExtractServiceClient : System.ServiceModel.ClientBase<ConsoleApplication2.ServiceReference1.FileExtractService>, ConsoleApplication2.ServiceReference1.FileExtractService {
        
        public FileExtractServiceClient() {
        }
        
        public FileExtractServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FileExtractServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileExtractServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FileExtractServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_OutputMessageResponse ConsoleApplication2.ServiceReference1.FileExtractService.createGTask(ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_InputMessageRequest request) {
            return base.Channel.createGTask(request);
        }
        
        public bool createGTask(string folder, string gFilename, string pFilename, string validate, string dataID, string destinationID, string clientID, System.Nullable<SecurityLevel> securityLevel, string signature) {
            ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_InputMessageRequest inValue = new ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_InputMessageRequest();
            inValue.folder = folder;
            inValue.gFilename = gFilename;
            inValue.pFilename = pFilename;
            inValue.validate = validate;
            inValue.dataID = dataID;
            inValue.destinationID = destinationID;
            inValue.clientID = clientID;
            inValue.securityLevel = securityLevel;
            inValue.signature = signature;
            ConsoleApplication2.ServiceReference1.FileExtractService_createGTask_OutputMessageResponse retVal = ((ConsoleApplication2.ServiceReference1.FileExtractService)(this)).createGTask(inValue);
            return retVal.createGTaskResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_OutputMessageResponse ConsoleApplication2.ServiceReference1.FileExtractService.createFTask(ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_InputMessageRequest request) {
            return base.Channel.createFTask(request);
        }
        
        public bool createFTask(string folder, string[] filenames, string validate, string destinationID) {
            ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_InputMessageRequest inValue = new ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_InputMessageRequest();
            inValue.folder = folder;
            inValue.filenames = filenames;
            inValue.validate = validate;
            inValue.destinationID = destinationID;
            ConsoleApplication2.ServiceReference1.FileExtractService_createFTask_OutputMessageResponse retVal = ((ConsoleApplication2.ServiceReference1.FileExtractService)(this)).createFTask(inValue);
            return retVal.createFTaskResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_OutputMessageResponse ConsoleApplication2.ServiceReference1.FileExtractService.returnGTransResult(ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_InputMessageRequest request) {
            return base.Channel.returnGTransResult(request);
        }
        
        public bool returnGTransResult(string dataID, string result, string destinationID, string clientID, string signature) {
            ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_InputMessageRequest inValue = new ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_InputMessageRequest();
            inValue.dataID = dataID;
            inValue.result = result;
            inValue.destinationID = destinationID;
            inValue.clientID = clientID;
            inValue.signature = signature;
            ConsoleApplication2.ServiceReference1.FileExtractService_returnGTransResult_OutputMessageResponse retVal = ((ConsoleApplication2.ServiceReference1.FileExtractService)(this)).returnGTransResult(inValue);
            return retVal.returnGTransResultResult;
        }
    }
}
