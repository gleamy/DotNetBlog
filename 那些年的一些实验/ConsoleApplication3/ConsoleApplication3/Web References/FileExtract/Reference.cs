﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34011
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.34011 版自动生成。
// 
#pragma warning disable 1591

namespace ConsoleApplication3.FileExtract {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_FileExtractService", Namespace="http://www.caecc.casc/civet/ics/extractagent")]
    public partial class FileExtractService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback createGTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback createFTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback returnGTransResultOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FileExtractService() {
            this.Url = global::ConsoleApplication3.Properties.Settings.Default.ConsoleApplication3_FileExtract_FileExtractService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event createGTaskCompletedEventHandler createGTaskCompleted;
        
        /// <remarks/>
        public event createFTaskCompletedEventHandler createFTaskCompleted;
        
        /// <remarks/>
        public event returnGTransResultCompletedEventHandler returnGTransResultCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ERIP_ExtractAgent_GK/FileExtractService/createGTask", RequestNamespace="http://www.caecc.casc/civet/ics/extractagent", ResponseNamespace="http://www.caecc.casc/civet/ics/extractagent", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createGTask([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string folder, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string gFilename, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string pFilename, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string validate, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string dataID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string destinationID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string clientID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] System.Nullable<SecurityLevel> securityLevel, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] [System.Xml.Serialization.XmlIgnoreAttribute()] bool securityLevelSpecified, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string signature, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool createGTaskResult, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool createGTaskResultSpecified) {
            object[] results = this.Invoke("createGTask", new object[] {
                        folder,
                        gFilename,
                        pFilename,
                        validate,
                        dataID,
                        destinationID,
                        clientID,
                        securityLevel,
                        securityLevelSpecified,
                        signature});
            createGTaskResult = ((bool)(results[0]));
            createGTaskResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void createGTaskAsync(string folder, string gFilename, string pFilename, string validate, string dataID, string destinationID, string clientID, System.Nullable<SecurityLevel> securityLevel, bool securityLevelSpecified, string signature) {
            this.createGTaskAsync(folder, gFilename, pFilename, validate, dataID, destinationID, clientID, securityLevel, securityLevelSpecified, signature, null);
        }
        
        /// <remarks/>
        public void createGTaskAsync(string folder, string gFilename, string pFilename, string validate, string dataID, string destinationID, string clientID, System.Nullable<SecurityLevel> securityLevel, bool securityLevelSpecified, string signature, object userState) {
            if ((this.createGTaskOperationCompleted == null)) {
                this.createGTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateGTaskOperationCompleted);
            }
            this.InvokeAsync("createGTask", new object[] {
                        folder,
                        gFilename,
                        pFilename,
                        validate,
                        dataID,
                        destinationID,
                        clientID,
                        securityLevel,
                        securityLevelSpecified,
                        signature}, this.createGTaskOperationCompleted, userState);
        }
        
        private void OncreateGTaskOperationCompleted(object arg) {
            if ((this.createGTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createGTaskCompleted(this, new createGTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ERIP_ExtractAgent_GK/FileExtractService/createFTask", RequestNamespace="http://www.caecc.casc/civet/ics/extractagent", ResponseNamespace="http://www.caecc.casc/civet/ics/extractagent", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void createFTask([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string folder, [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] [System.Xml.Serialization.XmlArrayItemAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] string[] filenames, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string validate, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string destinationID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool createFTaskResult, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool createFTaskResultSpecified) {
            object[] results = this.Invoke("createFTask", new object[] {
                        folder,
                        filenames,
                        validate,
                        destinationID});
            createFTaskResult = ((bool)(results[0]));
            createFTaskResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void createFTaskAsync(string folder, string[] filenames, string validate, string destinationID) {
            this.createFTaskAsync(folder, filenames, validate, destinationID, null);
        }
        
        /// <remarks/>
        public void createFTaskAsync(string folder, string[] filenames, string validate, string destinationID, object userState) {
            if ((this.createFTaskOperationCompleted == null)) {
                this.createFTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OncreateFTaskOperationCompleted);
            }
            this.InvokeAsync("createFTask", new object[] {
                        folder,
                        filenames,
                        validate,
                        destinationID}, this.createFTaskOperationCompleted, userState);
        }
        
        private void OncreateFTaskOperationCompleted(object arg) {
            if ((this.createFTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.createFTaskCompleted(this, new createFTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("ERIP_ExtractAgent_GK/FileExtractService/returnGTransResult", RequestNamespace="http://www.caecc.casc/civet/ics/extractagent", ResponseNamespace="http://www.caecc.casc/civet/ics/extractagent", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void returnGTransResult([System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string dataID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string result, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string destinationID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string clientID, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)] string signature, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] out bool returnGTransResultResult, [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)] [System.Xml.Serialization.XmlIgnoreAttribute()] out bool returnGTransResultResultSpecified) {
            object[] results = this.Invoke("returnGTransResult", new object[] {
                        dataID,
                        result,
                        destinationID,
                        clientID,
                        signature});
            returnGTransResultResult = ((bool)(results[0]));
            returnGTransResultResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void returnGTransResultAsync(string dataID, string result, string destinationID, string clientID, string signature) {
            this.returnGTransResultAsync(dataID, result, destinationID, clientID, signature, null);
        }
        
        /// <remarks/>
        public void returnGTransResultAsync(string dataID, string result, string destinationID, string clientID, string signature, object userState) {
            if ((this.returnGTransResultOperationCompleted == null)) {
                this.returnGTransResultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnreturnGTransResultOperationCompleted);
            }
            this.InvokeAsync("returnGTransResult", new object[] {
                        dataID,
                        result,
                        destinationID,
                        clientID,
                        signature}, this.returnGTransResultOperationCompleted, userState);
        }
        
        private void OnreturnGTransResultOperationCompleted(object arg) {
            if ((this.returnGTransResultCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.returnGTransResultCompleted(this, new returnGTransResultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void createGTaskCompletedEventHandler(object sender, createGTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createGTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createGTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool createGTaskResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool createGTaskResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void createFTaskCompletedEventHandler(object sender, createFTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class createFTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal createFTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool createFTaskResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool createFTaskResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void returnGTransResultCompletedEventHandler(object sender, returnGTransResultCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class returnGTransResultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal returnGTransResultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool returnGTransResultResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool returnGTransResultResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591