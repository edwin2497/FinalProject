﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.Service2_Reference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerDTO", Namespace="http://schemas.datacontract.org/2004/07/CommunicationApp")]
    [System.SerializableAttribute()]
    public partial class CustomerDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstLastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondLastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstLastName {
            get {
                return this.FirstLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstLastNameField, value) != true)) {
                    this.FirstLastNameField = value;
                    this.RaisePropertyChanged("FirstLastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((this.PhoneField.Equals(value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondLastName {
            get {
                return this.SecondLastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondLastNameField, value) != true)) {
                    this.SecondLastNameField = value;
                    this.RaisePropertyChanged("SecondLastName");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerList", Namespace="http://schemas.datacontract.org/2004/07/CommunicationApp")]
    [System.SerializableAttribute()]
    public partial class CustomerList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Presentation.Service2_Reference.CustomerDTO[] listsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Presentation.Service2_Reference.CustomerDTO[] lists {
            get {
                return this.listsField;
            }
            set {
                if ((object.ReferenceEquals(this.listsField, value) != true)) {
                    this.listsField = value;
                    this.RaisePropertyChanged("lists");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service2_Reference.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetCustomerId", ReplyAction="http://tempuri.org/IService2/GetCustomerIdResponse")]
        Presentation.Service2_Reference.CustomerDTO GetCustomerId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetCustomerId", ReplyAction="http://tempuri.org/IService2/GetCustomerIdResponse")]
        System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerDTO> GetCustomerIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/InsertCustomer", ReplyAction="http://tempuri.org/IService2/InsertCustomerResponse")]
        void InsertCustomer(Presentation.Service2_Reference.CustomerDTO customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/InsertCustomer", ReplyAction="http://tempuri.org/IService2/InsertCustomerResponse")]
        System.Threading.Tasks.Task InsertCustomerAsync(Presentation.Service2_Reference.CustomerDTO customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/DeleteCustomer", ReplyAction="http://tempuri.org/IService2/DeleteCustomerResponse")]
        void DeleteCustomer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/DeleteCustomer", ReplyAction="http://tempuri.org/IService2/DeleteCustomerResponse")]
        System.Threading.Tasks.Task DeleteCustomerAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/ModifyCustomer", ReplyAction="http://tempuri.org/IService2/ModifyCustomerResponse")]
        void ModifyCustomer(Presentation.Service2_Reference.CustomerDTO customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/ModifyCustomer", ReplyAction="http://tempuri.org/IService2/ModifyCustomerResponse")]
        System.Threading.Tasks.Task ModifyCustomerAsync(Presentation.Service2_Reference.CustomerDTO customer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetAllCustomer", ReplyAction="http://tempuri.org/IService2/GetAllCustomerResponse")]
        Presentation.Service2_Reference.CustomerList GetAllCustomer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetAllCustomer", ReplyAction="http://tempuri.org/IService2/GetAllCustomerResponse")]
        System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerList> GetAllCustomerAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/LoginCustomer", ReplyAction="http://tempuri.org/IService2/LoginCustomerResponse")]
        bool LoginCustomer(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/LoginCustomer", ReplyAction="http://tempuri.org/IService2/LoginCustomerResponse")]
        System.Threading.Tasks.Task<bool> LoginCustomerAsync(int id, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetCardIdCustomer", ReplyAction="http://tempuri.org/IService2/GetCardIdCustomerResponse")]
        Presentation.Service2_Reference.CustomerDTO GetCardIdCustomer(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetCardIdCustomer", ReplyAction="http://tempuri.org/IService2/GetCardIdCustomerResponse")]
        System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerDTO> GetCardIdCustomerAsync(int cardId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : Presentation.Service2_Reference.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<Presentation.Service2_Reference.IService2>, Presentation.Service2_Reference.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Presentation.Service2_Reference.CustomerDTO GetCustomerId(int id) {
            return base.Channel.GetCustomerId(id);
        }
        
        public System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerDTO> GetCustomerIdAsync(int id) {
            return base.Channel.GetCustomerIdAsync(id);
        }
        
        public void InsertCustomer(Presentation.Service2_Reference.CustomerDTO customer) {
            base.Channel.InsertCustomer(customer);
        }
        
        public System.Threading.Tasks.Task InsertCustomerAsync(Presentation.Service2_Reference.CustomerDTO customer) {
            return base.Channel.InsertCustomerAsync(customer);
        }
        
        public void DeleteCustomer(int id) {
            base.Channel.DeleteCustomer(id);
        }
        
        public System.Threading.Tasks.Task DeleteCustomerAsync(int id) {
            return base.Channel.DeleteCustomerAsync(id);
        }
        
        public void ModifyCustomer(Presentation.Service2_Reference.CustomerDTO customer) {
            base.Channel.ModifyCustomer(customer);
        }
        
        public System.Threading.Tasks.Task ModifyCustomerAsync(Presentation.Service2_Reference.CustomerDTO customer) {
            return base.Channel.ModifyCustomerAsync(customer);
        }
        
        public Presentation.Service2_Reference.CustomerList GetAllCustomer() {
            return base.Channel.GetAllCustomer();
        }
        
        public System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerList> GetAllCustomerAsync() {
            return base.Channel.GetAllCustomerAsync();
        }
        
        public bool LoginCustomer(int id, string password) {
            return base.Channel.LoginCustomer(id, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginCustomerAsync(int id, string password) {
            return base.Channel.LoginCustomerAsync(id, password);
        }
        
        public Presentation.Service2_Reference.CustomerDTO GetCardIdCustomer(int cardId) {
            return base.Channel.GetCardIdCustomer(cardId);
        }
        
        public System.Threading.Tasks.Task<Presentation.Service2_Reference.CustomerDTO> GetCardIdCustomerAsync(int cardId) {
            return base.Channel.GetCardIdCustomerAsync(cardId);
        }
    }
}
