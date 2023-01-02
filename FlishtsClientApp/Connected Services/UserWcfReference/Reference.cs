﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserWcfReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/FlightsWCF.Models")]
    public partial class User : UserWcfReference.BaseEntity
    {
        
        private string FirstNameField;
        
        private string LastNameField;
        
        private string MiddleNameField;
        
        private string PhoneField;

        public override string ToString()
        {
            return $"User #{Id}:" + string.Join(", ", FirstName, LastName, MiddleName, Phone);
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName
        {
            get
            {
                return this.MiddleNameField;
            }
            set
            {
                this.MiddleNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone
        {
            get
            {
                return this.PhoneField;
            }
            set
            {
                this.PhoneField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/FlightsWCF.Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(UserWcfReference.User))]
    public partial class BaseEntity : object
    {
        
        private long IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Id
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserWcfReference.IUserService")]
    public interface IUserService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<UserWcfReference.User[]> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetById", ReplyAction="http://tempuri.org/IUserService/GetByIdResponse")]
        System.Threading.Tasks.Task<UserWcfReference.User> GetByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Add", ReplyAction="http://tempuri.org/IUserService/AddResponse")]
        System.Threading.Tasks.Task AddAsync(UserWcfReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Update", ReplyAction="http://tempuri.org/IUserService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(UserWcfReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Delete", ReplyAction="http://tempuri.org/IUserService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IUserServiceChannel : UserWcfReference.IUserService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<UserWcfReference.IUserService>, UserWcfReference.IUserService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UserServiceClient() : 
                base(UserServiceClient.GetDefaultBinding(), UserServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUserService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), UserServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<UserWcfReference.User[]> GetAllUsersAsync()
        {
            return base.Channel.GetAllUsersAsync();
        }
        
        public System.Threading.Tasks.Task<UserWcfReference.User> GetByIdAsync(int id)
        {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task AddAsync(UserWcfReference.User user)
        {
            return base.Channel.AddAsync(user);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(UserWcfReference.User user)
        {
            return base.Channel.UpdateAsync(user);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id)
        {
            return base.Channel.DeleteAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:61236/UserService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUserService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUserService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUserService,
        }
    }
}