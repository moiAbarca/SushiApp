﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SushiApp.wsSeguimiento {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://WebService/", ConfigurationName="wsSeguimiento.ServiceSeguimiento")]
    public interface ServiceSeguimiento {
        
        // CODEGEN: El parámetro 'seguimiento' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/agregarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/agregarSeguimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsSeguimiento.agregarSeguimientoResponse agregarSeguimiento(SushiApp.wsSeguimiento.agregarSeguimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/agregarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/agregarSeguimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.agregarSeguimientoResponse> agregarSeguimientoAsync(SushiApp.wsSeguimiento.agregarSeguimientoRequest request);
        
        // CODEGEN: El parámetro 'seguimiento' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/modificarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/modificarSeguimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsSeguimiento.modificarSeguimientoResponse modificarSeguimiento(SushiApp.wsSeguimiento.modificarSeguimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/modificarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/modificarSeguimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.modificarSeguimientoResponse> modificarSeguimientoAsync(SushiApp.wsSeguimiento.modificarSeguimientoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/obtenerSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/obtenerSeguimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsSeguimiento.obtenerSeguimientoResponse obtenerSeguimiento(SushiApp.wsSeguimiento.obtenerSeguimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/obtenerSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/obtenerSeguimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.obtenerSeguimientoResponse> obtenerSeguimientoAsync(SushiApp.wsSeguimiento.obtenerSeguimientoRequest request);
        
        // CODEGEN: El parámetro 'id' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/eliminarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/eliminarSeguimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SushiApp.wsSeguimiento.eliminarSeguimientoResponse eliminarSeguimiento(SushiApp.wsSeguimiento.eliminarSeguimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/eliminarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/eliminarSeguimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.eliminarSeguimientoResponse> eliminarSeguimientoAsync(SushiApp.wsSeguimiento.eliminarSeguimientoRequest request);
        
        // CODEGEN: El parámetro 'return' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/buscarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/buscarSeguimientoResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        SushiApp.wsSeguimiento.buscarSeguimientoResponse buscarSeguimiento(SushiApp.wsSeguimiento.buscarSeguimientoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://WebService/ServiceSeguimiento/buscarSeguimientoRequest", ReplyAction="http://WebService/ServiceSeguimiento/buscarSeguimientoResponse")]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.buscarSeguimientoResponse> buscarSeguimientoAsync(SushiApp.wsSeguimiento.buscarSeguimientoRequest request);
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2053.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://WebService/")]
    public partial class seguimiento : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int clienteIdField;
        
        private string componenteField;
        
        private string eventoField;
        
        private int seguimientoIdField;
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int clienteId {
            get {
                return this.clienteIdField;
            }
            set {
                this.clienteIdField = value;
                this.RaisePropertyChanged("clienteId");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string componente {
            get {
                return this.componenteField;
            }
            set {
                this.componenteField = value;
                this.RaisePropertyChanged("componente");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string evento {
            get {
                return this.eventoField;
            }
            set {
                this.eventoField = value;
                this.RaisePropertyChanged("evento");
            }
        }
        
        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public int seguimientoId {
            get {
                return this.seguimientoIdField;
            }
            set {
                this.seguimientoIdField = value;
                this.RaisePropertyChanged("seguimientoId");
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarSeguimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarSeguimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsSeguimiento.seguimiento seguimiento;
        
        public agregarSeguimientoRequest() {
        }
        
        public agregarSeguimientoRequest(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            this.seguimiento = seguimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="agregarSeguimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class agregarSeguimientoResponse {
        
        public agregarSeguimientoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarSeguimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarSeguimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsSeguimiento.seguimiento seguimiento;
        
        public modificarSeguimientoRequest() {
        }
        
        public modificarSeguimientoRequest(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            this.seguimiento = seguimiento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="modificarSeguimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class modificarSeguimientoResponse {
        
        public modificarSeguimientoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerSeguimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerSeguimientoRequest {
        
        public obtenerSeguimientoRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="obtenerSeguimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class obtenerSeguimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsSeguimiento.seguimiento[] @return;
        
        public obtenerSeguimientoResponse() {
        }
        
        public obtenerSeguimientoResponse(SushiApp.wsSeguimiento.seguimiento[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSeguimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarSeguimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public eliminarSeguimientoRequest() {
        }
        
        public eliminarSeguimientoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="eliminarSeguimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class eliminarSeguimientoResponse {
        
        public eliminarSeguimientoResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarSeguimiento", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarSeguimientoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int id;
        
        public buscarSeguimientoRequest() {
        }
        
        public buscarSeguimientoRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="buscarSeguimientoResponse", WrapperNamespace="http://WebService/", IsWrapped=true)]
    public partial class buscarSeguimientoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://WebService/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SushiApp.wsSeguimiento.seguimiento @return;
        
        public buscarSeguimientoResponse() {
        }
        
        public buscarSeguimientoResponse(SushiApp.wsSeguimiento.seguimiento @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSeguimientoChannel : SushiApp.wsSeguimiento.ServiceSeguimiento, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSeguimientoClient : System.ServiceModel.ClientBase<SushiApp.wsSeguimiento.ServiceSeguimiento>, SushiApp.wsSeguimiento.ServiceSeguimiento {
        
        public ServiceSeguimientoClient() {
        }
        
        public ServiceSeguimientoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSeguimientoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSeguimientoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSeguimientoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsSeguimiento.agregarSeguimientoResponse SushiApp.wsSeguimiento.ServiceSeguimiento.agregarSeguimiento(SushiApp.wsSeguimiento.agregarSeguimientoRequest request) {
            return base.Channel.agregarSeguimiento(request);
        }
        
        public void agregarSeguimiento(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            SushiApp.wsSeguimiento.agregarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.agregarSeguimientoRequest();
            inValue.seguimiento = seguimiento;
            SushiApp.wsSeguimiento.agregarSeguimientoResponse retVal = ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).agregarSeguimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.agregarSeguimientoResponse> SushiApp.wsSeguimiento.ServiceSeguimiento.agregarSeguimientoAsync(SushiApp.wsSeguimiento.agregarSeguimientoRequest request) {
            return base.Channel.agregarSeguimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsSeguimiento.agregarSeguimientoResponse> agregarSeguimientoAsync(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            SushiApp.wsSeguimiento.agregarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.agregarSeguimientoRequest();
            inValue.seguimiento = seguimiento;
            return ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).agregarSeguimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsSeguimiento.modificarSeguimientoResponse SushiApp.wsSeguimiento.ServiceSeguimiento.modificarSeguimiento(SushiApp.wsSeguimiento.modificarSeguimientoRequest request) {
            return base.Channel.modificarSeguimiento(request);
        }
        
        public void modificarSeguimiento(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            SushiApp.wsSeguimiento.modificarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.modificarSeguimientoRequest();
            inValue.seguimiento = seguimiento;
            SushiApp.wsSeguimiento.modificarSeguimientoResponse retVal = ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).modificarSeguimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.modificarSeguimientoResponse> SushiApp.wsSeguimiento.ServiceSeguimiento.modificarSeguimientoAsync(SushiApp.wsSeguimiento.modificarSeguimientoRequest request) {
            return base.Channel.modificarSeguimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsSeguimiento.modificarSeguimientoResponse> modificarSeguimientoAsync(SushiApp.wsSeguimiento.seguimiento seguimiento) {
            SushiApp.wsSeguimiento.modificarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.modificarSeguimientoRequest();
            inValue.seguimiento = seguimiento;
            return ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).modificarSeguimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsSeguimiento.obtenerSeguimientoResponse SushiApp.wsSeguimiento.ServiceSeguimiento.obtenerSeguimiento(SushiApp.wsSeguimiento.obtenerSeguimientoRequest request) {
            return base.Channel.obtenerSeguimiento(request);
        }
        
        public SushiApp.wsSeguimiento.seguimiento[] obtenerSeguimiento() {
            SushiApp.wsSeguimiento.obtenerSeguimientoRequest inValue = new SushiApp.wsSeguimiento.obtenerSeguimientoRequest();
            SushiApp.wsSeguimiento.obtenerSeguimientoResponse retVal = ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).obtenerSeguimiento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.obtenerSeguimientoResponse> SushiApp.wsSeguimiento.ServiceSeguimiento.obtenerSeguimientoAsync(SushiApp.wsSeguimiento.obtenerSeguimientoRequest request) {
            return base.Channel.obtenerSeguimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsSeguimiento.obtenerSeguimientoResponse> obtenerSeguimientoAsync() {
            SushiApp.wsSeguimiento.obtenerSeguimientoRequest inValue = new SushiApp.wsSeguimiento.obtenerSeguimientoRequest();
            return ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).obtenerSeguimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsSeguimiento.eliminarSeguimientoResponse SushiApp.wsSeguimiento.ServiceSeguimiento.eliminarSeguimiento(SushiApp.wsSeguimiento.eliminarSeguimientoRequest request) {
            return base.Channel.eliminarSeguimiento(request);
        }
        
        public void eliminarSeguimiento(int id) {
            SushiApp.wsSeguimiento.eliminarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.eliminarSeguimientoRequest();
            inValue.id = id;
            SushiApp.wsSeguimiento.eliminarSeguimientoResponse retVal = ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).eliminarSeguimiento(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.eliminarSeguimientoResponse> SushiApp.wsSeguimiento.ServiceSeguimiento.eliminarSeguimientoAsync(SushiApp.wsSeguimiento.eliminarSeguimientoRequest request) {
            return base.Channel.eliminarSeguimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsSeguimiento.eliminarSeguimientoResponse> eliminarSeguimientoAsync(int id) {
            SushiApp.wsSeguimiento.eliminarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.eliminarSeguimientoRequest();
            inValue.id = id;
            return ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).eliminarSeguimientoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SushiApp.wsSeguimiento.buscarSeguimientoResponse SushiApp.wsSeguimiento.ServiceSeguimiento.buscarSeguimiento(SushiApp.wsSeguimiento.buscarSeguimientoRequest request) {
            return base.Channel.buscarSeguimiento(request);
        }
        
        public SushiApp.wsSeguimiento.seguimiento buscarSeguimiento(int id) {
            SushiApp.wsSeguimiento.buscarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.buscarSeguimientoRequest();
            inValue.id = id;
            SushiApp.wsSeguimiento.buscarSeguimientoResponse retVal = ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).buscarSeguimiento(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SushiApp.wsSeguimiento.buscarSeguimientoResponse> SushiApp.wsSeguimiento.ServiceSeguimiento.buscarSeguimientoAsync(SushiApp.wsSeguimiento.buscarSeguimientoRequest request) {
            return base.Channel.buscarSeguimientoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SushiApp.wsSeguimiento.buscarSeguimientoResponse> buscarSeguimientoAsync(int id) {
            SushiApp.wsSeguimiento.buscarSeguimientoRequest inValue = new SushiApp.wsSeguimiento.buscarSeguimientoRequest();
            inValue.id = id;
            return ((SushiApp.wsSeguimiento.ServiceSeguimiento)(this)).buscarSeguimientoAsync(inValue);
        }
    }
}
