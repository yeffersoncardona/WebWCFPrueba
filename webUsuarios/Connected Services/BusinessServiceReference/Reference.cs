﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webUsuarios.BusinessServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BusinessServiceReference.IBusiness")]
    public interface IBusiness {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusiness/GetUsuario", ReplyAction="http://tempuri.org/IBusiness/GetUsuarioResponse")]
        string GetUsuario(int value);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBusiness/GetUsuario", ReplyAction="http://tempuri.org/IBusiness/GetUsuarioResponse")]
        System.IAsyncResult BeginGetUsuario(int value, System.AsyncCallback callback, object asyncState);
        
        string EndGetUsuario(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusiness/CreateUsuario", ReplyAction="http://tempuri.org/IBusiness/CreateUsuarioResponse")]
        string CreateUsuario(string nombre, string sexo, System.DateTime fechanacimiento);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBusiness/CreateUsuario", ReplyAction="http://tempuri.org/IBusiness/CreateUsuarioResponse")]
        System.IAsyncResult BeginCreateUsuario(string nombre, string sexo, System.DateTime fechanacimiento, System.AsyncCallback callback, object asyncState);
        
        string EndCreateUsuario(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusiness/GetAllUsuarios", ReplyAction="http://tempuri.org/IBusiness/GetAllUsuariosResponse")]
        string GetAllUsuarios();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBusiness/GetAllUsuarios", ReplyAction="http://tempuri.org/IBusiness/GetAllUsuariosResponse")]
        System.IAsyncResult BeginGetAllUsuarios(System.AsyncCallback callback, object asyncState);
        
        string EndGetAllUsuarios(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBusiness/UpdateUsuario", ReplyAction="http://tempuri.org/IBusiness/UpdateUsuarioResponse")]
        string UpdateUsuario(int id, string nombre, string sexo, System.DateTime fechanacimiento);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IBusiness/UpdateUsuario", ReplyAction="http://tempuri.org/IBusiness/UpdateUsuarioResponse")]
        System.IAsyncResult BeginUpdateUsuario(int id, string nombre, string sexo, System.DateTime fechanacimiento, System.AsyncCallback callback, object asyncState);
        
        string EndUpdateUsuario(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBusinessChannel : webUsuarios.BusinessServiceReference.IBusiness, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreateUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllUsuariosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllUsuariosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BusinessClient : System.ServiceModel.ClientBase<webUsuarios.BusinessServiceReference.IBusiness>, webUsuarios.BusinessServiceReference.IBusiness {
        
        private BeginOperationDelegate onBeginGetUsuarioDelegate;
        
        private EndOperationDelegate onEndGetUsuarioDelegate;
        
        private System.Threading.SendOrPostCallback onGetUsuarioCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateUsuarioDelegate;
        
        private EndOperationDelegate onEndCreateUsuarioDelegate;
        
        private System.Threading.SendOrPostCallback onCreateUsuarioCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllUsuariosDelegate;
        
        private EndOperationDelegate onEndGetAllUsuariosDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllUsuariosCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateUsuarioDelegate;
        
        private EndOperationDelegate onEndUpdateUsuarioDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateUsuarioCompletedDelegate;
        
        public BusinessClient() {
        }
        
        public BusinessClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BusinessClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BusinessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetUsuarioCompletedEventArgs> GetUsuarioCompleted;
        
        public event System.EventHandler<CreateUsuarioCompletedEventArgs> CreateUsuarioCompleted;
        
        public event System.EventHandler<GetAllUsuariosCompletedEventArgs> GetAllUsuariosCompleted;
        
        public event System.EventHandler<UpdateUsuarioCompletedEventArgs> UpdateUsuarioCompleted;
        
        public string GetUsuario(int value) {
            return base.Channel.GetUsuario(value);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetUsuario(int value, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetUsuario(value, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetUsuario(System.IAsyncResult result) {
            return base.Channel.EndGetUsuario(result);
        }
        
        private System.IAsyncResult OnBeginGetUsuario(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int value = ((int)(inValues[0]));
            return this.BeginGetUsuario(value, callback, asyncState);
        }
        
        private object[] OnEndGetUsuario(System.IAsyncResult result) {
            string retVal = this.EndGetUsuario(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetUsuarioCompleted(object state) {
            if ((this.GetUsuarioCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetUsuarioCompleted(this, new GetUsuarioCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetUsuarioAsync(int value) {
            this.GetUsuarioAsync(value, null);
        }
        
        public void GetUsuarioAsync(int value, object userState) {
            if ((this.onBeginGetUsuarioDelegate == null)) {
                this.onBeginGetUsuarioDelegate = new BeginOperationDelegate(this.OnBeginGetUsuario);
            }
            if ((this.onEndGetUsuarioDelegate == null)) {
                this.onEndGetUsuarioDelegate = new EndOperationDelegate(this.OnEndGetUsuario);
            }
            if ((this.onGetUsuarioCompletedDelegate == null)) {
                this.onGetUsuarioCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetUsuarioCompleted);
            }
            base.InvokeAsync(this.onBeginGetUsuarioDelegate, new object[] {
                        value}, this.onEndGetUsuarioDelegate, this.onGetUsuarioCompletedDelegate, userState);
        }
        
        public string CreateUsuario(string nombre, string sexo, System.DateTime fechanacimiento) {
            return base.Channel.CreateUsuario(nombre, sexo, fechanacimiento);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginCreateUsuario(string nombre, string sexo, System.DateTime fechanacimiento, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateUsuario(nombre, sexo, fechanacimiento, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndCreateUsuario(System.IAsyncResult result) {
            return base.Channel.EndCreateUsuario(result);
        }
        
        private System.IAsyncResult OnBeginCreateUsuario(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nombre = ((string)(inValues[0]));
            string sexo = ((string)(inValues[1]));
            System.DateTime fechanacimiento = ((System.DateTime)(inValues[2]));
            return this.BeginCreateUsuario(nombre, sexo, fechanacimiento, callback, asyncState);
        }
        
        private object[] OnEndCreateUsuario(System.IAsyncResult result) {
            string retVal = this.EndCreateUsuario(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCreateUsuarioCompleted(object state) {
            if ((this.CreateUsuarioCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateUsuarioCompleted(this, new CreateUsuarioCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateUsuarioAsync(string nombre, string sexo, System.DateTime fechanacimiento) {
            this.CreateUsuarioAsync(nombre, sexo, fechanacimiento, null);
        }
        
        public void CreateUsuarioAsync(string nombre, string sexo, System.DateTime fechanacimiento, object userState) {
            if ((this.onBeginCreateUsuarioDelegate == null)) {
                this.onBeginCreateUsuarioDelegate = new BeginOperationDelegate(this.OnBeginCreateUsuario);
            }
            if ((this.onEndCreateUsuarioDelegate == null)) {
                this.onEndCreateUsuarioDelegate = new EndOperationDelegate(this.OnEndCreateUsuario);
            }
            if ((this.onCreateUsuarioCompletedDelegate == null)) {
                this.onCreateUsuarioCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateUsuarioCompleted);
            }
            base.InvokeAsync(this.onBeginCreateUsuarioDelegate, new object[] {
                        nombre,
                        sexo,
                        fechanacimiento}, this.onEndCreateUsuarioDelegate, this.onCreateUsuarioCompletedDelegate, userState);
        }
        
        public string GetAllUsuarios() {
            return base.Channel.GetAllUsuarios();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllUsuarios(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllUsuarios(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetAllUsuarios(System.IAsyncResult result) {
            return base.Channel.EndGetAllUsuarios(result);
        }
        
        private System.IAsyncResult OnBeginGetAllUsuarios(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAllUsuarios(callback, asyncState);
        }
        
        private object[] OnEndGetAllUsuarios(System.IAsyncResult result) {
            string retVal = this.EndGetAllUsuarios(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllUsuariosCompleted(object state) {
            if ((this.GetAllUsuariosCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllUsuariosCompleted(this, new GetAllUsuariosCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllUsuariosAsync() {
            this.GetAllUsuariosAsync(null);
        }
        
        public void GetAllUsuariosAsync(object userState) {
            if ((this.onBeginGetAllUsuariosDelegate == null)) {
                this.onBeginGetAllUsuariosDelegate = new BeginOperationDelegate(this.OnBeginGetAllUsuarios);
            }
            if ((this.onEndGetAllUsuariosDelegate == null)) {
                this.onEndGetAllUsuariosDelegate = new EndOperationDelegate(this.OnEndGetAllUsuarios);
            }
            if ((this.onGetAllUsuariosCompletedDelegate == null)) {
                this.onGetAllUsuariosCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllUsuariosCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllUsuariosDelegate, null, this.onEndGetAllUsuariosDelegate, this.onGetAllUsuariosCompletedDelegate, userState);
        }
        
        public string UpdateUsuario(int id, string nombre, string sexo, System.DateTime fechanacimiento) {
            return base.Channel.UpdateUsuario(id, nombre, sexo, fechanacimiento);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpdateUsuario(int id, string nombre, string sexo, System.DateTime fechanacimiento, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateUsuario(id, nombre, sexo, fechanacimiento, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndUpdateUsuario(System.IAsyncResult result) {
            return base.Channel.EndUpdateUsuario(result);
        }
        
        private System.IAsyncResult OnBeginUpdateUsuario(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            string nombre = ((string)(inValues[1]));
            string sexo = ((string)(inValues[2]));
            System.DateTime fechanacimiento = ((System.DateTime)(inValues[3]));
            return this.BeginUpdateUsuario(id, nombre, sexo, fechanacimiento, callback, asyncState);
        }
        
        private object[] OnEndUpdateUsuario(System.IAsyncResult result) {
            string retVal = this.EndUpdateUsuario(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateUsuarioCompleted(object state) {
            if ((this.UpdateUsuarioCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateUsuarioCompleted(this, new UpdateUsuarioCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateUsuarioAsync(int id, string nombre, string sexo, System.DateTime fechanacimiento) {
            this.UpdateUsuarioAsync(id, nombre, sexo, fechanacimiento, null);
        }
        
        public void UpdateUsuarioAsync(int id, string nombre, string sexo, System.DateTime fechanacimiento, object userState) {
            if ((this.onBeginUpdateUsuarioDelegate == null)) {
                this.onBeginUpdateUsuarioDelegate = new BeginOperationDelegate(this.OnBeginUpdateUsuario);
            }
            if ((this.onEndUpdateUsuarioDelegate == null)) {
                this.onEndUpdateUsuarioDelegate = new EndOperationDelegate(this.OnEndUpdateUsuario);
            }
            if ((this.onUpdateUsuarioCompletedDelegate == null)) {
                this.onUpdateUsuarioCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateUsuarioCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateUsuarioDelegate, new object[] {
                        id,
                        nombre,
                        sexo,
                        fechanacimiento}, this.onEndUpdateUsuarioDelegate, this.onUpdateUsuarioCompletedDelegate, userState);
        }
    }
}
