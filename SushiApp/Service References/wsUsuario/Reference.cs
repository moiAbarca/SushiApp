﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsUsuario.ServiceUsuario")]
    public interface ServiceUsuario {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/obtenerUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/obtenerUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsUsuario.obtenerUsuarioResponse obtenerUsuario(SushiApp.wsUsuario.obtenerUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/obtenerUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/obtenerUsuarioResponse")]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.obtenerUsuarioResponse> obtenerUsuarioAsync(SushiApp.wsUsuario.obtenerUsuarioRequest request);
        
        // CODEGEN: El parámetro 'usuario' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/modificarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/modificarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsUsuario.modificarUsuarioResponse modificarUsuario(SushiApp.wsUsuario.modificarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/modificarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/modificarUsuarioResponse")]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.modificarUsuarioResponse> modificarUsuarioAsync(SushiApp.wsUsuario.modificarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'usuario' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/agregarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/agregarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsUsuario.agregarUsuarioResponse agregarUsuario(SushiApp.wsUsuario.agregarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/agregarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/agregarUsuarioResponse")]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.agregarUsuarioResponse> agregarUsuarioAsync(SushiApp.wsUsuario.agregarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/eliminarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/eliminarUsuarioResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsUsuario.eliminarUsuarioResponse eliminarUsuario(SushiApp.wsUsuario.eliminarUsuarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/eliminarUsuarioRequest", ReplyAction="http://WebService/ServiceUsuario/eliminarUsuarioResponse")]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(SushiApp.wsUsuario.eliminarUsuarioRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/buscarLoginRequest", ReplyAction="http://WebService/ServiceUsuario/buscarLoginResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsUsuario.buscarLoginResponse buscarLogin(SushiApp.wsUsuario.buscarLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceUsuario/buscarLoginRequest", ReplyAction="http://WebService/ServiceUsuario/buscarLoginResponse")]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.buscarLoginResponse> buscarLoginAsync(SushiApp.wsUsuario.buscarLoginRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class usuario : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string passField;
        
        private string usuario1Field;
        
        private int usuarioIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usuario", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string usuario1 {
            get {
                return this.usuario1Field;
            }
            set {
                this.usuario1Field = value;
                this.RaisePropertyChanged("usuario1");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int usuarioId {
            get {
                return this.usuarioIdField;
            }
            set {
                this.usuarioIdField = value;
                this.RaisePropertyChanged("usuarioId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerUsuario", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerUsuarioRequest {
        
        public obtenerUsuarioRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerUsuarioResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerUsuarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsUsuario.usuario[] @return;
        
        public obtenerUsuarioResponse() {
        }
        
        public obtenerUsuarioResponse(SushiApp.wsUsuario.usuario[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarUsuario", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsUsuario.usuario usuario;
        
        public modificarUsuarioRequest() {
        }
        
        public modificarUsuarioRequest(SushiApp.wsUsuario.usuario usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarUsuarioResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarUsuarioResponse {
        
        public modificarUsuarioResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarUsuario", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsUsuario.usuario usuario;
        
        public agregarUsuarioRequest() {
        }
        
        public agregarUsuarioRequest(SushiApp.wsUsuario.usuario usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarUsuarioResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarUsuarioResponse {
        
        public agregarUsuarioResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuario", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarUsuarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarUsuarioRequest() {
        }
        
        public eliminarUsuarioRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarUsuarioResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarUsuarioResponse {
        
        public eliminarUsuarioResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarLogin", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string usuario;
        
        public buscarLoginRequest() {
        }
        
        public buscarLoginRequest(string usuario) {
            this.usuario = usuario;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarLoginResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsUsuario.usuario @return;
        
        public buscarLoginResponse() {
        }
        
        public buscarLoginResponse(SushiApp.wsUsuario.usuario @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceUsuarioChannel : SushiApp.wsUsuario.ServiceUsuario, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceUsuarioClient : System.ServiceModel.ClientBase<SushiApp.wsUsuario.ServiceUsuario>, SushiApp.wsUsuario.ServiceUsuario {
        
        public ServiceUsuarioClient() {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUsuarioClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceUsuarioClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsUsuario.obtenerUsuarioResponse SushiApp.wsUsuario.ServiceUsuario.obtenerUsuario(SushiApp.wsUsuario.obtenerUsuarioRequest request) {
            return base.Channel.obtenerUsuario(request);
        }
        
        public SushiApp.wsUsuario.usuario[] obtenerUsuario() {
            SushiApp.wsUsuario.obtenerUsuarioRequest inValue = new SushiApp.wsUsuario.obtenerUsuarioRequest();
            SushiApp.wsUsuario.obtenerUsuarioResponse retVal = ((SushiApp.wsUsuario.ServiceUsuario)(this)).obtenerUsuario(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.obtenerUsuarioResponse> SushiApp.wsUsuario.ServiceUsuario.obtenerUsuarioAsync(SushiApp.wsUsuario.obtenerUsuarioRequest request) {
            return base.Channel.obtenerUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsUsuario.obtenerUsuarioResponse> obtenerUsuarioAsync() {
            SushiApp.wsUsuario.obtenerUsuarioRequest inValue = new SushiApp.wsUsuario.obtenerUsuarioRequest();
            return ((SushiApp.wsUsuario.ServiceUsuario)(this)).obtenerUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsUsuario.modificarUsuarioResponse SushiApp.wsUsuario.ServiceUsuario.modificarUsuario(SushiApp.wsUsuario.modificarUsuarioRequest request) {
            return base.Channel.modificarUsuario(request);
        }
        
        public void modificarUsuario(SushiApp.wsUsuario.usuario usuario) {
            SushiApp.wsUsuario.modificarUsuarioRequest inValue = new SushiApp.wsUsuario.modificarUsuarioRequest();
            inValue.usuario = usuario;
            SushiApp.wsUsuario.modificarUsuarioResponse retVal = ((SushiApp.wsUsuario.ServiceUsuario)(this)).modificarUsuario(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.modificarUsuarioResponse> SushiApp.wsUsuario.ServiceUsuario.modificarUsuarioAsync(SushiApp.wsUsuario.modificarUsuarioRequest request) {
            return base.Channel.modificarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsUsuario.modificarUsuarioResponse> modificarUsuarioAsync(SushiApp.wsUsuario.usuario usuario) {
            SushiApp.wsUsuario.modificarUsuarioRequest inValue = new SushiApp.wsUsuario.modificarUsuarioRequest();
            inValue.usuario = usuario;
            return ((SushiApp.wsUsuario.ServiceUsuario)(this)).modificarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsUsuario.agregarUsuarioResponse SushiApp.wsUsuario.ServiceUsuario.agregarUsuario(SushiApp.wsUsuario.agregarUsuarioRequest request) {
            return base.Channel.agregarUsuario(request);
        }
        
        public void agregarUsuario(SushiApp.wsUsuario.usuario usuario) {
            SushiApp.wsUsuario.agregarUsuarioRequest inValue = new SushiApp.wsUsuario.agregarUsuarioRequest();
            inValue.usuario = usuario;
            SushiApp.wsUsuario.agregarUsuarioResponse retVal = ((SushiApp.wsUsuario.ServiceUsuario)(this)).agregarUsuario(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.agregarUsuarioResponse> SushiApp.wsUsuario.ServiceUsuario.agregarUsuarioAsync(SushiApp.wsUsuario.agregarUsuarioRequest request) {
            return base.Channel.agregarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsUsuario.agregarUsuarioResponse> agregarUsuarioAsync(SushiApp.wsUsuario.usuario usuario) {
            SushiApp.wsUsuario.agregarUsuarioRequest inValue = new SushiApp.wsUsuario.agregarUsuarioRequest();
            inValue.usuario = usuario;
            return ((SushiApp.wsUsuario.ServiceUsuario)(this)).agregarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsUsuario.eliminarUsuarioResponse SushiApp.wsUsuario.ServiceUsuario.eliminarUsuario(SushiApp.wsUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuario(request);
        }
        
        public void eliminarUsuario(int id) {
            SushiApp.wsUsuario.eliminarUsuarioRequest inValue = new SushiApp.wsUsuario.eliminarUsuarioRequest();
            inValue.id = id;
            SushiApp.wsUsuario.eliminarUsuarioResponse retVal = ((SushiApp.wsUsuario.ServiceUsuario)(this)).eliminarUsuario(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.eliminarUsuarioResponse> SushiApp.wsUsuario.ServiceUsuario.eliminarUsuarioAsync(SushiApp.wsUsuario.eliminarUsuarioRequest request) {
            return base.Channel.eliminarUsuarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsUsuario.eliminarUsuarioResponse> eliminarUsuarioAsync(int id) {
            SushiApp.wsUsuario.eliminarUsuarioRequest inValue = new SushiApp.wsUsuario.eliminarUsuarioRequest();
            inValue.id = id;
            return ((SushiApp.wsUsuario.ServiceUsuario)(this)).eliminarUsuarioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsUsuario.buscarLoginResponse SushiApp.wsUsuario.ServiceUsuario.buscarLogin(SushiApp.wsUsuario.buscarLoginRequest request) {
            return base.Channel.buscarLogin(request);
        }
        
        public SushiApp.wsUsuario.usuario buscarLogin(string usuario) {
            SushiApp.wsUsuario.buscarLoginRequest inValue = new SushiApp.wsUsuario.buscarLoginRequest();
            inValue.usuario = usuario;
            SushiApp.wsUsuario.buscarLoginResponse retVal = ((SushiApp.wsUsuario.ServiceUsuario)(this)).buscarLogin(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsUsuario.buscarLoginResponse> SushiApp.wsUsuario.ServiceUsuario.buscarLoginAsync(SushiApp.wsUsuario.buscarLoginRequest request) {
            return base.Channel.buscarLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsUsuario.buscarLoginResponse> buscarLoginAsync(string usuario) {
            SushiApp.wsUsuario.buscarLoginRequest inValue = new SushiApp.wsUsuario.buscarLoginRequest();
            inValue.usuario = usuario;
            return ((SushiApp.wsUsuario.ServiceUsuario)(this)).buscarLoginAsync(inValue);
        }
    }
}
