﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Reinf.RecebeLote {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sped.fazenda.gov.br/", ConfigurationName="RecebeLote.RecepcaoLoteReinf")]
    public interface RecepcaoLoteReinf {
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento loteEventos no namespace http://sped.fazenda.gov.br/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventos", ReplyAction="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventosResponse")]
        Reinf.RecebeLote.ReceberLoteEventosResponse ReceberLoteEventos(Reinf.RecebeLote.ReceberLoteEventosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventos", ReplyAction="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventosResponse")]
        System.Threading.Tasks.Task<Reinf.RecebeLote.ReceberLoteEventosResponse> ReceberLoteEventosAsync(Reinf.RecebeLote.ReceberLoteEventosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceberLoteEventosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceberLoteEventos", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Reinf.RecebeLote.ReceberLoteEventosRequestBody Body;
        
        public ReceberLoteEventosRequest() {
        }
        
        public ReceberLoteEventosRequest(Reinf.RecebeLote.ReceberLoteEventosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ReceberLoteEventosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement loteEventos;
        
        public ReceberLoteEventosRequestBody() {
        }
        
        public ReceberLoteEventosRequestBody(System.Xml.Linq.XElement loteEventos) {
            this.loteEventos = loteEventos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceberLoteEventosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceberLoteEventosResponse", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Reinf.RecebeLote.ReceberLoteEventosResponseBody Body;
        
        public ReceberLoteEventosResponse() {
        }
        
        public ReceberLoteEventosResponse(Reinf.RecebeLote.ReceberLoteEventosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ReceberLoteEventosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement ReceberLoteEventosResult;
        
        public ReceberLoteEventosResponseBody() {
        }
        
        public ReceberLoteEventosResponseBody(System.Xml.Linq.XElement ReceberLoteEventosResult) {
            this.ReceberLoteEventosResult = ReceberLoteEventosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RecepcaoLoteReinfChannel : Reinf.RecebeLote.RecepcaoLoteReinf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecepcaoLoteReinfClient : System.ServiceModel.ClientBase<Reinf.RecebeLote.RecepcaoLoteReinf>, Reinf.RecebeLote.RecepcaoLoteReinf {
        
        public RecepcaoLoteReinfClient() {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoLoteReinfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Reinf.RecebeLote.ReceberLoteEventosResponse Reinf.RecebeLote.RecepcaoLoteReinf.ReceberLoteEventos(Reinf.RecebeLote.ReceberLoteEventosRequest request) {
            return base.Channel.ReceberLoteEventos(request);
        }
        
        public System.Xml.Linq.XElement ReceberLoteEventos(System.Xml.Linq.XElement loteEventos) {
            Reinf.RecebeLote.ReceberLoteEventosRequest inValue = new Reinf.RecebeLote.ReceberLoteEventosRequest();
            inValue.Body = new Reinf.RecebeLote.ReceberLoteEventosRequestBody();
            inValue.Body.loteEventos = loteEventos;
            Reinf.RecebeLote.ReceberLoteEventosResponse retVal = ((Reinf.RecebeLote.RecepcaoLoteReinf)(this)).ReceberLoteEventos(inValue);
            return retVal.Body.ReceberLoteEventosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Reinf.RecebeLote.ReceberLoteEventosResponse> Reinf.RecebeLote.RecepcaoLoteReinf.ReceberLoteEventosAsync(Reinf.RecebeLote.ReceberLoteEventosRequest request) {
            return base.Channel.ReceberLoteEventosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Reinf.RecebeLote.ReceberLoteEventosResponse> ReceberLoteEventosAsync(System.Xml.Linq.XElement loteEventos) {
            Reinf.RecebeLote.ReceberLoteEventosRequest inValue = new Reinf.RecebeLote.ReceberLoteEventosRequest();
            inValue.Body = new Reinf.RecebeLote.ReceberLoteEventosRequestBody();
            inValue.Body.loteEventos = loteEventos;
            return ((Reinf.RecebeLote.RecepcaoLoteReinf)(this)).ReceberLoteEventosAsync(inValue);
        }
    }
}
