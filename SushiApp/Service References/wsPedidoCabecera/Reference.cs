﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsPedidoCabecera {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsPedidoCabecera.ServicePedidoCabecera")]
    public interface ServicePedidoCabecera {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/obtenerPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/obtenerPedidoCabeceraResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse obtenerPedidoCabecera(SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/obtenerPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/obtenerPedidoCabeceraResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse> obtenerPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest request);
        
        // CODEGEN: El parámetro 'pedidoCabecera' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/agregarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/agregarPedidoCabeceraResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse agregarPedidoCabecera(SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/agregarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/agregarPedidoCabeceraResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse> agregarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/eliminarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/eliminarPedidoCabeceraResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse eliminarPedidoCabecera(SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/eliminarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/eliminarPedidoCabeceraResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse> eliminarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/buscarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/buscarPedidoCabeceraResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse buscarPedidoCabecera(SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/buscarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/buscarPedidoCabeceraResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse> buscarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest request);
        
        // CODEGEN: El parámetro 'pedidoCabecera' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/modificarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/modificarPedidoCabeceraResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse modificarPedidoCabecera(SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoCabecera/modificarPedidoCabeceraRequest", ReplyAction="http://WebService/ServicePedidoCabecera/modificarPedidoCabeceraResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse> modificarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class pedidoCabecera : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int pedidoCabeceraIdField;
        
        private int establecimientoIdField;
        
        private int clienteIdField;
        
        private string fechaPedidoField;
        
        private string horaPedidoField;
        
        private string estadoPedidoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int pedidoCabeceraId {
            get {
                return this.pedidoCabeceraIdField;
            }
            set {
                this.pedidoCabeceraIdField = value;
                this.RaisePropertyChanged("pedidoCabeceraId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int establecimientoId {
            get {
                return this.establecimientoIdField;
            }
            set {
                this.establecimientoIdField = value;
                this.RaisePropertyChanged("establecimientoId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string fechaPedido {
            get {
                return this.fechaPedidoField;
            }
            set {
                this.fechaPedidoField = value;
                this.RaisePropertyChanged("fechaPedido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string horaPedido {
            get {
                return this.horaPedidoField;
            }
            set {
                this.horaPedidoField = value;
                this.RaisePropertyChanged("horaPedido");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string estadoPedido {
            get {
                return this.estadoPedidoField;
            }
            set {
                this.estadoPedidoField = value;
                this.RaisePropertyChanged("estadoPedido");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPedidoCabecera", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerPedidoCabeceraRequest {
        
        public obtenerPedidoCabeceraRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPedidoCabeceraResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerPedidoCabeceraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoCabecera.pedidoCabecera[] @return;
        
        public obtenerPedidoCabeceraResponse() {
        }
        
        public obtenerPedidoCabeceraResponse(SushiApp.wsPedidoCabecera.pedidoCabecera[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarPedidoCabecera", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarPedidoCabeceraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera;
        
        public agregarPedidoCabeceraRequest() {
        }
        
        public agregarPedidoCabeceraRequest(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            this.pedidoCabecera = pedidoCabecera;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarPedidoCabeceraResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarPedidoCabeceraResponse {
        
        public agregarPedidoCabeceraResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPedidoCabecera", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarPedidoCabeceraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarPedidoCabeceraRequest() {
        }
        
        public eliminarPedidoCabeceraRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPedidoCabeceraResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarPedidoCabeceraResponse {
        
        public eliminarPedidoCabeceraResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPedidoCabecera", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarPedidoCabeceraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarPedidoCabeceraRequest() {
        }
        
        public buscarPedidoCabeceraRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPedidoCabeceraResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarPedidoCabeceraResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoCabecera.pedidoCabecera @return;
        
        public buscarPedidoCabeceraResponse() {
        }
        
        public buscarPedidoCabeceraResponse(SushiApp.wsPedidoCabecera.pedidoCabecera @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPedidoCabecera", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarPedidoCabeceraRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera;
        
        public modificarPedidoCabeceraRequest() {
        }
        
        public modificarPedidoCabeceraRequest(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            this.pedidoCabecera = pedidoCabecera;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPedidoCabeceraResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarPedidoCabeceraResponse {
        
        public modificarPedidoCabeceraResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePedidoCabeceraChannel : SushiApp.wsPedidoCabecera.ServicePedidoCabecera, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePedidoCabeceraClient : System.ServiceModel.ClientBase<SushiApp.wsPedidoCabecera.ServicePedidoCabecera>, SushiApp.wsPedidoCabecera.ServicePedidoCabecera {
        
        public ServicePedidoCabeceraClient() {
        }
        
        public ServicePedidoCabeceraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePedidoCabeceraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePedidoCabeceraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePedidoCabeceraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse SushiApp.wsPedidoCabecera.ServicePedidoCabecera.obtenerPedidoCabecera(SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest request) {
            return base.Channel.obtenerPedidoCabecera(request);
        }
        
        public SushiApp.wsPedidoCabecera.pedidoCabecera[] obtenerPedidoCabecera() {
            SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest();
            SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse retVal = ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).obtenerPedidoCabecera(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse> SushiApp.wsPedidoCabecera.ServicePedidoCabecera.obtenerPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest request) {
            return base.Channel.obtenerPedidoCabeceraAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraResponse> obtenerPedidoCabeceraAsync() {
            SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.obtenerPedidoCabeceraRequest();
            return ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).obtenerPedidoCabeceraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse SushiApp.wsPedidoCabecera.ServicePedidoCabecera.agregarPedidoCabecera(SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest request) {
            return base.Channel.agregarPedidoCabecera(request);
        }
        
        public void agregarPedidoCabecera(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest();
            inValue.pedidoCabecera = pedidoCabecera;
            SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse retVal = ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).agregarPedidoCabecera(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse> SushiApp.wsPedidoCabecera.ServicePedidoCabecera.agregarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest request) {
            return base.Channel.agregarPedidoCabeceraAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.agregarPedidoCabeceraResponse> agregarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.agregarPedidoCabeceraRequest();
            inValue.pedidoCabecera = pedidoCabecera;
            return ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).agregarPedidoCabeceraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse SushiApp.wsPedidoCabecera.ServicePedidoCabecera.eliminarPedidoCabecera(SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest request) {
            return base.Channel.eliminarPedidoCabecera(request);
        }
        
        public void eliminarPedidoCabecera(int id) {
            SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest();
            inValue.id = id;
            SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse retVal = ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).eliminarPedidoCabecera(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse> SushiApp.wsPedidoCabecera.ServicePedidoCabecera.eliminarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest request) {
            return base.Channel.eliminarPedidoCabeceraAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraResponse> eliminarPedidoCabeceraAsync(int id) {
            SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.eliminarPedidoCabeceraRequest();
            inValue.id = id;
            return ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).eliminarPedidoCabeceraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse SushiApp.wsPedidoCabecera.ServicePedidoCabecera.buscarPedidoCabecera(SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest request) {
            return base.Channel.buscarPedidoCabecera(request);
        }
        
        public SushiApp.wsPedidoCabecera.pedidoCabecera buscarPedidoCabecera(int id) {
            SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest();
            inValue.id = id;
            SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse retVal = ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).buscarPedidoCabecera(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse> SushiApp.wsPedidoCabecera.ServicePedidoCabecera.buscarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest request) {
            return base.Channel.buscarPedidoCabeceraAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.buscarPedidoCabeceraResponse> buscarPedidoCabeceraAsync(int id) {
            SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.buscarPedidoCabeceraRequest();
            inValue.id = id;
            return ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).buscarPedidoCabeceraAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse SushiApp.wsPedidoCabecera.ServicePedidoCabecera.modificarPedidoCabecera(SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest request) {
            return base.Channel.modificarPedidoCabecera(request);
        }
        
        public void modificarPedidoCabecera(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest();
            inValue.pedidoCabecera = pedidoCabecera;
            SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse retVal = ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).modificarPedidoCabecera(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse> SushiApp.wsPedidoCabecera.ServicePedidoCabecera.modificarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest request) {
            return base.Channel.modificarPedidoCabeceraAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoCabecera.modificarPedidoCabeceraResponse> modificarPedidoCabeceraAsync(SushiApp.wsPedidoCabecera.pedidoCabecera pedidoCabecera) {
            SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest inValue = new SushiApp.wsPedidoCabecera.modificarPedidoCabeceraRequest();
            inValue.pedidoCabecera = pedidoCabecera;
            return ((SushiApp.wsPedidoCabecera.ServicePedidoCabecera)(this)).modificarPedidoCabeceraAsync(inValue);
        }
    }
}
