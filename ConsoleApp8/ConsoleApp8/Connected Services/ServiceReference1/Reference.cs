﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp8.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="tns", ConfigurationName="ServiceReference1.SomeSoapService")]
    public interface SomeSoapService {
        
        // CODEGEN: Generating message contract since the operation addLogin is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="addLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp8.ServiceReference1.addLoginResponse1 addLogin(ConsoleApp8.ServiceReference1.addLogin1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="addLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.addLoginResponse1> addLoginAsync(ConsoleApp8.ServiceReference1.addLogin1 request);
        
        // CODEGEN: Generating message contract since the operation isLoginFree is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="isLoginFree", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp8.ServiceReference1.isLoginFreeResponse1 isLoginFree(ConsoleApp8.ServiceReference1.isLoginFree1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="isLoginFree", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.isLoginFreeResponse1> isLoginFreeAsync(ConsoleApp8.ServiceReference1.isLoginFree1 request);
        
        // CODEGEN: Generating message contract since the operation SendEmail is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="SendEmail", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ConsoleApp8.ServiceReference1.SendEmailResponse1 SendEmail(ConsoleApp8.ServiceReference1.SendEmail1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="SendEmail", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.SendEmailResponse1> SendEmailAsync(ConsoleApp8.ServiceReference1.SendEmail1 request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class addLogin : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string loginField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("login");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class SendEmailResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<bool> sendEmailResultField;
        
        private bool sendEmailResultFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<bool> SendEmailResult {
            get {
                return this.sendEmailResultField;
            }
            set {
                this.sendEmailResultField = value;
                this.RaisePropertyChanged("SendEmailResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendEmailResultSpecified {
            get {
                return this.sendEmailResultFieldSpecified;
            }
            set {
                this.sendEmailResultFieldSpecified = value;
                this.RaisePropertyChanged("SendEmailResultSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class SendEmail : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sybjectField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string sybject {
            get {
                return this.sybjectField;
            }
            set {
                this.sybjectField = value;
                this.RaisePropertyChanged("sybject");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class isLoginFreeResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<bool> isLoginFreeResultField;
        
        private bool isLoginFreeResultFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<bool> isLoginFreeResult {
            get {
                return this.isLoginFreeResultField;
            }
            set {
                this.isLoginFreeResultField = value;
                this.RaisePropertyChanged("isLoginFreeResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isLoginFreeResultSpecified {
            get {
                return this.isLoginFreeResultFieldSpecified;
            }
            set {
                this.isLoginFreeResultFieldSpecified = value;
                this.RaisePropertyChanged("isLoginFreeResultSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class isLoginFree : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string loginField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("login");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="tns")]
    public partial class addLoginResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string addLoginResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string addLoginResult {
            get {
                return this.addLoginResultField;
            }
            set {
                this.addLoginResultField = value;
                this.RaisePropertyChanged("addLoginResult");
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
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addLogin1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.addLogin addLogin;
        
        public addLogin1() {
        }
        
        public addLogin1(ConsoleApp8.ServiceReference1.addLogin addLogin) {
            this.addLogin = addLogin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addLoginResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.addLoginResponse addLoginResponse;
        
        public addLoginResponse1() {
        }
        
        public addLoginResponse1(ConsoleApp8.ServiceReference1.addLoginResponse addLoginResponse) {
            this.addLoginResponse = addLoginResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class isLoginFree1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.isLoginFree isLoginFree;
        
        public isLoginFree1() {
        }
        
        public isLoginFree1(ConsoleApp8.ServiceReference1.isLoginFree isLoginFree) {
            this.isLoginFree = isLoginFree;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class isLoginFreeResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.isLoginFreeResponse isLoginFreeResponse;
        
        public isLoginFreeResponse1() {
        }
        
        public isLoginFreeResponse1(ConsoleApp8.ServiceReference1.isLoginFreeResponse isLoginFreeResponse) {
            this.isLoginFreeResponse = isLoginFreeResponse;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmail1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.SendEmail SendEmail;
        
        public SendEmail1() {
        }
        
        public SendEmail1(ConsoleApp8.ServiceReference1.SendEmail SendEmail) {
            this.SendEmail = SendEmail;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendEmailResponse1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="tns", Order=0)]
        public ConsoleApp8.ServiceReference1.SendEmailResponse SendEmailResponse;
        
        public SendEmailResponse1() {
        }
        
        public SendEmailResponse1(ConsoleApp8.ServiceReference1.SendEmailResponse SendEmailResponse) {
            this.SendEmailResponse = SendEmailResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SomeSoapServiceChannel : ConsoleApp8.ServiceReference1.SomeSoapService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SomeSoapServiceClient : System.ServiceModel.ClientBase<ConsoleApp8.ServiceReference1.SomeSoapService>, ConsoleApp8.ServiceReference1.SomeSoapService {
        
        public SomeSoapServiceClient() {
        }
        
        public SomeSoapServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SomeSoapServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomeSoapServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SomeSoapServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp8.ServiceReference1.addLoginResponse1 ConsoleApp8.ServiceReference1.SomeSoapService.addLogin(ConsoleApp8.ServiceReference1.addLogin1 request) {
            return base.Channel.addLogin(request);
        }
        
        public ConsoleApp8.ServiceReference1.addLoginResponse addLogin(ConsoleApp8.ServiceReference1.addLogin addLogin1) {
            ConsoleApp8.ServiceReference1.addLogin1 inValue = new ConsoleApp8.ServiceReference1.addLogin1();
            inValue.addLogin = addLogin1;
            ConsoleApp8.ServiceReference1.addLoginResponse1 retVal = ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).addLogin(inValue);
            return retVal.addLoginResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.addLoginResponse1> ConsoleApp8.ServiceReference1.SomeSoapService.addLoginAsync(ConsoleApp8.ServiceReference1.addLogin1 request) {
            return base.Channel.addLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.addLoginResponse1> addLoginAsync(ConsoleApp8.ServiceReference1.addLogin addLogin) {
            ConsoleApp8.ServiceReference1.addLogin1 inValue = new ConsoleApp8.ServiceReference1.addLogin1();
            inValue.addLogin = addLogin;
            return ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).addLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp8.ServiceReference1.isLoginFreeResponse1 ConsoleApp8.ServiceReference1.SomeSoapService.isLoginFree(ConsoleApp8.ServiceReference1.isLoginFree1 request) {
            return base.Channel.isLoginFree(request);
        }
        
        public ConsoleApp8.ServiceReference1.isLoginFreeResponse isLoginFree(ConsoleApp8.ServiceReference1.isLoginFree isLoginFree1) {
            ConsoleApp8.ServiceReference1.isLoginFree1 inValue = new ConsoleApp8.ServiceReference1.isLoginFree1();
            inValue.isLoginFree = isLoginFree1;
            ConsoleApp8.ServiceReference1.isLoginFreeResponse1 retVal = ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).isLoginFree(inValue);
            return retVal.isLoginFreeResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.isLoginFreeResponse1> ConsoleApp8.ServiceReference1.SomeSoapService.isLoginFreeAsync(ConsoleApp8.ServiceReference1.isLoginFree1 request) {
            return base.Channel.isLoginFreeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.isLoginFreeResponse1> isLoginFreeAsync(ConsoleApp8.ServiceReference1.isLoginFree isLoginFree) {
            ConsoleApp8.ServiceReference1.isLoginFree1 inValue = new ConsoleApp8.ServiceReference1.isLoginFree1();
            inValue.isLoginFree = isLoginFree;
            return ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).isLoginFreeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp8.ServiceReference1.SendEmailResponse1 ConsoleApp8.ServiceReference1.SomeSoapService.SendEmail(ConsoleApp8.ServiceReference1.SendEmail1 request) {
            return base.Channel.SendEmail(request);
        }
        
        public ConsoleApp8.ServiceReference1.SendEmailResponse SendEmail(ConsoleApp8.ServiceReference1.SendEmail SendEmail1) {
            ConsoleApp8.ServiceReference1.SendEmail1 inValue = new ConsoleApp8.ServiceReference1.SendEmail1();
            inValue.SendEmail = SendEmail1;
            ConsoleApp8.ServiceReference1.SendEmailResponse1 retVal = ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).SendEmail(inValue);
            return retVal.SendEmailResponse;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.SendEmailResponse1> ConsoleApp8.ServiceReference1.SomeSoapService.SendEmailAsync(ConsoleApp8.ServiceReference1.SendEmail1 request) {
            return base.Channel.SendEmailAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp8.ServiceReference1.SendEmailResponse1> SendEmailAsync(ConsoleApp8.ServiceReference1.SendEmail SendEmail) {
            ConsoleApp8.ServiceReference1.SendEmail1 inValue = new ConsoleApp8.ServiceReference1.SendEmail1();
            inValue.SendEmail = SendEmail;
            return ((ConsoleApp8.ServiceReference1.SomeSoapService)(this)).SendEmailAsync(inValue);
        }
    }
}
