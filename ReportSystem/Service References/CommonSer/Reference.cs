﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportSystem.CommonSer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CommonCodeDataObjectList", Namespace="http://www.ByteartRetail.com/CollectionDataObjectList.xsd", ItemName="CommonCodeDataObject")]
    [System.SerializableAttribute()]
    public class CommonCodeDataObjectList : System.Collections.Generic.List<ReportSystem.CommonSer.CommonCodeDataObject> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonCodeDataObject", Namespace="http://www.ByteartRetail.com/CommonCodeDataObject.xsd")]
    [System.SerializableAttribute()]
    public partial class CommonCodeDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<ReportSystem.CommonSer.CommonStatusDataObject> CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> OrderField;
        
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
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public System.Nullable<ReportSystem.CommonSer.CommonStatusDataObject> Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((this.CategoryField.Equals(value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public System.Nullable<int> Order {
            get {
                return this.OrderField;
            }
            set {
                if ((this.OrderField.Equals(value) != true)) {
                    this.OrderField = value;
                    this.RaisePropertyChanged("Order");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonStatusDataObject", Namespace="http://www.ByteartRetail.com/CommonStatusDataObject.xsd")]
    public enum CommonStatusDataObject : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CodeType = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PayType = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PayStatus = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PayOption = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        PayFre = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BusinessType = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GuaranteeType = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Status = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CreditorType = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        WarranteeType = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CGManType = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CGType = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ContractStatus = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GoMark = 13,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        BQStatus = 14,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/LAFAFGS.DataObjects")]
    [System.SerializableAttribute()]
    public partial class FaultData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StackTraceField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string FullMessage {
            get {
                return this.FullMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.FullMessageField, value) != true)) {
                    this.FullMessageField = value;
                    this.RaisePropertyChanged("FullMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string StackTrace {
            get {
                return this.StackTraceField;
            }
            set {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true)) {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CommonSer.ICommonService")]
    public interface ICommonService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/GetCommonCodes", ReplyAction="http://tempuri.org/ICommonService/GetCommonCodesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ReportSystem.CommonSer.FaultData), Action="http://tempuri.org/ICommonService/GetCommonCodesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/LAFAFGS.DataObjects")]
        ReportSystem.CommonSer.CommonCodeDataObjectList GetCommonCodes(string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/GetCommonCodes", ReplyAction="http://tempuri.org/ICommonService/GetCommonCodesResponse")]
        System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> GetCommonCodesAsync(string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/CreatCommonCodes", ReplyAction="http://tempuri.org/ICommonService/CreatCommonCodesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ReportSystem.CommonSer.FaultData), Action="http://tempuri.org/ICommonService/CreatCommonCodesFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/LAFAFGS.DataObjects")]
        ReportSystem.CommonSer.CommonCodeDataObjectList CreatCommonCodes(ReportSystem.CommonSer.CommonCodeDataObjectList commonCodeDataObjects, string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/CreatCommonCodes", ReplyAction="http://tempuri.org/ICommonService/CreatCommonCodesResponse")]
        System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> CreatCommonCodesAsync(ReportSystem.CommonSer.CommonCodeDataObjectList commonCodeDataObjects, string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/GetCommonCodesByCategory", ReplyAction="http://tempuri.org/ICommonService/GetCommonCodesByCategoryResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ReportSystem.CommonSer.FaultData), Action="http://tempuri.org/ICommonService/GetCommonCodesByCategoryFaultDataFault", Name="FaultData", Namespace="http://schemas.datacontract.org/2004/07/LAFAFGS.DataObjects")]
        ReportSystem.CommonSer.CommonCodeDataObjectList GetCommonCodesByCategory(ReportSystem.CommonSer.CommonStatusDataObject Category, string DBName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommonService/GetCommonCodesByCategory", ReplyAction="http://tempuri.org/ICommonService/GetCommonCodesByCategoryResponse")]
        System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> GetCommonCodesByCategoryAsync(ReportSystem.CommonSer.CommonStatusDataObject Category, string DBName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommonServiceChannel : ReportSystem.CommonSer.ICommonService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommonServiceClient : System.ServiceModel.ClientBase<ReportSystem.CommonSer.ICommonService>, ReportSystem.CommonSer.ICommonService {
        
        public CommonServiceClient() {
        }
        
        public CommonServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommonServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ReportSystem.CommonSer.CommonCodeDataObjectList GetCommonCodes(string DBName) {
            return base.Channel.GetCommonCodes(DBName);
        }
        
        public System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> GetCommonCodesAsync(string DBName) {
            return base.Channel.GetCommonCodesAsync(DBName);
        }
        
        public ReportSystem.CommonSer.CommonCodeDataObjectList CreatCommonCodes(ReportSystem.CommonSer.CommonCodeDataObjectList commonCodeDataObjects, string DBName) {
            return base.Channel.CreatCommonCodes(commonCodeDataObjects, DBName);
        }
        
        public System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> CreatCommonCodesAsync(ReportSystem.CommonSer.CommonCodeDataObjectList commonCodeDataObjects, string DBName) {
            return base.Channel.CreatCommonCodesAsync(commonCodeDataObjects, DBName);
        }
        
        public ReportSystem.CommonSer.CommonCodeDataObjectList GetCommonCodesByCategory(ReportSystem.CommonSer.CommonStatusDataObject Category, string DBName) {
            return base.Channel.GetCommonCodesByCategory(Category, DBName);
        }
        
        public System.Threading.Tasks.Task<ReportSystem.CommonSer.CommonCodeDataObjectList> GetCommonCodesByCategoryAsync(ReportSystem.CommonSer.CommonStatusDataObject Category, string DBName) {
            return base.Channel.GetCommonCodesByCategoryAsync(Category, DBName);
        }
    }
}
