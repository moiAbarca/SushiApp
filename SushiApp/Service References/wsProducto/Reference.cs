﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsProducto {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsProducto.ServiceProducto")]
    public interface ServiceProducto {
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/eliminarProductoRequest", ReplyAction="http://WebService/ServiceProducto/eliminarProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProducto.eliminarProductoResponse eliminarProducto(SushiApp.wsProducto.eliminarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/eliminarProductoRequest", ReplyAction="http://WebService/ServiceProducto/eliminarProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.eliminarProductoResponse> eliminarProductoAsync(SushiApp.wsProducto.eliminarProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/obtenerProductoRequest", ReplyAction="http://WebService/ServiceProducto/obtenerProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsProducto.obtenerProductoResponse obtenerProducto(SushiApp.wsProducto.obtenerProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/obtenerProductoRequest", ReplyAction="http://WebService/ServiceProducto/obtenerProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.obtenerProductoResponse> obtenerProductoAsync(SushiApp.wsProducto.obtenerProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/buscarProductoRequest", ReplyAction="http://WebService/ServiceProducto/buscarProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsProducto.buscarProductoResponse buscarProducto(SushiApp.wsProducto.buscarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/buscarProductoRequest", ReplyAction="http://WebService/ServiceProducto/buscarProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoResponse> buscarProductoAsync(SushiApp.wsProducto.buscarProductoRequest request);
        
        // CODEGEN: El parámetro 'producto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/agregarProductoRequest", ReplyAction="http://WebService/ServiceProducto/agregarProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProducto.agregarProductoResponse agregarProducto(SushiApp.wsProducto.agregarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/agregarProductoRequest", ReplyAction="http://WebService/ServiceProducto/agregarProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.agregarProductoResponse> agregarProductoAsync(SushiApp.wsProducto.agregarProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/buscarProductoNombreRequest", ReplyAction="http://WebService/ServiceProducto/buscarProductoNombreResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsProducto.buscarProductoNombreResponse buscarProductoNombre(SushiApp.wsProducto.buscarProductoNombreRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/buscarProductoNombreRequest", ReplyAction="http://WebService/ServiceProducto/buscarProductoNombreResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoNombreResponse> buscarProductoNombreAsync(SushiApp.wsProducto.buscarProductoNombreRequest request);
        
        // CODEGEN: El parámetro 'producto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/modificarProductoRequest", ReplyAction="http://WebService/ServiceProducto/modificarProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsProducto.modificarProductoResponse modificarProducto(SushiApp.wsProducto.modificarProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceProducto/modificarProductoRequest", ReplyAction="http://WebService/ServiceProducto/modificarProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsProducto.modificarProductoResponse> modificarProductoAsync(SushiApp.wsProducto.modificarProductoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarProductoRequest() {
        }
        
        public eliminarProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarProductoResponse {
        
        public eliminarProductoResponse() {
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class producto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int categoriaProductoIdField;
        
        private string descripcionProductoField;
        
        private bool disponibilidadProductoField;
        
        private string imagenProdcutoField;
        
        private string nombreProductoField;
        
        private int porcionesProdcutoField;
        
        private int precioProductoField;
        
        private int productoIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int categoriaProductoId {
            get {
                return this.categoriaProductoIdField;
            }
            set {
                this.categoriaProductoIdField = value;
                this.RaisePropertyChanged("categoriaProductoId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string descripcionProducto {
            get {
                return this.descripcionProductoField;
            }
            set {
                this.descripcionProductoField = value;
                this.RaisePropertyChanged("descripcionProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public bool disponibilidadProducto {
            get {
                return this.disponibilidadProductoField;
            }
            set {
                this.disponibilidadProductoField = value;
                this.RaisePropertyChanged("disponibilidadProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string imagenProdcuto {
            get {
                return this.imagenProdcutoField;
            }
            set {
                this.imagenProdcutoField = value;
                this.RaisePropertyChanged("imagenProdcuto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public string nombreProducto {
            get {
                return this.nombreProductoField;
            }
            set {
                this.nombreProductoField = value;
                this.RaisePropertyChanged("nombreProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public int porcionesProdcuto {
            get {
                return this.porcionesProdcutoField;
            }
            set {
                this.porcionesProdcutoField = value;
                this.RaisePropertyChanged("porcionesProdcuto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int precioProducto {
            get {
                return this.precioProductoField;
            }
            set {
                this.precioProductoField = value;
                this.RaisePropertyChanged("precioProducto");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public int productoId {
            get {
                return this.productoIdField;
            }
            set {
                this.productoIdField = value;
                this.RaisePropertyChanged("productoId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerProductoRequest {
        
        public obtenerProductoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProducto.producto[] @return;
        
        public obtenerProductoResponse() {
        }
        
        public obtenerProductoResponse(SushiApp.wsProducto.producto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarProductoRequest() {
        }
        
        public buscarProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProducto.producto @return;
        
        public buscarProductoResponse() {
        }
        
        public buscarProductoResponse(SushiApp.wsProducto.producto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProducto.producto producto;
        
        public agregarProductoRequest() {
        }
        
        public agregarProductoRequest(SushiApp.wsProducto.producto producto) {
            this.producto = producto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarProductoResponse {
        
        public agregarProductoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProductoNombre", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProductoNombreRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string nombre;
        
        public buscarProductoNombreRequest() {
        }
        
        public buscarProductoNombreRequest(string nombre) {
            this.nombre = nombre;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarProductoNombreResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarProductoNombreResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProducto.producto @return;
        
        public buscarProductoNombreResponse() {
        }
        
        public buscarProductoNombreResponse(SushiApp.wsProducto.producto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsProducto.producto producto;
        
        public modificarProductoRequest() {
        }
        
        public modificarProductoRequest(SushiApp.wsProducto.producto producto) {
            this.producto = producto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarProductoResponse {
        
        public modificarProductoResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceProductoChannel : SushiApp.wsProducto.ServiceProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceProductoClient : System.ServiceModel.ClientBase<SushiApp.wsProducto.ServiceProducto>, SushiApp.wsProducto.ServiceProducto {
        
        public ServiceProductoClient() {
        }
        
        public ServiceProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.eliminarProductoResponse SushiApp.wsProducto.ServiceProducto.eliminarProducto(SushiApp.wsProducto.eliminarProductoRequest request) {
            return base.Channel.eliminarProducto(request);
        }
        
        public void eliminarProducto(int id) {
            SushiApp.wsProducto.eliminarProductoRequest inValue = new SushiApp.wsProducto.eliminarProductoRequest();
            inValue.id = id;
            SushiApp.wsProducto.eliminarProductoResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).eliminarProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.eliminarProductoResponse> SushiApp.wsProducto.ServiceProducto.eliminarProductoAsync(SushiApp.wsProducto.eliminarProductoRequest request) {
            return base.Channel.eliminarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.eliminarProductoResponse> eliminarProductoAsync(int id) {
            SushiApp.wsProducto.eliminarProductoRequest inValue = new SushiApp.wsProducto.eliminarProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsProducto.ServiceProducto)(this)).eliminarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.obtenerProductoResponse SushiApp.wsProducto.ServiceProducto.obtenerProducto(SushiApp.wsProducto.obtenerProductoRequest request) {
            return base.Channel.obtenerProducto(request);
        }
        
        public SushiApp.wsProducto.producto[] obtenerProducto() {
            SushiApp.wsProducto.obtenerProductoRequest inValue = new SushiApp.wsProducto.obtenerProductoRequest();
            SushiApp.wsProducto.obtenerProductoResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).obtenerProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.obtenerProductoResponse> SushiApp.wsProducto.ServiceProducto.obtenerProductoAsync(SushiApp.wsProducto.obtenerProductoRequest request) {
            return base.Channel.obtenerProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.obtenerProductoResponse> obtenerProductoAsync() {
            SushiApp.wsProducto.obtenerProductoRequest inValue = new SushiApp.wsProducto.obtenerProductoRequest();
            return ((SushiApp.wsProducto.ServiceProducto)(this)).obtenerProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.buscarProductoResponse SushiApp.wsProducto.ServiceProducto.buscarProducto(SushiApp.wsProducto.buscarProductoRequest request) {
            return base.Channel.buscarProducto(request);
        }
        
        public SushiApp.wsProducto.producto buscarProducto(int id) {
            SushiApp.wsProducto.buscarProductoRequest inValue = new SushiApp.wsProducto.buscarProductoRequest();
            inValue.id = id;
            SushiApp.wsProducto.buscarProductoResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).buscarProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoResponse> SushiApp.wsProducto.ServiceProducto.buscarProductoAsync(SushiApp.wsProducto.buscarProductoRequest request) {
            return base.Channel.buscarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoResponse> buscarProductoAsync(int id) {
            SushiApp.wsProducto.buscarProductoRequest inValue = new SushiApp.wsProducto.buscarProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsProducto.ServiceProducto)(this)).buscarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.agregarProductoResponse SushiApp.wsProducto.ServiceProducto.agregarProducto(SushiApp.wsProducto.agregarProductoRequest request) {
            return base.Channel.agregarProducto(request);
        }
        
        public void agregarProducto(SushiApp.wsProducto.producto producto) {
            SushiApp.wsProducto.agregarProductoRequest inValue = new SushiApp.wsProducto.agregarProductoRequest();
            inValue.producto = producto;
            SushiApp.wsProducto.agregarProductoResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).agregarProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.agregarProductoResponse> SushiApp.wsProducto.ServiceProducto.agregarProductoAsync(SushiApp.wsProducto.agregarProductoRequest request) {
            return base.Channel.agregarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.agregarProductoResponse> agregarProductoAsync(SushiApp.wsProducto.producto producto) {
            SushiApp.wsProducto.agregarProductoRequest inValue = new SushiApp.wsProducto.agregarProductoRequest();
            inValue.producto = producto;
            return ((SushiApp.wsProducto.ServiceProducto)(this)).agregarProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.buscarProductoNombreResponse SushiApp.wsProducto.ServiceProducto.buscarProductoNombre(SushiApp.wsProducto.buscarProductoNombreRequest request) {
            return base.Channel.buscarProductoNombre(request);
        }
        
        public SushiApp.wsProducto.producto buscarProductoNombre(string nombre) {
            SushiApp.wsProducto.buscarProductoNombreRequest inValue = new SushiApp.wsProducto.buscarProductoNombreRequest();
            inValue.nombre = nombre;
            SushiApp.wsProducto.buscarProductoNombreResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).buscarProductoNombre(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoNombreResponse> SushiApp.wsProducto.ServiceProducto.buscarProductoNombreAsync(SushiApp.wsProducto.buscarProductoNombreRequest request) {
            return base.Channel.buscarProductoNombreAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.buscarProductoNombreResponse> buscarProductoNombreAsync(string nombre) {
            SushiApp.wsProducto.buscarProductoNombreRequest inValue = new SushiApp.wsProducto.buscarProductoNombreRequest();
            inValue.nombre = nombre;
            return ((SushiApp.wsProducto.ServiceProducto)(this)).buscarProductoNombreAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsProducto.modificarProductoResponse SushiApp.wsProducto.ServiceProducto.modificarProducto(SushiApp.wsProducto.modificarProductoRequest request) {
            return base.Channel.modificarProducto(request);
        }
        
        public void modificarProducto(SushiApp.wsProducto.producto producto) {
            SushiApp.wsProducto.modificarProductoRequest inValue = new SushiApp.wsProducto.modificarProductoRequest();
            inValue.producto = producto;
            SushiApp.wsProducto.modificarProductoResponse retVal = ((SushiApp.wsProducto.ServiceProducto)(this)).modificarProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsProducto.modificarProductoResponse> SushiApp.wsProducto.ServiceProducto.modificarProductoAsync(SushiApp.wsProducto.modificarProductoRequest request) {
            return base.Channel.modificarProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsProducto.modificarProductoResponse> modificarProductoAsync(SushiApp.wsProducto.producto producto) {
            SushiApp.wsProducto.modificarProductoRequest inValue = new SushiApp.wsProducto.modificarProductoRequest();
            inValue.producto = producto;
            return ((SushiApp.wsProducto.ServiceProducto)(this)).modificarProductoAsync(inValue);
        }
    }
}
