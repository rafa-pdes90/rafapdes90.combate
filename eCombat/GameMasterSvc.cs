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
    [System.Runtime.Serialization.DataContractAttribute(Name="GameMasterSvcFault", Namespace="http://schemas.datacontract.org/2004/07/GameServer")]
    public partial class GameMasterSvcFault : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CodeField;
        
        private string OperationField;
        
        private string ReasonField;
        
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
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation
        {
            get
            {
                return this.OperationField;
            }
            set
            {
                this.OperationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Reason
        {
            get
            {
                return this.ReasonField;
            }
            set
            {
                this.ReasonField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGameMasterSvc", SessionMode=System.ServiceModel.SessionMode.Required)]
public interface IGameMasterSvc
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameMasterSvc/EnterGame", ReplyAction="http://tempuri.org/IGameMasterSvc/EnterGameResponse")]
    [System.ServiceModel.FaultContractAttribute(typeof(GameServer.GameMasterSvcFault), Action="http://tempuri.org/IGameMasterSvc/EnterGameGameMasterSvcFaultFault", Name="GameMasterSvcFault", Namespace="http://schemas.datacontract.org/2004/07/GameServer")]
    void EnterGame(string clientId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameMasterSvc/EnterGame", ReplyAction="http://tempuri.org/IGameMasterSvc/EnterGameResponse")]
    System.Threading.Tasks.Task EnterGameAsync(string clientId);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/FaceMatch")]
    void FaceMatch(string displayName);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/FaceMatch")]
    System.Threading.Tasks.Task FaceMatchAsync(string displayName);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/CancelMatch")]
    void CancelMatch();
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/CancelMatch")]
    System.Threading.Tasks.Task CancelMatchAsync();
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/MoveBoardPiece")]
    void MoveBoardPiece(int srcX, int srcY, int destX, int destY);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/MoveBoardPiece")]
    System.Threading.Tasks.Task MoveBoardPieceAsync(int srcX, int srcY, int destX, int destY);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/AttackBoardPiece")]
    void AttackBoardPiece(int srcX, int srcY, int destX, int destY, string attackerPowerLevel);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/AttackBoardPiece")]
    System.Threading.Tasks.Task AttackBoardPieceAsync(int srcX, int srcY, int destX, int destY, string attackerPowerLevel);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/WriteMessageToChat")]
    void WriteMessageToChat(string message);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/WriteMessageToChat")]
    System.Threading.Tasks.Task WriteMessageToChatAsync(string message);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/LeaveGame")]
    void LeaveGame();
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IGameMasterSvc/LeaveGame")]
    System.Threading.Tasks.Task LeaveGameAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IGameMasterSvcChannel : IGameMasterSvc, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class GameMasterSvcClient : System.ServiceModel.ClientBase<IGameMasterSvc>, IGameMasterSvc
{
    
    public GameMasterSvcClient()
    {
    }
    
    public GameMasterSvcClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public GameMasterSvcClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GameMasterSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public GameMasterSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void EnterGame(string clientId)
    {
        base.Channel.EnterGame(clientId);
    }
    
    public System.Threading.Tasks.Task EnterGameAsync(string clientId)
    {
        return base.Channel.EnterGameAsync(clientId);
    }
    
    public void FaceMatch(string displayName)
    {
        base.Channel.FaceMatch(displayName);
    }
    
    public System.Threading.Tasks.Task FaceMatchAsync(string displayName)
    {
        return base.Channel.FaceMatchAsync(displayName);
    }
    
    public void CancelMatch()
    {
        base.Channel.CancelMatch();
    }
    
    public System.Threading.Tasks.Task CancelMatchAsync()
    {
        return base.Channel.CancelMatchAsync();
    }
    
    public void MoveBoardPiece(int srcX, int srcY, int destX, int destY)
    {
        base.Channel.MoveBoardPiece(srcX, srcY, destX, destY);
    }
    
    public System.Threading.Tasks.Task MoveBoardPieceAsync(int srcX, int srcY, int destX, int destY)
    {
        return base.Channel.MoveBoardPieceAsync(srcX, srcY, destX, destY);
    }
    
    public void AttackBoardPiece(int srcX, int srcY, int destX, int destY, string attackerPowerLevel)
    {
        base.Channel.AttackBoardPiece(srcX, srcY, destX, destY, attackerPowerLevel);
    }
    
    public System.Threading.Tasks.Task AttackBoardPieceAsync(int srcX, int srcY, int destX, int destY, string attackerPowerLevel)
    {
        return base.Channel.AttackBoardPieceAsync(srcX, srcY, destX, destY, attackerPowerLevel);
    }
    
    public void WriteMessageToChat(string message)
    {
        base.Channel.WriteMessageToChat(message);
    }
    
    public System.Threading.Tasks.Task WriteMessageToChatAsync(string message)
    {
        return base.Channel.WriteMessageToChatAsync(message);
    }
    
    public void LeaveGame()
    {
        base.Channel.LeaveGame();
    }
    
    public System.Threading.Tasks.Task LeaveGameAsync()
    {
        return base.Channel.LeaveGameAsync();
    }
}
