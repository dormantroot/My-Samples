﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace AdventureWorksManagement.AdvWorksManagementService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="Employees", Namespace="http://MyTestingGroundService.Model/2011/MyTestingGroundService", ItemName="Employee")]
    public class Employees : System.Collections.ObjectModel.ObservableCollection<AdventureWorksManagement.AdvWorksManagementService.Employee> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://MyTestingGroundService.Model/2011/MyTestingGroundService")]
    public partial class Employee : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private string TitleField;
        
        private string GenderField;
        
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MyTestingGroundService.Model/2011/MyTestingGroundService", ConfigurationName="AdvWorksManagementService.EmployeeServiceContract")]
    public interface EmployeeServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="GetEmployees", ReplyAction="http://MyTestingGroundService.Model/2011/MyTestingGroundService/EmployeeServiceCo" +
            "ntract/GetEmployeesResponse")]
        System.IAsyncResult BeginGetEmployees(AdventureWorksManagement.AdvWorksManagementService.GetEmployeesRequest request, System.AsyncCallback callback, object asyncState);
        
        AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse EndGetEmployees(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetEmployeesRequest {
        
        public GetEmployeesRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EmployeeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://MyTestingGroundService.Model/2011/MyTestingGroundService", Order=0)]
        public AdventureWorksManagement.AdvWorksManagementService.Employees Employees;
        
        public EmployeeResponse() {
        }
        
        public EmployeeResponse(AdventureWorksManagement.AdvWorksManagementService.Employees Employees) {
            this.Employees = Employees;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EmployeeServiceContractChannel : AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetEmployeesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetEmployeesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AdventureWorksManagement.AdvWorksManagementService.Employees Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AdventureWorksManagement.AdvWorksManagementService.Employees)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceContractClient : System.ServiceModel.ClientBase<AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract>, AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract {
        
        private BeginOperationDelegate onBeginGetEmployeesDelegate;
        
        private EndOperationDelegate onEndGetEmployeesDelegate;
        
        private System.Threading.SendOrPostCallback onGetEmployeesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public EmployeeServiceContractClient() {
        }
        
        public EmployeeServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetEmployeesCompletedEventArgs> GetEmployeesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract.BeginGetEmployees(AdventureWorksManagement.AdvWorksManagementService.GetEmployeesRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetEmployees(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginGetEmployees(System.AsyncCallback callback, object asyncState) {
            AdventureWorksManagement.AdvWorksManagementService.GetEmployeesRequest inValue = new AdventureWorksManagement.AdvWorksManagementService.GetEmployeesRequest();
            return ((AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract)(this)).BeginGetEmployees(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract.EndGetEmployees(System.IAsyncResult result) {
            return base.Channel.EndGetEmployees(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private AdventureWorksManagement.AdvWorksManagementService.Employees EndGetEmployees(System.IAsyncResult result) {
            AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse retVal = ((AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract)(this)).EndGetEmployees(result);
            return retVal.Employees;
        }
        
        private System.IAsyncResult OnBeginGetEmployees(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetEmployees(callback, asyncState);
        }
        
        private object[] OnEndGetEmployees(System.IAsyncResult result) {
            AdventureWorksManagement.AdvWorksManagementService.Employees retVal = this.EndGetEmployees(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetEmployeesCompleted(object state) {
            if ((this.GetEmployeesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetEmployeesCompleted(this, new GetEmployeesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetEmployeesAsync() {
            this.GetEmployeesAsync(null);
        }
        
        public void GetEmployeesAsync(object userState) {
            if ((this.onBeginGetEmployeesDelegate == null)) {
                this.onBeginGetEmployeesDelegate = new BeginOperationDelegate(this.OnBeginGetEmployees);
            }
            if ((this.onEndGetEmployeesDelegate == null)) {
                this.onEndGetEmployeesDelegate = new EndOperationDelegate(this.OnEndGetEmployees);
            }
            if ((this.onGetEmployeesCompletedDelegate == null)) {
                this.onGetEmployeesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetEmployeesCompleted);
            }
            base.InvokeAsync(this.onBeginGetEmployeesDelegate, null, this.onEndGetEmployeesDelegate, this.onGetEmployeesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract CreateChannel() {
            return new EmployeeServiceContractClientChannel(this);
        }
        
        private class EmployeeServiceContractClientChannel : ChannelBase<AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract>, AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract {
            
            public EmployeeServiceContractClientChannel(System.ServiceModel.ClientBase<AdventureWorksManagement.AdvWorksManagementService.EmployeeServiceContract> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetEmployees(AdventureWorksManagement.AdvWorksManagementService.GetEmployeesRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetEmployees", _args, callback, asyncState);
                return _result;
            }
            
            public AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse EndGetEmployees(System.IAsyncResult result) {
                object[] _args = new object[0];
                AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse _result = ((AdventureWorksManagement.AdvWorksManagementService.EmployeeResponse)(base.EndInvoke("GetEmployees", _args, result)));
                return _result;
            }
        }
    }
}