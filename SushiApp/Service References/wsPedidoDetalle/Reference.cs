﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsPedidoDetalle {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsPedidoDetalle.ServicePedidoDetalle")]
    public interface ServicePedidoDetalle {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/obtenerPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/obtenerPedidoDetalleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse obtenerPedidoDetalle(SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/obtenerPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/obtenerPedidoDetalleResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse> obtenerPedidoDetalleAsync(SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/buscarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/buscarPedidoDetalleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse buscarPedidoDetalle(SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/buscarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/buscarPedidoDetalleResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse> buscarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/eliminarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/eliminarPedidoDetalleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse eliminarPedidoDetalle(SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/eliminarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/eliminarPedidoDetalleResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse> eliminarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest request);
        
        // CODEGEN: El parámetro 'pedidoDetalle' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/agregarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/agregarPedidoDetalleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse agregarPedidoDetalle(SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/agregarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/agregarPedidoDetalleResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse> agregarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest request);
        
        // CODEGEN: El parámetro 'pedidoDetalle' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/modificarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/modificarPedidoDetalleResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse modificarPedidoDetalle(SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServicePedidoDetalle/modificarPedidoDetalleRequest", ReplyAction="http://WebService/ServicePedidoDetalle/modificarPedidoDetalleResponse")]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse> modificarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class pedidoDetalle : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int pedidoDetalleIdField;
        
        private int pedidoCabeceraIdField;
        
        private int productoIdField;
        
        private int cantidadField;
        
        private string fechaPedidoDetalleField;
        
        private string horaPedidoDetalleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int pedidoDetalleId {
            get {
                return this.pedidoDetalleIdField;
            }
            set {
                this.pedidoDetalleIdField = value;
                this.RaisePropertyChanged("pedidoDetalleId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int productoId {
            get {
                return this.productoIdField;
            }
            set {
                this.productoIdField = value;
                this.RaisePropertyChanged("productoId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int cantidad {
            get {
                return this.cantidadField;
            }
            set {
                this.cantidadField = value;
                this.RaisePropertyChanged("cantidad");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string fechaPedidoDetalle {
            get {
                return this.fechaPedidoDetalleField;
            }
            set {
                this.fechaPedidoDetalleField = value;
                this.RaisePropertyChanged("fechaPedidoDetalle");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public string horaPedidoDetalle {
            get {
                return this.horaPedidoDetalleField;
            }
            set {
                this.horaPedidoDetalleField = value;
                this.RaisePropertyChanged("horaPedidoDetalle");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPedidoDetalle", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerPedidoDetalleRequest {
        
        public obtenerPedidoDetalleRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerPedidoDetalleResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerPedidoDetalleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoDetalle.pedidoDetalle[] @return;
        
        public obtenerPedidoDetalleResponse() {
        }
        
        public obtenerPedidoDetalleResponse(SushiApp.wsPedidoDetalle.pedidoDetalle[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPedidoDetalle", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarPedidoDetalleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarPedidoDetalleRequest() {
        }
        
        public buscarPedidoDetalleRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarPedidoDetalleResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarPedidoDetalleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoDetalle.pedidoDetalle @return;
        
        public buscarPedidoDetalleResponse() {
        }
        
        public buscarPedidoDetalleResponse(SushiApp.wsPedidoDetalle.pedidoDetalle @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPedidoDetalle", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarPedidoDetalleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarPedidoDetalleRequest() {
        }
        
        public eliminarPedidoDetalleRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarPedidoDetalleResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarPedidoDetalleResponse {
        
        public eliminarPedidoDetalleResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarPedidoDetalle", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarPedidoDetalleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle;
        
        public agregarPedidoDetalleRequest() {
        }
        
        public agregarPedidoDetalleRequest(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            this.pedidoDetalle = pedidoDetalle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarPedidoDetalleResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarPedidoDetalleResponse {
        
        public agregarPedidoDetalleResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPedidoDetalle", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarPedidoDetalleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle;
        
        public modificarPedidoDetalleRequest() {
        }
        
        public modificarPedidoDetalleRequest(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            this.pedidoDetalle = pedidoDetalle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarPedidoDetalleResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarPedidoDetalleResponse {
        
        public modificarPedidoDetalleResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePedidoDetalleChannel : SushiApp.wsPedidoDetalle.ServicePedidoDetalle, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePedidoDetalleClient : System.ServiceModel.ClientBase<SushiApp.wsPedidoDetalle.ServicePedidoDetalle>, SushiApp.wsPedidoDetalle.ServicePedidoDetalle {
        
        public ServicePedidoDetalleClient() {
        }
        
        public ServicePedidoDetalleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePedidoDetalleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePedidoDetalleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePedidoDetalleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse SushiApp.wsPedidoDetalle.ServicePedidoDetalle.obtenerPedidoDetalle(SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest request) {
            return base.Channel.obtenerPedidoDetalle(request);
        }
        
        public SushiApp.wsPedidoDetalle.pedidoDetalle[] obtenerPedidoDetalle() {
            SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest();
            SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse retVal = ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).obtenerPedidoDetalle(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse> SushiApp.wsPedidoDetalle.ServicePedidoDetalle.obtenerPedidoDetalleAsync(SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest request) {
            return base.Channel.obtenerPedidoDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.obtenerPedidoDetalleResponse> obtenerPedidoDetalleAsync() {
            SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.obtenerPedidoDetalleRequest();
            return ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).obtenerPedidoDetalleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse SushiApp.wsPedidoDetalle.ServicePedidoDetalle.buscarPedidoDetalle(SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest request) {
            return base.Channel.buscarPedidoDetalle(request);
        }
        
        public SushiApp.wsPedidoDetalle.pedidoDetalle buscarPedidoDetalle(int id) {
            SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest();
            inValue.id = id;
            SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse retVal = ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).buscarPedidoDetalle(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse> SushiApp.wsPedidoDetalle.ServicePedidoDetalle.buscarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest request) {
            return base.Channel.buscarPedidoDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.buscarPedidoDetalleResponse> buscarPedidoDetalleAsync(int id) {
            SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.buscarPedidoDetalleRequest();
            inValue.id = id;
            return ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).buscarPedidoDetalleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse SushiApp.wsPedidoDetalle.ServicePedidoDetalle.eliminarPedidoDetalle(SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest request) {
            return base.Channel.eliminarPedidoDetalle(request);
        }
        
        public void eliminarPedidoDetalle(int id) {
            SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest();
            inValue.id = id;
            SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse retVal = ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).eliminarPedidoDetalle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse> SushiApp.wsPedidoDetalle.ServicePedidoDetalle.eliminarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest request) {
            return base.Channel.eliminarPedidoDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.eliminarPedidoDetalleResponse> eliminarPedidoDetalleAsync(int id) {
            SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.eliminarPedidoDetalleRequest();
            inValue.id = id;
            return ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).eliminarPedidoDetalleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse SushiApp.wsPedidoDetalle.ServicePedidoDetalle.agregarPedidoDetalle(SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest request) {
            return base.Channel.agregarPedidoDetalle(request);
        }
        
        public void agregarPedidoDetalle(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest();
            inValue.pedidoDetalle = pedidoDetalle;
            SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse retVal = ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).agregarPedidoDetalle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse> SushiApp.wsPedidoDetalle.ServicePedidoDetalle.agregarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest request) {
            return base.Channel.agregarPedidoDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.agregarPedidoDetalleResponse> agregarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.agregarPedidoDetalleRequest();
            inValue.pedidoDetalle = pedidoDetalle;
            return ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).agregarPedidoDetalleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse SushiApp.wsPedidoDetalle.ServicePedidoDetalle.modificarPedidoDetalle(SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest request) {
            return base.Channel.modificarPedidoDetalle(request);
        }
        
        public void modificarPedidoDetalle(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest();
            inValue.pedidoDetalle = pedidoDetalle;
            SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse retVal = ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).modificarPedidoDetalle(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse> SushiApp.wsPedidoDetalle.ServicePedidoDetalle.modificarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest request) {
            return base.Channel.modificarPedidoDetalleAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsPedidoDetalle.modificarPedidoDetalleResponse> modificarPedidoDetalleAsync(SushiApp.wsPedidoDetalle.pedidoDetalle pedidoDetalle) {
            SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest inValue = new SushiApp.wsPedidoDetalle.modificarPedidoDetalleRequest();
            inValue.pedidoDetalle = pedidoDetalle;
            return ((SushiApp.wsPedidoDetalle.ServicePedidoDetalle)(this)).modificarPedidoDetalleAsync(inValue);
        }
    }
}
