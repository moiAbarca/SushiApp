﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsTipoPago {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsTipoPago.ServiceTipoPago")]
    public interface ServiceTipoPago {
        
        // CODEGEN: El parámetro 'tipoPago' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/agregarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/agregarTipoPagoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsTipoPago.agregarTipoPagoResponse agregarTipoPago(SushiApp.wsTipoPago.agregarTipoPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/agregarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/agregarTipoPagoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.agregarTipoPagoResponse> agregarTipoPagoAsync(SushiApp.wsTipoPago.agregarTipoPagoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/obtenerTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/obtenerTipoPagoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsTipoPago.obtenerTipoPagoResponse obtenerTipoPago(SushiApp.wsTipoPago.obtenerTipoPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/obtenerTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/obtenerTipoPagoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.obtenerTipoPagoResponse> obtenerTipoPagoAsync(SushiApp.wsTipoPago.obtenerTipoPagoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/buscarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/buscarTipoPagoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsTipoPago.buscarTipoPagoResponse buscarTipoPago(SushiApp.wsTipoPago.buscarTipoPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/buscarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/buscarTipoPagoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.buscarTipoPagoResponse> buscarTipoPagoAsync(SushiApp.wsTipoPago.buscarTipoPagoRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/eliminarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/eliminarTipoPagoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsTipoPago.eliminarTipoPagoResponse eliminarTipoPago(SushiApp.wsTipoPago.eliminarTipoPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/eliminarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/eliminarTipoPagoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.eliminarTipoPagoResponse> eliminarTipoPagoAsync(SushiApp.wsTipoPago.eliminarTipoPagoRequest request);
        
        // CODEGEN: El parámetro 'tipoPago' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/modificarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/modificarTipoPagoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsTipoPago.modificarTipoPagoResponse modificarTipoPago(SushiApp.wsTipoPago.modificarTipoPagoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceTipoPago/modificarTipoPagoRequest", ReplyAction="http://WebService/ServiceTipoPago/modificarTipoPagoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.modificarTipoPagoResponse> modificarTipoPagoAsync(SushiApp.wsTipoPago.modificarTipoPagoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class tipoPago : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nombreTipoPagoField;
        
        private int tipoPagoIdField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string nombreTipoPago {
            get {
                return this.nombreTipoPagoField;
            }
            set {
                this.nombreTipoPagoField = value;
                this.RaisePropertyChanged("nombreTipoPago");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int tipoPagoId {
            get {
                return this.tipoPagoIdField;
            }
            set {
                this.tipoPagoIdField = value;
                this.RaisePropertyChanged("tipoPagoId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarTipoPago", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarTipoPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsTipoPago.tipoPago tipoPago;
        
        public agregarTipoPagoRequest() {
        }
        
        public agregarTipoPagoRequest(SushiApp.wsTipoPago.tipoPago tipoPago) {
            this.tipoPago = tipoPago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarTipoPagoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarTipoPagoResponse {
        
        public agregarTipoPagoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTipoPago", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerTipoPagoRequest {
        
        public obtenerTipoPagoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerTipoPagoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerTipoPagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsTipoPago.tipoPago[] @return;
        
        public obtenerTipoPagoResponse() {
        }
        
        public obtenerTipoPagoResponse(SushiApp.wsTipoPago.tipoPago[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarTipoPago", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarTipoPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarTipoPagoRequest() {
        }
        
        public buscarTipoPagoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarTipoPagoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarTipoPagoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsTipoPago.tipoPago @return;
        
        public buscarTipoPagoResponse() {
        }
        
        public buscarTipoPagoResponse(SushiApp.wsTipoPago.tipoPago @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarTipoPago", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarTipoPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarTipoPagoRequest() {
        }
        
        public eliminarTipoPagoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarTipoPagoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarTipoPagoResponse {
        
        public eliminarTipoPagoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarTipoPago", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarTipoPagoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsTipoPago.tipoPago tipoPago;
        
        public modificarTipoPagoRequest() {
        }
        
        public modificarTipoPagoRequest(SushiApp.wsTipoPago.tipoPago tipoPago) {
            this.tipoPago = tipoPago;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarTipoPagoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarTipoPagoResponse {
        
        public modificarTipoPagoResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceTipoPagoChannel : SushiApp.wsTipoPago.ServiceTipoPago, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceTipoPagoClient : System.ServiceModel.ClientBase<SushiApp.wsTipoPago.ServiceTipoPago>, SushiApp.wsTipoPago.ServiceTipoPago {
        
        public ServiceTipoPagoClient() {
        }
        
        public ServiceTipoPagoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceTipoPagoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTipoPagoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceTipoPagoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsTipoPago.agregarTipoPagoResponse SushiApp.wsTipoPago.ServiceTipoPago.agregarTipoPago(SushiApp.wsTipoPago.agregarTipoPagoRequest request) {
            return base.Channel.agregarTipoPago(request);
        }
        
        public void agregarTipoPago(SushiApp.wsTipoPago.tipoPago tipoPago) {
            SushiApp.wsTipoPago.agregarTipoPagoRequest inValue = new SushiApp.wsTipoPago.agregarTipoPagoRequest();
            inValue.tipoPago = tipoPago;
            SushiApp.wsTipoPago.agregarTipoPagoResponse retVal = ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).agregarTipoPago(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.agregarTipoPagoResponse> SushiApp.wsTipoPago.ServiceTipoPago.agregarTipoPagoAsync(SushiApp.wsTipoPago.agregarTipoPagoRequest request) {
            return base.Channel.agregarTipoPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsTipoPago.agregarTipoPagoResponse> agregarTipoPagoAsync(SushiApp.wsTipoPago.tipoPago tipoPago) {
            SushiApp.wsTipoPago.agregarTipoPagoRequest inValue = new SushiApp.wsTipoPago.agregarTipoPagoRequest();
            inValue.tipoPago = tipoPago;
            return ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).agregarTipoPagoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsTipoPago.obtenerTipoPagoResponse SushiApp.wsTipoPago.ServiceTipoPago.obtenerTipoPago(SushiApp.wsTipoPago.obtenerTipoPagoRequest request) {
            return base.Channel.obtenerTipoPago(request);
        }
        
        public SushiApp.wsTipoPago.tipoPago[] obtenerTipoPago() {
            SushiApp.wsTipoPago.obtenerTipoPagoRequest inValue = new SushiApp.wsTipoPago.obtenerTipoPagoRequest();
            SushiApp.wsTipoPago.obtenerTipoPagoResponse retVal = ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).obtenerTipoPago(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.obtenerTipoPagoResponse> SushiApp.wsTipoPago.ServiceTipoPago.obtenerTipoPagoAsync(SushiApp.wsTipoPago.obtenerTipoPagoRequest request) {
            return base.Channel.obtenerTipoPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsTipoPago.obtenerTipoPagoResponse> obtenerTipoPagoAsync() {
            SushiApp.wsTipoPago.obtenerTipoPagoRequest inValue = new SushiApp.wsTipoPago.obtenerTipoPagoRequest();
            return ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).obtenerTipoPagoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsTipoPago.buscarTipoPagoResponse SushiApp.wsTipoPago.ServiceTipoPago.buscarTipoPago(SushiApp.wsTipoPago.buscarTipoPagoRequest request) {
            return base.Channel.buscarTipoPago(request);
        }
        
        public SushiApp.wsTipoPago.tipoPago buscarTipoPago(int id) {
            SushiApp.wsTipoPago.buscarTipoPagoRequest inValue = new SushiApp.wsTipoPago.buscarTipoPagoRequest();
            inValue.id = id;
            SushiApp.wsTipoPago.buscarTipoPagoResponse retVal = ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).buscarTipoPago(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.buscarTipoPagoResponse> SushiApp.wsTipoPago.ServiceTipoPago.buscarTipoPagoAsync(SushiApp.wsTipoPago.buscarTipoPagoRequest request) {
            return base.Channel.buscarTipoPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsTipoPago.buscarTipoPagoResponse> buscarTipoPagoAsync(int id) {
            SushiApp.wsTipoPago.buscarTipoPagoRequest inValue = new SushiApp.wsTipoPago.buscarTipoPagoRequest();
            inValue.id = id;
            return ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).buscarTipoPagoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsTipoPago.eliminarTipoPagoResponse SushiApp.wsTipoPago.ServiceTipoPago.eliminarTipoPago(SushiApp.wsTipoPago.eliminarTipoPagoRequest request) {
            return base.Channel.eliminarTipoPago(request);
        }
        
        public void eliminarTipoPago(int id) {
            SushiApp.wsTipoPago.eliminarTipoPagoRequest inValue = new SushiApp.wsTipoPago.eliminarTipoPagoRequest();
            inValue.id = id;
            SushiApp.wsTipoPago.eliminarTipoPagoResponse retVal = ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).eliminarTipoPago(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.eliminarTipoPagoResponse> SushiApp.wsTipoPago.ServiceTipoPago.eliminarTipoPagoAsync(SushiApp.wsTipoPago.eliminarTipoPagoRequest request) {
            return base.Channel.eliminarTipoPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsTipoPago.eliminarTipoPagoResponse> eliminarTipoPagoAsync(int id) {
            SushiApp.wsTipoPago.eliminarTipoPagoRequest inValue = new SushiApp.wsTipoPago.eliminarTipoPagoRequest();
            inValue.id = id;
            return ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).eliminarTipoPagoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsTipoPago.modificarTipoPagoResponse SushiApp.wsTipoPago.ServiceTipoPago.modificarTipoPago(SushiApp.wsTipoPago.modificarTipoPagoRequest request) {
            return base.Channel.modificarTipoPago(request);
        }
        
        public void modificarTipoPago(SushiApp.wsTipoPago.tipoPago tipoPago) {
            SushiApp.wsTipoPago.modificarTipoPagoRequest inValue = new SushiApp.wsTipoPago.modificarTipoPagoRequest();
            inValue.tipoPago = tipoPago;
            SushiApp.wsTipoPago.modificarTipoPagoResponse retVal = ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).modificarTipoPago(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsTipoPago.modificarTipoPagoResponse> SushiApp.wsTipoPago.ServiceTipoPago.modificarTipoPagoAsync(SushiApp.wsTipoPago.modificarTipoPagoRequest request) {
            return base.Channel.modificarTipoPagoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsTipoPago.modificarTipoPagoResponse> modificarTipoPagoAsync(SushiApp.wsTipoPago.tipoPago tipoPago) {
            SushiApp.wsTipoPago.modificarTipoPagoRequest inValue = new SushiApp.wsTipoPago.modificarTipoPagoRequest();
            inValue.tipoPago = tipoPago;
            return ((SushiApp.wsTipoPago.ServiceTipoPago)(this)).modificarTipoPagoAsync(inValue);
        }
    }
}
