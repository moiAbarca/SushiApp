﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsOfertaProducto {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsOfertaProducto.ServiceOfertaProducto")]
    public interface ServiceOfertaProducto {
        
        // CODEGEN: El parámetro 'ofertaProducto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/agregarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/agregarOfertaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOfertaProducto.agregarOfertaProductoResponse agregarOfertaProducto(SushiApp.wsOfertaProducto.agregarOfertaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/agregarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/agregarOfertaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.agregarOfertaProductoResponse> agregarOfertaProductoAsync(SushiApp.wsOfertaProducto.agregarOfertaProductoRequest request);
        
        // CODEGEN: El parámetro 'ofertaProducto' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/modificarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/modificarOfertaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOfertaProducto.modificarOfertaProductoResponse modificarOfertaProducto(SushiApp.wsOfertaProducto.modificarOfertaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/modificarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/modificarOfertaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.modificarOfertaProductoResponse> modificarOfertaProductoAsync(SushiApp.wsOfertaProducto.modificarOfertaProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/obtenerOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/obtenerOfertaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse obtenerOfertaProducto(SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/obtenerOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/obtenerOfertaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse> obtenerOfertaProductoAsync(SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/buscarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/buscarOfertaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsOfertaProducto.buscarOfertaProductoResponse buscarOfertaProducto(SushiApp.wsOfertaProducto.buscarOfertaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/buscarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/buscarOfertaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.buscarOfertaProductoResponse> buscarOfertaProductoAsync(SushiApp.wsOfertaProducto.buscarOfertaProductoRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/eliminarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/eliminarOfertaProductoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse eliminarOfertaProducto(SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceOfertaProducto/eliminarOfertaProductoRequest", ReplyAction="http://WebService/ServiceOfertaProducto/eliminarOfertaProductoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse> eliminarOfertaProductoAsync(SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class ofertaProducto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int ofertaIdField;
        
        private int productoIdField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int ofertaId {
            get {
                return this.ofertaIdField;
            }
            set {
                this.ofertaIdField = value;
                this.RaisePropertyChanged("ofertaId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarOfertaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarOfertaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto;
        
        public agregarOfertaProductoRequest() {
        }
        
        public agregarOfertaProductoRequest(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            this.ofertaProducto = ofertaProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarOfertaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarOfertaProductoResponse {
        
        public agregarOfertaProductoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarOfertaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarOfertaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto;
        
        public modificarOfertaProductoRequest() {
        }
        
        public modificarOfertaProductoRequest(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            this.ofertaProducto = ofertaProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarOfertaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarOfertaProductoResponse {
        
        public modificarOfertaProductoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerOfertaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerOfertaProductoRequest {
        
        public obtenerOfertaProductoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerOfertaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerOfertaProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOfertaProducto.ofertaProducto[] @return;
        
        public obtenerOfertaProductoResponse() {
        }
        
        public obtenerOfertaProductoResponse(SushiApp.wsOfertaProducto.ofertaProducto[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarOfertaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarOfertaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarOfertaProductoRequest() {
        }
        
        public buscarOfertaProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarOfertaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarOfertaProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsOfertaProducto.ofertaProducto @return;
        
        public buscarOfertaProductoResponse() {
        }
        
        public buscarOfertaProductoResponse(SushiApp.wsOfertaProducto.ofertaProducto @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarOfertaProducto", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarOfertaProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarOfertaProductoRequest() {
        }
        
        public eliminarOfertaProductoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarOfertaProductoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarOfertaProductoResponse {
        
        public eliminarOfertaProductoResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceOfertaProductoChannel : SushiApp.wsOfertaProducto.ServiceOfertaProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceOfertaProductoClient : System.ServiceModel.ClientBase<SushiApp.wsOfertaProducto.ServiceOfertaProducto>, SushiApp.wsOfertaProducto.ServiceOfertaProducto {
        
        public ServiceOfertaProductoClient() {
        }
        
        public ServiceOfertaProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceOfertaProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOfertaProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceOfertaProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOfertaProducto.agregarOfertaProductoResponse SushiApp.wsOfertaProducto.ServiceOfertaProducto.agregarOfertaProducto(SushiApp.wsOfertaProducto.agregarOfertaProductoRequest request) {
            return base.Channel.agregarOfertaProducto(request);
        }
        
        public void agregarOfertaProducto(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            SushiApp.wsOfertaProducto.agregarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.agregarOfertaProductoRequest();
            inValue.ofertaProducto = ofertaProducto;
            SushiApp.wsOfertaProducto.agregarOfertaProductoResponse retVal = ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).agregarOfertaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.agregarOfertaProductoResponse> SushiApp.wsOfertaProducto.ServiceOfertaProducto.agregarOfertaProductoAsync(SushiApp.wsOfertaProducto.agregarOfertaProductoRequest request) {
            return base.Channel.agregarOfertaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.agregarOfertaProductoResponse> agregarOfertaProductoAsync(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            SushiApp.wsOfertaProducto.agregarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.agregarOfertaProductoRequest();
            inValue.ofertaProducto = ofertaProducto;
            return ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).agregarOfertaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOfertaProducto.modificarOfertaProductoResponse SushiApp.wsOfertaProducto.ServiceOfertaProducto.modificarOfertaProducto(SushiApp.wsOfertaProducto.modificarOfertaProductoRequest request) {
            return base.Channel.modificarOfertaProducto(request);
        }
        
        public void modificarOfertaProducto(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            SushiApp.wsOfertaProducto.modificarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.modificarOfertaProductoRequest();
            inValue.ofertaProducto = ofertaProducto;
            SushiApp.wsOfertaProducto.modificarOfertaProductoResponse retVal = ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).modificarOfertaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.modificarOfertaProductoResponse> SushiApp.wsOfertaProducto.ServiceOfertaProducto.modificarOfertaProductoAsync(SushiApp.wsOfertaProducto.modificarOfertaProductoRequest request) {
            return base.Channel.modificarOfertaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.modificarOfertaProductoResponse> modificarOfertaProductoAsync(SushiApp.wsOfertaProducto.ofertaProducto ofertaProducto) {
            SushiApp.wsOfertaProducto.modificarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.modificarOfertaProductoRequest();
            inValue.ofertaProducto = ofertaProducto;
            return ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).modificarOfertaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse SushiApp.wsOfertaProducto.ServiceOfertaProducto.obtenerOfertaProducto(SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest request) {
            return base.Channel.obtenerOfertaProducto(request);
        }
        
        public SushiApp.wsOfertaProducto.ofertaProducto[] obtenerOfertaProducto() {
            SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest();
            SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse retVal = ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).obtenerOfertaProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse> SushiApp.wsOfertaProducto.ServiceOfertaProducto.obtenerOfertaProductoAsync(SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest request) {
            return base.Channel.obtenerOfertaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.obtenerOfertaProductoResponse> obtenerOfertaProductoAsync() {
            SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.obtenerOfertaProductoRequest();
            return ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).obtenerOfertaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOfertaProducto.buscarOfertaProductoResponse SushiApp.wsOfertaProducto.ServiceOfertaProducto.buscarOfertaProducto(SushiApp.wsOfertaProducto.buscarOfertaProductoRequest request) {
            return base.Channel.buscarOfertaProducto(request);
        }
        
        public SushiApp.wsOfertaProducto.ofertaProducto buscarOfertaProducto(int id) {
            SushiApp.wsOfertaProducto.buscarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.buscarOfertaProductoRequest();
            inValue.id = id;
            SushiApp.wsOfertaProducto.buscarOfertaProductoResponse retVal = ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).buscarOfertaProducto(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.buscarOfertaProductoResponse> SushiApp.wsOfertaProducto.ServiceOfertaProducto.buscarOfertaProductoAsync(SushiApp.wsOfertaProducto.buscarOfertaProductoRequest request) {
            return base.Channel.buscarOfertaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.buscarOfertaProductoResponse> buscarOfertaProductoAsync(int id) {
            SushiApp.wsOfertaProducto.buscarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.buscarOfertaProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).buscarOfertaProductoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse SushiApp.wsOfertaProducto.ServiceOfertaProducto.eliminarOfertaProducto(SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest request) {
            return base.Channel.eliminarOfertaProducto(request);
        }
        
        public void eliminarOfertaProducto(int id) {
            SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest();
            inValue.id = id;
            SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse retVal = ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).eliminarOfertaProducto(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse> SushiApp.wsOfertaProducto.ServiceOfertaProducto.eliminarOfertaProductoAsync(SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest request) {
            return base.Channel.eliminarOfertaProductoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsOfertaProducto.eliminarOfertaProductoResponse> eliminarOfertaProductoAsync(int id) {
            SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest inValue = new SushiApp.wsOfertaProducto.eliminarOfertaProductoRequest();
            inValue.id = id;
            return ((SushiApp.wsOfertaProducto.ServiceOfertaProducto)(this)).eliminarOfertaProductoAsync(inValue);
        }
    }
}
