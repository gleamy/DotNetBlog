﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConnectApacheCXF.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://jaxws.web.mdc.longo/", ConfigurationName="ServiceReference1.Test")]
    public interface Test {
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOneResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOne))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloTwo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloThree))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractMap))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TestConnectApacheCXF.ServiceReference1.HelloThreeResponse HelloThree(TestConnectApacheCXF.ServiceReference1.HelloThree1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloThreeResponse> HelloThreeAsync(TestConnectApacheCXF.ServiceReference1.HelloThree1 request);
        
        // CODEGEN: 参数“return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOneResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOne))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloTwo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloThree))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractMap))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        TestConnectApacheCXF.ServiceReference1.HelloTwoResponse HelloTwo(TestConnectApacheCXF.ServiceReference1.HelloTwo1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloTwoResponse> HelloTwoAsync(TestConnectApacheCXF.ServiceReference1.HelloTwo1 request);
        
        // CODEGEN: 参数“_return”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlArrayAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOneResponse))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloOne))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloTwo))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(HelloThree))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(abstractMap))]
        [return: System.ServiceModel.MessageParameterAttribute(Name="_return")]
        TestConnectApacheCXF.ServiceReference1.HelloOneResponse1 HelloOne(TestConnectApacheCXF.ServiceReference1.HelloOne1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloOneResponse1> HelloOneAsync(TestConnectApacheCXF.ServiceReference1.HelloOne1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public partial class hashMap : abstractMap {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(hashMap))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public abstract partial class abstractMap : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public partial class HelloOneResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private HelloOneResponseEntry[] _returnField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public HelloOneResponseEntry[] _return {
            get {
                return this._returnField;
            }
            set {
                this._returnField = value;
                this.RaisePropertyChanged("_return");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://jaxws.web.mdc.longo/")]
    public partial class HelloOneResponseEntry : object, System.ComponentModel.INotifyPropertyChanged {
        
        private object keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public object key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public object value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public partial class HelloOne : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public partial class HelloTwo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jaxws.web.mdc.longo/")]
    public partial class HelloThree : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int aField;
        
        private int bField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int a {
            get {
                return this.aField;
            }
            set {
                this.aField = value;
                this.RaisePropertyChanged("a");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int b {
            get {
                return this.bField;
            }
            set {
                this.bField = value;
                this.RaisePropertyChanged("b");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloThree", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloThree1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int a;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int b;
        
        public HelloThree1() {
        }
        
        public HelloThree1(int a, int b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloThreeResponse", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloThreeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TestConnectApacheCXF.ServiceReference1.hashMap[] @return;
        
        public HelloThreeResponse() {
        }
        
        public HelloThreeResponse(TestConnectApacheCXF.ServiceReference1.hashMap[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloTwo", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloTwo1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name;
        
        public HelloTwo1() {
        }
        
        public HelloTwo1(string name) {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloTwoResponse", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloTwoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public TestConnectApacheCXF.ServiceReference1.hashMap[] @return;
        
        public HelloTwoResponse() {
        }
        
        public HelloTwoResponse(TestConnectApacheCXF.ServiceReference1.hashMap[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloOne", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloOne1 {
        
        public HelloOne1() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="HelloOneResponse", WrapperNamespace="http://jaxws.web.mdc.longo/", IsWrapped=true)]
    public partial class HelloOneResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://jaxws.web.mdc.longo/", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("entry", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public TestConnectApacheCXF.ServiceReference1.HelloOneResponseEntry[] _return;
        
        public HelloOneResponse1() {
        }
        
        public HelloOneResponse1(TestConnectApacheCXF.ServiceReference1.HelloOneResponseEntry[] _return) {
            this._return = _return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TestChannel : TestConnectApacheCXF.ServiceReference1.Test, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TestClient : System.ServiceModel.ClientBase<TestConnectApacheCXF.ServiceReference1.Test>, TestConnectApacheCXF.ServiceReference1.Test {
        
        public TestClient() {
        }
        
        public TestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConnectApacheCXF.ServiceReference1.HelloThreeResponse TestConnectApacheCXF.ServiceReference1.Test.HelloThree(TestConnectApacheCXF.ServiceReference1.HelloThree1 request) {
            return base.Channel.HelloThree(request);
        }
        
        public TestConnectApacheCXF.ServiceReference1.hashMap[] HelloThree(int a, int b) {
            TestConnectApacheCXF.ServiceReference1.HelloThree1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloThree1();
            inValue.a = a;
            inValue.b = b;
            TestConnectApacheCXF.ServiceReference1.HelloThreeResponse retVal = ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloThree(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloThreeResponse> TestConnectApacheCXF.ServiceReference1.Test.HelloThreeAsync(TestConnectApacheCXF.ServiceReference1.HelloThree1 request) {
            return base.Channel.HelloThreeAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloThreeResponse> HelloThreeAsync(int a, int b) {
            TestConnectApacheCXF.ServiceReference1.HelloThree1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloThree1();
            inValue.a = a;
            inValue.b = b;
            return ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloThreeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConnectApacheCXF.ServiceReference1.HelloTwoResponse TestConnectApacheCXF.ServiceReference1.Test.HelloTwo(TestConnectApacheCXF.ServiceReference1.HelloTwo1 request) {
            return base.Channel.HelloTwo(request);
        }
        
        public TestConnectApacheCXF.ServiceReference1.hashMap[] HelloTwo(string name) {
            TestConnectApacheCXF.ServiceReference1.HelloTwo1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloTwo1();
            inValue.name = name;
            TestConnectApacheCXF.ServiceReference1.HelloTwoResponse retVal = ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloTwo(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloTwoResponse> TestConnectApacheCXF.ServiceReference1.Test.HelloTwoAsync(TestConnectApacheCXF.ServiceReference1.HelloTwo1 request) {
            return base.Channel.HelloTwoAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloTwoResponse> HelloTwoAsync(string name) {
            TestConnectApacheCXF.ServiceReference1.HelloTwo1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloTwo1();
            inValue.name = name;
            return ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloTwoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConnectApacheCXF.ServiceReference1.HelloOneResponse1 TestConnectApacheCXF.ServiceReference1.Test.HelloOne(TestConnectApacheCXF.ServiceReference1.HelloOne1 request) {
            return base.Channel.HelloOne(request);
        }
        
        public TestConnectApacheCXF.ServiceReference1.HelloOneResponseEntry[] HelloOne() {
            TestConnectApacheCXF.ServiceReference1.HelloOne1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloOne1();
            TestConnectApacheCXF.ServiceReference1.HelloOneResponse1 retVal = ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloOne(inValue);
            return retVal._return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloOneResponse1> TestConnectApacheCXF.ServiceReference1.Test.HelloOneAsync(TestConnectApacheCXF.ServiceReference1.HelloOne1 request) {
            return base.Channel.HelloOneAsync(request);
        }
        
        public System.Threading.Tasks.Task<TestConnectApacheCXF.ServiceReference1.HelloOneResponse1> HelloOneAsync() {
            TestConnectApacheCXF.ServiceReference1.HelloOne1 inValue = new TestConnectApacheCXF.ServiceReference1.HelloOne1();
            return ((TestConnectApacheCXF.ServiceReference1.Test)(this)).HelloOneAsync(inValue);
        }
    }
}
