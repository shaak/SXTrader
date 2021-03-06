﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18052
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LSDataConnector.LSDB {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="http://sxtrader.net/", ItemName="anyType")]
    [System.SerializableAttribute()]
    public class ArrayOfAnyType : System.Collections.Generic.List<object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sxtrader.net/", ConfigurationName="LSDB.LSDB1Soap")]
    public interface LSDB1Soap {
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname GetTeamNamesResult aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/GetTeamNames", ReplyAction="*")]
        LSDataConnector.LSDB.GetTeamNamesResponse GetTeamNames(LSDataConnector.LSDB.GetTeamNamesRequest request);
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname infoEvent1 aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/InsertMatchEvent", ReplyAction="*")]
        LSDataConnector.LSDB.InsertMatchEventResponse InsertMatchEvent(LSDataConnector.LSDB.InsertMatchEventRequest request);
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname matchDate aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/InsertMatch", ReplyAction="*")]
        LSDataConnector.LSDB.InsertMatchResponse InsertMatch(LSDataConnector.LSDB.InsertMatchRequest request);
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname devisionId aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/InsertDevision", ReplyAction="*")]
        LSDataConnector.LSDB.InsertDevisionResponse InsertDevision(LSDataConnector.LSDB.InsertDevisionRequest request);
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname teamName aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/InsertTeamName", ReplyAction="*")]
        LSDataConnector.LSDB.InsertTeamNameResponse InsertTeamName(LSDataConnector.LSDB.InsertTeamNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/InsertTeam", ReplyAction="*")]
        void InsertTeam(ulong teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/TeamExists", ReplyAction="*")]
        bool TeamExists(ulong teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/MatchExist", ReplyAction="*")]
        bool MatchExist(ulong matchId);
        
        // CODEGEN: Es wird ein Nachrichtenvertrag generiert, da Elementname devisionId aus Namespace http://sxtrader.net/ nicht als "nillable" (nullwertfähig) gekennzeichnet ist.
        [System.ServiceModel.OperationContractAttribute(Action="http://sxtrader.net/DevisionExist", ReplyAction="*")]
        LSDataConnector.LSDB.DevisionExistResponse DevisionExist(LSDataConnector.LSDB.DevisionExistRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamNames", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.GetTeamNamesRequestBody Body;
        
        public GetTeamNamesRequest() {
        }
        
        public GetTeamNamesRequest(LSDataConnector.LSDB.GetTeamNamesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class GetTeamNamesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong teamId;
        
        public GetTeamNamesRequestBody() {
        }
        
        public GetTeamNamesRequestBody(ulong teamId) {
            this.teamId = teamId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetTeamNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetTeamNamesResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.GetTeamNamesResponseBody Body;
        
        public GetTeamNamesResponse() {
        }
        
        public GetTeamNamesResponse(LSDataConnector.LSDB.GetTeamNamesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class GetTeamNamesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public LSDataConnector.LSDB.ArrayOfAnyType GetTeamNamesResult;
        
        public GetTeamNamesResponseBody() {
        }
        
        public GetTeamNamesResponseBody(LSDataConnector.LSDB.ArrayOfAnyType GetTeamNamesResult) {
            this.GetTeamNamesResult = GetTeamNamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMatchEventRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMatchEvent", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertMatchEventRequestBody Body;
        
        public InsertMatchEventRequest() {
        }
        
        public InsertMatchEventRequest(LSDataConnector.LSDB.InsertMatchEventRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class InsertMatchEventRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong matchId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public ulong teamId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int eventType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int eventMinute;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string infoEvent1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string infoEvent2;
        
        public InsertMatchEventRequestBody() {
        }
        
        public InsertMatchEventRequestBody(ulong matchId, ulong teamId, int eventType, int eventMinute, string infoEvent1, string infoEvent2) {
            this.matchId = matchId;
            this.teamId = teamId;
            this.eventType = eventType;
            this.eventMinute = eventMinute;
            this.infoEvent1 = infoEvent1;
            this.infoEvent2 = infoEvent2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMatchEventResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMatchEventResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertMatchEventResponseBody Body;
        
        public InsertMatchEventResponse() {
        }
        
        public InsertMatchEventResponse(LSDataConnector.LSDB.InsertMatchEventResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertMatchEventResponseBody {
        
        public InsertMatchEventResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMatchRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMatch", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertMatchRequestBody Body;
        
        public InsertMatchRequest() {
        }
        
        public InsertMatchRequest(LSDataConnector.LSDB.InsertMatchRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class InsertMatchRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong matchId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string matchDate;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public ulong teamA;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public ulong teamB;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string devisionId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public uint scoreTeamA;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public uint scoreTeamB;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string halftimeScore;
        
        public InsertMatchRequestBody() {
        }
        
        public InsertMatchRequestBody(ulong matchId, string matchDate, ulong teamA, ulong teamB, string devisionId, uint scoreTeamA, uint scoreTeamB, string halftimeScore) {
            this.matchId = matchId;
            this.matchDate = matchDate;
            this.teamA = teamA;
            this.teamB = teamB;
            this.devisionId = devisionId;
            this.scoreTeamA = scoreTeamA;
            this.scoreTeamB = scoreTeamB;
            this.halftimeScore = halftimeScore;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertMatchResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertMatchResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertMatchResponseBody Body;
        
        public InsertMatchResponse() {
        }
        
        public InsertMatchResponse(LSDataConnector.LSDB.InsertMatchResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertMatchResponseBody {
        
        public InsertMatchResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertDevisionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertDevision", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertDevisionRequestBody Body;
        
        public InsertDevisionRequest() {
        }
        
        public InsertDevisionRequest(LSDataConnector.LSDB.InsertDevisionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class InsertDevisionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string devisionId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string devisionName;
        
        public InsertDevisionRequestBody() {
        }
        
        public InsertDevisionRequestBody(string devisionId, string devisionName) {
            this.devisionId = devisionId;
            this.devisionName = devisionName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertDevisionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertDevisionResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertDevisionResponseBody Body;
        
        public InsertDevisionResponse() {
        }
        
        public InsertDevisionResponse(LSDataConnector.LSDB.InsertDevisionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertDevisionResponseBody {
        
        public InsertDevisionResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertTeamNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertTeamName", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertTeamNameRequestBody Body;
        
        public InsertTeamNameRequest() {
        }
        
        public InsertTeamNameRequest(LSDataConnector.LSDB.InsertTeamNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class InsertTeamNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public ulong teamId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string teamName;
        
        public InsertTeamNameRequestBody() {
        }
        
        public InsertTeamNameRequestBody(ulong teamId, string teamName) {
            this.teamId = teamId;
            this.teamName = teamName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertTeamNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertTeamNameResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.InsertTeamNameResponseBody Body;
        
        public InsertTeamNameResponse() {
        }
        
        public InsertTeamNameResponse(LSDataConnector.LSDB.InsertTeamNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class InsertTeamNameResponseBody {
        
        public InsertTeamNameResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevisionExistRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DevisionExist", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.DevisionExistRequestBody Body;
        
        public DevisionExistRequest() {
        }
        
        public DevisionExistRequest(LSDataConnector.LSDB.DevisionExistRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class DevisionExistRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string devisionId;
        
        public DevisionExistRequestBody() {
        }
        
        public DevisionExistRequestBody(string devisionId) {
            this.devisionId = devisionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DevisionExistResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DevisionExistResponse", Namespace="http://sxtrader.net/", Order=0)]
        public LSDataConnector.LSDB.DevisionExistResponseBody Body;
        
        public DevisionExistResponse() {
        }
        
        public DevisionExistResponse(LSDataConnector.LSDB.DevisionExistResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sxtrader.net/")]
    public partial class DevisionExistResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool DevisionExistResult;
        
        public DevisionExistResponseBody() {
        }
        
        public DevisionExistResponseBody(bool DevisionExistResult) {
            this.DevisionExistResult = DevisionExistResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LSDB1SoapChannel : LSDataConnector.LSDB.LSDB1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LSDB1SoapClient : System.ServiceModel.ClientBase<LSDataConnector.LSDB.LSDB1Soap>, LSDataConnector.LSDB.LSDB1Soap {
        
        public LSDB1SoapClient() {
        }
        
        public LSDB1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LSDB1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LSDB1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LSDB1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.GetTeamNamesResponse LSDataConnector.LSDB.LSDB1Soap.GetTeamNames(LSDataConnector.LSDB.GetTeamNamesRequest request) {
            return base.Channel.GetTeamNames(request);
        }
        
        public LSDataConnector.LSDB.ArrayOfAnyType GetTeamNames(ulong teamId) {
            LSDataConnector.LSDB.GetTeamNamesRequest inValue = new LSDataConnector.LSDB.GetTeamNamesRequest();
            inValue.Body = new LSDataConnector.LSDB.GetTeamNamesRequestBody();
            inValue.Body.teamId = teamId;
            LSDataConnector.LSDB.GetTeamNamesResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).GetTeamNames(inValue);
            return retVal.Body.GetTeamNamesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.InsertMatchEventResponse LSDataConnector.LSDB.LSDB1Soap.InsertMatchEvent(LSDataConnector.LSDB.InsertMatchEventRequest request) {
            return base.Channel.InsertMatchEvent(request);
        }
        
        public void InsertMatchEvent(ulong matchId, ulong teamId, int eventType, int eventMinute, string infoEvent1, string infoEvent2) {
            LSDataConnector.LSDB.InsertMatchEventRequest inValue = new LSDataConnector.LSDB.InsertMatchEventRequest();
            inValue.Body = new LSDataConnector.LSDB.InsertMatchEventRequestBody();
            inValue.Body.matchId = matchId;
            inValue.Body.teamId = teamId;
            inValue.Body.eventType = eventType;
            inValue.Body.eventMinute = eventMinute;
            inValue.Body.infoEvent1 = infoEvent1;
            inValue.Body.infoEvent2 = infoEvent2;
            LSDataConnector.LSDB.InsertMatchEventResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).InsertMatchEvent(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.InsertMatchResponse LSDataConnector.LSDB.LSDB1Soap.InsertMatch(LSDataConnector.LSDB.InsertMatchRequest request) {
            return base.Channel.InsertMatch(request);
        }
        
        public void InsertMatch(ulong matchId, string matchDate, ulong teamA, ulong teamB, string devisionId, uint scoreTeamA, uint scoreTeamB, string halftimeScore) {
            LSDataConnector.LSDB.InsertMatchRequest inValue = new LSDataConnector.LSDB.InsertMatchRequest();
            inValue.Body = new LSDataConnector.LSDB.InsertMatchRequestBody();
            inValue.Body.matchId = matchId;
            inValue.Body.matchDate = matchDate;
            inValue.Body.teamA = teamA;
            inValue.Body.teamB = teamB;
            inValue.Body.devisionId = devisionId;
            inValue.Body.scoreTeamA = scoreTeamA;
            inValue.Body.scoreTeamB = scoreTeamB;
            inValue.Body.halftimeScore = halftimeScore;
            LSDataConnector.LSDB.InsertMatchResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).InsertMatch(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.InsertDevisionResponse LSDataConnector.LSDB.LSDB1Soap.InsertDevision(LSDataConnector.LSDB.InsertDevisionRequest request) {
            return base.Channel.InsertDevision(request);
        }
        
        public void InsertDevision(string devisionId, string devisionName) {
            LSDataConnector.LSDB.InsertDevisionRequest inValue = new LSDataConnector.LSDB.InsertDevisionRequest();
            inValue.Body = new LSDataConnector.LSDB.InsertDevisionRequestBody();
            inValue.Body.devisionId = devisionId;
            inValue.Body.devisionName = devisionName;
            LSDataConnector.LSDB.InsertDevisionResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).InsertDevision(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.InsertTeamNameResponse LSDataConnector.LSDB.LSDB1Soap.InsertTeamName(LSDataConnector.LSDB.InsertTeamNameRequest request) {
            return base.Channel.InsertTeamName(request);
        }
        
        public void InsertTeamName(ulong teamId, string teamName) {
            LSDataConnector.LSDB.InsertTeamNameRequest inValue = new LSDataConnector.LSDB.InsertTeamNameRequest();
            inValue.Body = new LSDataConnector.LSDB.InsertTeamNameRequestBody();
            inValue.Body.teamId = teamId;
            inValue.Body.teamName = teamName;
            LSDataConnector.LSDB.InsertTeamNameResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).InsertTeamName(inValue);
        }
        
        public void InsertTeam(ulong teamId) {
            base.Channel.InsertTeam(teamId);
        }
        
        public bool TeamExists(ulong teamId) {
            return base.Channel.TeamExists(teamId);
        }
        
        public bool MatchExist(ulong matchId) {
            return base.Channel.MatchExist(matchId);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LSDataConnector.LSDB.DevisionExistResponse LSDataConnector.LSDB.LSDB1Soap.DevisionExist(LSDataConnector.LSDB.DevisionExistRequest request) {
            return base.Channel.DevisionExist(request);
        }
        
        public bool DevisionExist(string devisionId) {
            LSDataConnector.LSDB.DevisionExistRequest inValue = new LSDataConnector.LSDB.DevisionExistRequest();
            inValue.Body = new LSDataConnector.LSDB.DevisionExistRequestBody();
            inValue.Body.devisionId = devisionId;
            LSDataConnector.LSDB.DevisionExistResponse retVal = ((LSDataConnector.LSDB.LSDB1Soap)(this)).DevisionExist(inValue);
            return retVal.Body.DevisionExistResult;
        }
    }
}
