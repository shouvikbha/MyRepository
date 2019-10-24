﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiplaAppClient.CiplaWcfService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/CiplaWcfService")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicineNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MedicineTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public string MedicineName {
            get {
                return this.MedicineNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicineNameField, value) != true)) {
                    this.MedicineNameField = value;
                    this.RaisePropertyChanged("MedicineName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MedicineType {
            get {
                return this.MedicineTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.MedicineTypeField, value) != true)) {
                    this.MedicineTypeField = value;
                    this.RaisePropertyChanged("MedicineType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CiplaWcfService.ICiplaService")]
    public interface ICiplaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiplaService/AddOrder", ReplyAction="http://tempuri.org/ICiplaService/AddOrderResponse")]
        bool AddOrder(CiplaAppClient.CiplaWcfService.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICiplaService/AddOrder", ReplyAction="http://tempuri.org/ICiplaService/AddOrderResponse")]
        System.Threading.Tasks.Task<bool> AddOrderAsync(CiplaAppClient.CiplaWcfService.Order order);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICiplaServiceChannel : CiplaAppClient.CiplaWcfService.ICiplaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CiplaServiceClient : System.ServiceModel.ClientBase<CiplaAppClient.CiplaWcfService.ICiplaService>, CiplaAppClient.CiplaWcfService.ICiplaService {
        
        public CiplaServiceClient() {
        }
        
        public CiplaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CiplaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiplaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CiplaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddOrder(CiplaAppClient.CiplaWcfService.Order order) {
            return base.Channel.AddOrder(order);
        }
        
        public System.Threading.Tasks.Task<bool> AddOrderAsync(CiplaAppClient.CiplaWcfService.Order order) {
            return base.Channel.AddOrderAsync(order);
        }
    }
}
