﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmerPlusScheduarManager.ServiceReferenceWeather {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Conditions", Namespace="http://schemas.datacontract.org/2004/07/FarmerPlusDataObjectLayer")]
    [System.SerializableAttribute()]
    public partial class Conditions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ConditionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DayOfWeekField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HighField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HumidityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LowField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TempCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TempFField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WindField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Condition {
            get {
                return this.ConditionField;
            }
            set {
                if ((object.ReferenceEquals(this.ConditionField, value) != true)) {
                    this.ConditionField = value;
                    this.RaisePropertyChanged("Condition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DayOfWeek {
            get {
                return this.DayOfWeekField;
            }
            set {
                if ((object.ReferenceEquals(this.DayOfWeekField, value) != true)) {
                    this.DayOfWeekField = value;
                    this.RaisePropertyChanged("DayOfWeek");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string High {
            get {
                return this.HighField;
            }
            set {
                if ((object.ReferenceEquals(this.HighField, value) != true)) {
                    this.HighField = value;
                    this.RaisePropertyChanged("High");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Humidity {
            get {
                return this.HumidityField;
            }
            set {
                if ((object.ReferenceEquals(this.HumidityField, value) != true)) {
                    this.HumidityField = value;
                    this.RaisePropertyChanged("Humidity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Low {
            get {
                return this.LowField;
            }
            set {
                if ((object.ReferenceEquals(this.LowField, value) != true)) {
                    this.LowField = value;
                    this.RaisePropertyChanged("Low");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TempC {
            get {
                return this.TempCField;
            }
            set {
                if ((object.ReferenceEquals(this.TempCField, value) != true)) {
                    this.TempCField = value;
                    this.RaisePropertyChanged("TempC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TempF {
            get {
                return this.TempFField;
            }
            set {
                if ((object.ReferenceEquals(this.TempFField, value) != true)) {
                    this.TempFField = value;
                    this.RaisePropertyChanged("TempF");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Wind {
            get {
                return this.WindField;
            }
            set {
                if ((object.ReferenceEquals(this.WindField, value) != true)) {
                    this.WindField = value;
                    this.RaisePropertyChanged("Wind");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceWeather.IWeatherServices")]
    public interface IWeatherServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWeatherServices/GetCurrentConditions", ReplyAction="http://tempuri.org/IWeatherServices/GetCurrentConditionsResponse")]
        FarmerPlusScheduarManager.ServiceReferenceWeather.Conditions GetCurrentConditions(string inputrequest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWeatherServicesChannel : FarmerPlusScheduarManager.ServiceReferenceWeather.IWeatherServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WeatherServicesClient : System.ServiceModel.ClientBase<FarmerPlusScheduarManager.ServiceReferenceWeather.IWeatherServices>, FarmerPlusScheduarManager.ServiceReferenceWeather.IWeatherServices {
        
        public WeatherServicesClient() {
        }
        
        public WeatherServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WeatherServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WeatherServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public FarmerPlusScheduarManager.ServiceReferenceWeather.Conditions GetCurrentConditions(string inputrequest) {
            return base.Channel.GetCurrentConditions(inputrequest);
        }
    }
}
