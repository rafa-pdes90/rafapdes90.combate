﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameServer
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GMFault", Namespace="http://schemas.datacontract.org/2004/07/GameServer")]
    public partial class GMFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ExceptionField;
        
        private int IdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Exception
        {
            get
            {
                return this.ExceptionField;
            }
            set
            {
                this.ExceptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGameMaster", SessionMode=System.ServiceModel.SessionMode.Required)]
public interface IGameMaster
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameMaster/IntroduceToGameMaster", ReplyAction="http://tempuri.org/IGameMaster/IntroduceToGameMasterResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(GameServer.GMFault), Action="http://tempuri.org/IGameMaster/IntroduceToGameMasterGMFaultFault", Name="GMFault", Namespace="http://schemas.datacontract.org/2004/07/GameServer")]
    void IntroduceToGameMaster(System.Uri clientUri);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameMaster/IntroduceToGameMaster", ReplyAction="http://tempuri.org/IGameMaster/IntroduceToGameMasterResponse")]
    System.Threading.Tasks.Task IntroduceToGameMasterAsync(System.Uri clientUri);
    
    [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IGameMaster/DoWork", ReplyAction="http://tempuri.org/IGameMaster/DoWorkResponse")]
    void DoWork();
    
    [System.ServiceModel.OperationContractAttribute(IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IGameMaster/DoWork", ReplyAction="http://tempuri.org/IGameMaster/DoWorkResponse")]
    System.Threading.Tasks.Task DoWorkAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IGameMasterChannel : IGameMaster, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GameMasterClient : System.ServiceModel.ClientBase<IGameMaster>, IGameMaster
{
    
    public GameMasterClient()
    {
    }
    
    public GameMasterClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GameMasterClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GameMasterClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GameMasterClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void IntroduceToGameMaster(System.Uri clientUri)
    {
        base.Channel.IntroduceToGameMaster(clientUri);
    }
    
    public System.Threading.Tasks.Task IntroduceToGameMasterAsync(System.Uri clientUri)
    {
        return base.Channel.IntroduceToGameMasterAsync(clientUri);
    }
    
    public void DoWork()
    {
        base.Channel.DoWork();
    }
    
    public System.Threading.Tasks.Task DoWorkAsync()
    {
        return base.Channel.DoWorkAsync();
    }
}
