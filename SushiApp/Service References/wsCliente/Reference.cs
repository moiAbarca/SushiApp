﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsCliente {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsCliente.ServiceCliente")]
    public interface ServiceCliente {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/obtenerClienteRequest", ReplyAction="http://WebService/ServiceCliente/obtenerClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsCliente.obtenerClienteResponse obtenerCliente(SushiApp.wsCliente.obtenerClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/obtenerClienteRequest", ReplyAction="http://WebService/ServiceCliente/obtenerClienteResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.obtenerClienteResponse> obtenerClienteAsync(SushiApp.wsCliente.obtenerClienteRequest request);
        
        // CODEGEN: El parámetro 'cliente' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/agregarClienteRequest", ReplyAction="http://WebService/ServiceCliente/agregarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCliente.agregarClienteResponse agregarCliente(SushiApp.wsCliente.agregarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/agregarClienteRequest", ReplyAction="http://WebService/ServiceCliente/agregarClienteResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.agregarClienteResponse> agregarClienteAsync(SushiApp.wsCliente.agregarClienteRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/eliminarClienteRequest", ReplyAction="http://WebService/ServiceCliente/eliminarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCliente.eliminarClienteResponse eliminarCliente(SushiApp.wsCliente.eliminarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/eliminarClienteRequest", ReplyAction="http://WebService/ServiceCliente/eliminarClienteResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.eliminarClienteResponse> eliminarClienteAsync(SushiApp.wsCliente.eliminarClienteRequest request);
        
        // CODEGEN: El parámetro 'cliente' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/modificarClienteRequest", ReplyAction="http://WebService/ServiceCliente/modificarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCliente.modificarClienteResponse modificarCliente(SushiApp.wsCliente.modificarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/modificarClienteRequest", ReplyAction="http://WebService/ServiceCliente/modificarClienteResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.modificarClienteResponse> modificarClienteAsync(SushiApp.wsCliente.modificarClienteRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/buscarClienteRequest", ReplyAction="http://WebService/ServiceCliente/buscarClienteResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsCliente.buscarClienteResponse buscarCliente(SushiApp.wsCliente.buscarClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/buscarClienteRequest", ReplyAction="http://WebService/ServiceCliente/buscarClienteResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteResponse> buscarClienteAsync(SushiApp.wsCliente.buscarClienteRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/buscarClienteRutRequest", ReplyAction="http://WebService/ServiceCliente/buscarClienteRutResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsCliente.buscarClienteRutResponse buscarClienteRut(SushiApp.wsCliente.buscarClienteRutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCliente/buscarClienteRutRequest", ReplyAction="http://WebService/ServiceCliente/buscarClienteRutResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteRutResponse> buscarClienteRutAsync(SushiApp.wsCliente.buscarClienteRutRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class cliente : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string apellidoField;
        
        private int clienteIdField;
        
        private string comunaField;
        
        private string direccionField;
        
        private string emailField;
        
        private string fechaNacimientoField;
        
        private string nombreField;
        
        private string rutField;
        
        private string sexoField;
        
        private int telefonoField;
        
        private int usuarioIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string apellido {
            get {
                return this.apellidoField;
            }
            set {
                this.apellidoField = value;
                this.RaisePropertyChanged("apellido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int clienteId {
            get {
                return this.clienteIdField;
            }
            set {
                this.clienteIdField = value;
                this.RaisePropertyChanged("clienteId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string comuna {
            get {
                return this.comunaField;
            }
            set {
                this.comunaField = value;
                this.RaisePropertyChanged("comuna");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
                this.RaisePropertyChanged("direccion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
                this.RaisePropertyChanged("email");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
                this.RaisePropertyChanged("fechaNacimiento");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                this.nombreField = value;
                this.RaisePropertyChanged("nombre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string rut {
            get {
                return this.rutField;
            }
            set {
                this.rutField = value;
                this.RaisePropertyChanged("rut");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=8)]
        public string sexo {
            get {
                return this.sexoField;
            }
            set {
                this.sexoField = value;
                this.RaisePropertyChanged("sexo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=9)]
        public int telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
                this.RaisePropertyChanged("telefono");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=10)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerCliente", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerClienteRequest {
        
        public obtenerClienteRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerClienteResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCliente.cliente[] @return;
        
        public obtenerClienteResponse() {
        }
        
        public obtenerClienteResponse(SushiApp.wsCliente.cliente[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarCliente", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCliente.cliente cliente;
        
        public agregarClienteRequest() {
        }
        
        public agregarClienteRequest(SushiApp.wsCliente.cliente cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarClienteResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarClienteResponse {
        
        public agregarClienteResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCliente", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarClienteRequest() {
        }
        
        public eliminarClienteRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarClienteResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarClienteResponse {
        
        public eliminarClienteResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCliente", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCliente.cliente cliente;
        
        public modificarClienteRequest() {
        }
        
        public modificarClienteRequest(SushiApp.wsCliente.cliente cliente) {
            this.cliente = cliente;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarClienteResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarClienteResponse {
        
        public modificarClienteResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarCliente", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarClienteRequest() {
        }
        
        public buscarClienteRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarClienteResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCliente.cliente @return;
        
        public buscarClienteResponse() {
        }
        
        public buscarClienteResponse(SushiApp.wsCliente.cliente @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarClienteRut", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarClienteRutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rut;
        
        public buscarClienteRutRequest() {
        }
        
        public buscarClienteRutRequest(string rut) {
            this.rut = rut;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarClienteRutResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarClienteRutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCliente.cliente @return;
        
        public buscarClienteRutResponse() {
        }
        
        public buscarClienteRutResponse(SushiApp.wsCliente.cliente @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceClienteChannel : SushiApp.wsCliente.ServiceCliente, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClienteClient : System.ServiceModel.ClientBase<SushiApp.wsCliente.ServiceCliente>, SushiApp.wsCliente.ServiceCliente {
        
        public ServiceClienteClient() {
        }
        
        public ServiceClienteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClienteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.obtenerClienteResponse SushiApp.wsCliente.ServiceCliente.obtenerCliente(SushiApp.wsCliente.obtenerClienteRequest request) {
            return base.Channel.obtenerCliente(request);
        }
        
        public SushiApp.wsCliente.cliente[] obtenerCliente() {
            SushiApp.wsCliente.obtenerClienteRequest inValue = new SushiApp.wsCliente.obtenerClienteRequest();
            SushiApp.wsCliente.obtenerClienteResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).obtenerCliente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.obtenerClienteResponse> SushiApp.wsCliente.ServiceCliente.obtenerClienteAsync(SushiApp.wsCliente.obtenerClienteRequest request) {
            return base.Channel.obtenerClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.obtenerClienteResponse> obtenerClienteAsync() {
            SushiApp.wsCliente.obtenerClienteRequest inValue = new SushiApp.wsCliente.obtenerClienteRequest();
            return ((SushiApp.wsCliente.ServiceCliente)(this)).obtenerClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.agregarClienteResponse SushiApp.wsCliente.ServiceCliente.agregarCliente(SushiApp.wsCliente.agregarClienteRequest request) {
            return base.Channel.agregarCliente(request);
        }
        
        public void agregarCliente(SushiApp.wsCliente.cliente cliente) {
            SushiApp.wsCliente.agregarClienteRequest inValue = new SushiApp.wsCliente.agregarClienteRequest();
            inValue.cliente = cliente;
            SushiApp.wsCliente.agregarClienteResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).agregarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.agregarClienteResponse> SushiApp.wsCliente.ServiceCliente.agregarClienteAsync(SushiApp.wsCliente.agregarClienteRequest request) {
            return base.Channel.agregarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.agregarClienteResponse> agregarClienteAsync(SushiApp.wsCliente.cliente cliente) {
            SushiApp.wsCliente.agregarClienteRequest inValue = new SushiApp.wsCliente.agregarClienteRequest();
            inValue.cliente = cliente;
            return ((SushiApp.wsCliente.ServiceCliente)(this)).agregarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.eliminarClienteResponse SushiApp.wsCliente.ServiceCliente.eliminarCliente(SushiApp.wsCliente.eliminarClienteRequest request) {
            return base.Channel.eliminarCliente(request);
        }
        
        public void eliminarCliente(int id) {
            SushiApp.wsCliente.eliminarClienteRequest inValue = new SushiApp.wsCliente.eliminarClienteRequest();
            inValue.id = id;
            SushiApp.wsCliente.eliminarClienteResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).eliminarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.eliminarClienteResponse> SushiApp.wsCliente.ServiceCliente.eliminarClienteAsync(SushiApp.wsCliente.eliminarClienteRequest request) {
            return base.Channel.eliminarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.eliminarClienteResponse> eliminarClienteAsync(int id) {
            SushiApp.wsCliente.eliminarClienteRequest inValue = new SushiApp.wsCliente.eliminarClienteRequest();
            inValue.id = id;
            return ((SushiApp.wsCliente.ServiceCliente)(this)).eliminarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.modificarClienteResponse SushiApp.wsCliente.ServiceCliente.modificarCliente(SushiApp.wsCliente.modificarClienteRequest request) {
            return base.Channel.modificarCliente(request);
        }
        
        public void modificarCliente(SushiApp.wsCliente.cliente cliente) {
            SushiApp.wsCliente.modificarClienteRequest inValue = new SushiApp.wsCliente.modificarClienteRequest();
            inValue.cliente = cliente;
            SushiApp.wsCliente.modificarClienteResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).modificarCliente(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.modificarClienteResponse> SushiApp.wsCliente.ServiceCliente.modificarClienteAsync(SushiApp.wsCliente.modificarClienteRequest request) {
            return base.Channel.modificarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.modificarClienteResponse> modificarClienteAsync(SushiApp.wsCliente.cliente cliente) {
            SushiApp.wsCliente.modificarClienteRequest inValue = new SushiApp.wsCliente.modificarClienteRequest();
            inValue.cliente = cliente;
            return ((SushiApp.wsCliente.ServiceCliente)(this)).modificarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.buscarClienteResponse SushiApp.wsCliente.ServiceCliente.buscarCliente(SushiApp.wsCliente.buscarClienteRequest request) {
            return base.Channel.buscarCliente(request);
        }
        
        public SushiApp.wsCliente.cliente buscarCliente(int id) {
            SushiApp.wsCliente.buscarClienteRequest inValue = new SushiApp.wsCliente.buscarClienteRequest();
            inValue.id = id;
            SushiApp.wsCliente.buscarClienteResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).buscarCliente(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteResponse> SushiApp.wsCliente.ServiceCliente.buscarClienteAsync(SushiApp.wsCliente.buscarClienteRequest request) {
            return base.Channel.buscarClienteAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteResponse> buscarClienteAsync(int id) {
            SushiApp.wsCliente.buscarClienteRequest inValue = new SushiApp.wsCliente.buscarClienteRequest();
            inValue.id = id;
            return ((SushiApp.wsCliente.ServiceCliente)(this)).buscarClienteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCliente.buscarClienteRutResponse SushiApp.wsCliente.ServiceCliente.buscarClienteRut(SushiApp.wsCliente.buscarClienteRutRequest request) {
            return base.Channel.buscarClienteRut(request);
        }
        
        public SushiApp.wsCliente.cliente buscarClienteRut(string rut) {
            SushiApp.wsCliente.buscarClienteRutRequest inValue = new SushiApp.wsCliente.buscarClienteRutRequest();
            inValue.rut = rut;
            SushiApp.wsCliente.buscarClienteRutResponse retVal = ((SushiApp.wsCliente.ServiceCliente)(this)).buscarClienteRut(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteRutResponse> SushiApp.wsCliente.ServiceCliente.buscarClienteRutAsync(SushiApp.wsCliente.buscarClienteRutRequest request) {
            return base.Channel.buscarClienteRutAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCliente.buscarClienteRutResponse> buscarClienteRutAsync(string rut) {
            SushiApp.wsCliente.buscarClienteRutRequest inValue = new SushiApp.wsCliente.buscarClienteRutRequest();
            inValue.rut = rut;
            return ((SushiApp.wsCliente.ServiceCliente)(this)).buscarClienteRutAsync(inValue);
        }
    }
}
