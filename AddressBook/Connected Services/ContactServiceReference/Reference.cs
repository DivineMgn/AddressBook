﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AddressBook.ContactServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ContactDto", Namespace="http://schemas.datacontract.org/2004/07/ContactServiceLib")]
    [System.SerializableAttribute()]
    public partial class ContactDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id {
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
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName {
            get {
                return this.SecondNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNameField, value) != true)) {
                    this.SecondNameField = value;
                    this.RaisePropertyChanged("SecondName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ContactServiceReference.IContactService")]
    public interface IContactService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/CreateContact", ReplyAction="http://tempuri.org/IContactService/CreateContactResponse")]
        long CreateContact(AddressBook.ContactServiceReference.ContactDto contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/CreateContact", ReplyAction="http://tempuri.org/IContactService/CreateContactResponse")]
        System.Threading.Tasks.Task<long> CreateContactAsync(AddressBook.ContactServiceReference.ContactDto contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetAllContacts", ReplyAction="http://tempuri.org/IContactService/GetAllContactsResponse")]
        AddressBook.ContactServiceReference.ContactDto[] GetAllContacts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetAllContacts", ReplyAction="http://tempuri.org/IContactService/GetAllContactsResponse")]
        System.Threading.Tasks.Task<AddressBook.ContactServiceReference.ContactDto[]> GetAllContactsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeleteContact", ReplyAction="http://tempuri.org/IContactService/DeleteContactResponse")]
        void DeleteContact(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/DeleteContact", ReplyAction="http://tempuri.org/IContactService/DeleteContactResponse")]
        System.Threading.Tasks.Task DeleteContactAsync(long Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContactDetails", ReplyAction="http://tempuri.org/IContactService/GetContactDetailsResponse")]
        AddressBook.ContactServiceReference.ContactDto GetContactDetails(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContactService/GetContactDetails", ReplyAction="http://tempuri.org/IContactService/GetContactDetailsResponse")]
        System.Threading.Tasks.Task<AddressBook.ContactServiceReference.ContactDto> GetContactDetailsAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContactServiceChannel : AddressBook.ContactServiceReference.IContactService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContactServiceClient : System.ServiceModel.ClientBase<AddressBook.ContactServiceReference.IContactService>, AddressBook.ContactServiceReference.IContactService {
        
        public ContactServiceClient() {
        }
        
        public ContactServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContactServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public long CreateContact(AddressBook.ContactServiceReference.ContactDto contact) {
            return base.Channel.CreateContact(contact);
        }
        
        public System.Threading.Tasks.Task<long> CreateContactAsync(AddressBook.ContactServiceReference.ContactDto contact) {
            return base.Channel.CreateContactAsync(contact);
        }
        
        public AddressBook.ContactServiceReference.ContactDto[] GetAllContacts() {
            return base.Channel.GetAllContacts();
        }
        
        public System.Threading.Tasks.Task<AddressBook.ContactServiceReference.ContactDto[]> GetAllContactsAsync() {
            return base.Channel.GetAllContactsAsync();
        }
        
        public void DeleteContact(long Id) {
            base.Channel.DeleteContact(Id);
        }
        
        public System.Threading.Tasks.Task DeleteContactAsync(long Id) {
            return base.Channel.DeleteContactAsync(Id);
        }
        
        public AddressBook.ContactServiceReference.ContactDto GetContactDetails(long id) {
            return base.Channel.GetContactDetails(id);
        }
        
        public System.Threading.Tasks.Task<AddressBook.ContactServiceReference.ContactDto> GetContactDetailsAsync(long id) {
            return base.Channel.GetContactDetailsAsync(id);
        }
    }
}
