﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsCategoria {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsCategoria.ServiceCategoriaProducto")]
    public interface ServiceCategoriaProducto {
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/obtenerCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/obtenerCategoriaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsCategoria.obtenerCategoriaProductoResponse obtenerCategoriaProducto(SushiApp.wsCategoria.obtenerCategoriaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/obtenerCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/obtenerCategoriaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.obtenerCategoriaProductoResponse> obtenerCategoriaProductoAsync(SushiApp.wsCategoria.obtenerCategoriaProductoRequest request);
        
        // CODEGEN: El parámetro 'categoriaProducto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/agregarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/agregarCategoriaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCategoria.agregarCategoriaProductoResponse agregarCategoriaProducto(SushiApp.wsCategoria.agregarCategoriaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/agregarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/agregarCategoriaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.agregarCategoriaProductoResponse> agregarCategoriaProductoAsync(SushiApp.wsCategoria.agregarCategoriaProductoRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/eliminarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/eliminarCategoriaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCategoria.eliminarCategoriaProductoResponse eliminarCategoriaProducto(SushiApp.wsCategoria.eliminarCategoriaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/eliminarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/eliminarCategoriaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.eliminarCategoriaProductoResponse> eliminarCategoriaProductoAsync(SushiApp.wsCategoria.eliminarCategoriaProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/buscarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/buscarCategoriaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsCategoria.buscarCategoriaProductoResponse buscarCategoriaProducto(SushiApp.wsCategoria.buscarCategoriaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/buscarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/buscarCategoriaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.buscarCategoriaProductoResponse> buscarCategoriaProductoAsync(SushiApp.wsCategoria.buscarCategoriaProductoRequest request);
        
        // CODEGEN: El parámetro 'categoriaProducto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/modificarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/modificarCategoriaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsCategoria.modificarCategoriaProductoResponse modificarCategoriaProducto(SushiApp.wsCategoria.modificarCategoriaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceCategoriaProducto/modificarCategoriaProductoRequest", ReplyAction="http://WebService/ServiceCategoriaProducto/modificarCategoriaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.modificarCategoriaProductoResponse> modificarCategoriaProductoAsync(SushiApp.wsCategoria.modificarCategoriaProductoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class categoriaProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int categoriaProductoIdField;
        
        private string nombreCategoriaField;
        
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
        public string nombreCategoria {
            get {
                return this.nombreCategoriaField;
            }
            set {
                this.nombreCategoriaField = value;
                this.RaisePropertyChanged("nombreCategoria");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerCategoriaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerCategoriaProductoRequest {
        
        public obtenerCategoriaProductoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerCategoriaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerCategoriaProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCategoria.categoriaProducto[] @return;
        
        public obtenerCategoriaProductoResponse() {
        }
        
        public obtenerCategoriaProductoResponse(SushiApp.wsCategoria.categoriaProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarCategoriaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarCategoriaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCategoria.categoriaProducto categoriaProducto;
        
        public agregarCategoriaProductoRequest() {
        }
        
        public agregarCategoriaProductoRequest(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            this.categoriaProducto = categoriaProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarCategoriaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarCategoriaProductoResponse {
        
        public agregarCategoriaProductoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCategoriaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarCategoriaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarCategoriaProductoRequest() {
        }
        
        public eliminarCategoriaProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarCategoriaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarCategoriaProductoResponse {
        
        public eliminarCategoriaProductoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarCategoriaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarCategoriaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarCategoriaProductoRequest() {
        }
        
        public buscarCategoriaProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarCategoriaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarCategoriaProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCategoria.categoriaProducto @return;
        
        public buscarCategoriaProductoResponse() {
        }
        
        public buscarCategoriaProductoResponse(SushiApp.wsCategoria.categoriaProducto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCategoriaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarCategoriaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsCategoria.categoriaProducto categoriaProducto;
        
        public modificarCategoriaProductoRequest() {
        }
        
        public modificarCategoriaProductoRequest(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            this.categoriaProducto = categoriaProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarCategoriaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarCategoriaProductoResponse {
        
        public modificarCategoriaProductoResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceCategoriaProductoChannel : SushiApp.wsCategoria.ServiceCategoriaProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCategoriaProductoClient : System.ServiceModel.ClientBase<SushiApp.wsCategoria.ServiceCategoriaProducto>, SushiApp.wsCategoria.ServiceCategoriaProducto {
        
        public ServiceCategoriaProductoClient() {
        }
        
        public ServiceCategoriaProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCategoriaProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCategoriaProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCategoriaProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCategoria.obtenerCategoriaProductoResponse SushiApp.wsCategoria.ServiceCategoriaProducto.obtenerCategoriaProducto(SushiApp.wsCategoria.obtenerCategoriaProductoRequest request) {
            return base.Channel.obtenerCategoriaProducto(request);
        }
        
        public SushiApp.wsCategoria.categoriaProducto[] obtenerCategoriaProducto() {
            SushiApp.wsCategoria.obtenerCategoriaProductoRequest inValue = new SushiApp.wsCategoria.obtenerCategoriaProductoRequest();
            SushiApp.wsCategoria.obtenerCategoriaProductoResponse retVal = ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).obtenerCategoriaProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.obtenerCategoriaProductoResponse> SushiApp.wsCategoria.ServiceCategoriaProducto.obtenerCategoriaProductoAsync(SushiApp.wsCategoria.obtenerCategoriaProductoRequest request) {
            return base.Channel.obtenerCategoriaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCategoria.obtenerCategoriaProductoResponse> obtenerCategoriaProductoAsync() {
            SushiApp.wsCategoria.obtenerCategoriaProductoRequest inValue = new SushiApp.wsCategoria.obtenerCategoriaProductoRequest();
            return ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).obtenerCategoriaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCategoria.agregarCategoriaProductoResponse SushiApp.wsCategoria.ServiceCategoriaProducto.agregarCategoriaProducto(SushiApp.wsCategoria.agregarCategoriaProductoRequest request) {
            return base.Channel.agregarCategoriaProducto(request);
        }
        
        public void agregarCategoriaProducto(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            SushiApp.wsCategoria.agregarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.agregarCategoriaProductoRequest();
            inValue.categoriaProducto = categoriaProducto;
            SushiApp.wsCategoria.agregarCategoriaProductoResponse retVal = ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).agregarCategoriaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.agregarCategoriaProductoResponse> SushiApp.wsCategoria.ServiceCategoriaProducto.agregarCategoriaProductoAsync(SushiApp.wsCategoria.agregarCategoriaProductoRequest request) {
            return base.Channel.agregarCategoriaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCategoria.agregarCategoriaProductoResponse> agregarCategoriaProductoAsync(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            SushiApp.wsCategoria.agregarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.agregarCategoriaProductoRequest();
            inValue.categoriaProducto = categoriaProducto;
            return ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).agregarCategoriaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCategoria.eliminarCategoriaProductoResponse SushiApp.wsCategoria.ServiceCategoriaProducto.eliminarCategoriaProducto(SushiApp.wsCategoria.eliminarCategoriaProductoRequest request) {
            return base.Channel.eliminarCategoriaProducto(request);
        }
        
        public void eliminarCategoriaProducto(int id) {
            SushiApp.wsCategoria.eliminarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.eliminarCategoriaProductoRequest();
            inValue.id = id;
            SushiApp.wsCategoria.eliminarCategoriaProductoResponse retVal = ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).eliminarCategoriaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.eliminarCategoriaProductoResponse> SushiApp.wsCategoria.ServiceCategoriaProducto.eliminarCategoriaProductoAsync(SushiApp.wsCategoria.eliminarCategoriaProductoRequest request) {
            return base.Channel.eliminarCategoriaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCategoria.eliminarCategoriaProductoResponse> eliminarCategoriaProductoAsync(int id) {
            SushiApp.wsCategoria.eliminarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.eliminarCategoriaProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).eliminarCategoriaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCategoria.buscarCategoriaProductoResponse SushiApp.wsCategoria.ServiceCategoriaProducto.buscarCategoriaProducto(SushiApp.wsCategoria.buscarCategoriaProductoRequest request) {
            return base.Channel.buscarCategoriaProducto(request);
        }
        
        public SushiApp.wsCategoria.categoriaProducto buscarCategoriaProducto(int id) {
            SushiApp.wsCategoria.buscarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.buscarCategoriaProductoRequest();
            inValue.id = id;
            SushiApp.wsCategoria.buscarCategoriaProductoResponse retVal = ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).buscarCategoriaProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.buscarCategoriaProductoResponse> SushiApp.wsCategoria.ServiceCategoriaProducto.buscarCategoriaProductoAsync(SushiApp.wsCategoria.buscarCategoriaProductoRequest request) {
            return base.Channel.buscarCategoriaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCategoria.buscarCategoriaProductoResponse> buscarCategoriaProductoAsync(int id) {
            SushiApp.wsCategoria.buscarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.buscarCategoriaProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).buscarCategoriaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsCategoria.modificarCategoriaProductoResponse SushiApp.wsCategoria.ServiceCategoriaProducto.modificarCategoriaProducto(SushiApp.wsCategoria.modificarCategoriaProductoRequest request) {
            return base.Channel.modificarCategoriaProducto(request);
        }
        
        public void modificarCategoriaProducto(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            SushiApp.wsCategoria.modificarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.modificarCategoriaProductoRequest();
            inValue.categoriaProducto = categoriaProducto;
            SushiApp.wsCategoria.modificarCategoriaProductoResponse retVal = ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).modificarCategoriaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsCategoria.modificarCategoriaProductoResponse> SushiApp.wsCategoria.ServiceCategoriaProducto.modificarCategoriaProductoAsync(SushiApp.wsCategoria.modificarCategoriaProductoRequest request) {
            return base.Channel.modificarCategoriaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsCategoria.modificarCategoriaProductoResponse> modificarCategoriaProductoAsync(SushiApp.wsCategoria.categoriaProducto categoriaProducto) {
            SushiApp.wsCategoria.modificarCategoriaProductoRequest inValue = new SushiApp.wsCategoria.modificarCategoriaProductoRequest();
            inValue.categoriaProducto = categoriaProducto;
            return ((SushiApp.wsCategoria.ServiceCategoriaProducto)(this)).modificarCategoriaProductoAsync(inValue);
        }
    }
}
