//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakeBeauty.Services.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    using System.ServiceModel.Web;
    using MakeBeauty.Services.Web.Models;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'HairStyleDomainService' DomainService.
    /// </summary>
    public sealed partial class HairStyleDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleDomainContext"/> class.
        /// </summary>
        public HairStyleDomainContext() : 
                this(new WebDomainClient<IHairStyleDomainServiceContract>(new Uri("MakeBeauty-Services-Web-HairStyleDomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The HairStyleDomainService service URI.</param>
        public HairStyleDomainContext(Uri serviceUri) : 
                this(new WebDomainClient<IHairStyleDomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public HairStyleDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="HairStyleProxy"/> entity instances that have been loaded into this <see cref="HairStyleDomainContext"/> instance.
        /// </summary>
        public EntitySet<HairStyleProxy> HairStyleProxies
        {
            get
            {
                return base.EntityContainer.GetEntitySet<HairStyleProxy>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="HairStyleProxy"/> entity instances using the 'Create' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="HairStyleProxy"/> entity instances.</returns>
        public EntityQuery<HairStyleProxy> CreateQuery()
        {
            this.ValidateMethod("CreateQuery", null);
            return base.CreateQuery<HairStyleProxy>("Create", null, false, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="HairStyleProxy"/> entity instances using the 'GetAll' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="HairStyleProxy"/> entity instances.</returns>
        public EntityQuery<HairStyleProxy> GetAllQuery()
        {
            this.ValidateMethod("GetAllQuery", null);
            return base.CreateQuery<HairStyleProxy>("GetAll", null, false, true);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetById' method of the DomainService.
        /// </summary>
        /// <param name="id">The value for the 'id' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<HairStyleProxy> GetById(int id, Action<InvokeOperation<HairStyleProxy>> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            this.ValidateMethod("GetById", parameters);
            return ((InvokeOperation<HairStyleProxy>)(this.InvokeOperation("GetById", typeof(HairStyleProxy), parameters, true, callback, userState)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetById' method of the DomainService.
        /// </summary>
        /// <param name="id">The value for the 'id' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<HairStyleProxy> GetById(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            this.ValidateMethod("GetById", parameters);
            return ((InvokeOperation<HairStyleProxy>)(this.InvokeOperation("GetById", typeof(HairStyleProxy), parameters, true, null, null)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'Save' method of the DomainService.
        /// </summary>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation Save(Action<InvokeOperation> callback, object userState)
        {
            this.ValidateMethod("Save", null);
            return this.InvokeOperation("Save", typeof(void), null, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'Save' method of the DomainService.
        /// </summary>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation Save()
        {
            this.ValidateMethod("Save", null);
            return this.InvokeOperation("Save", typeof(void), null, true, null, null);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new HairStyleDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'HairStyleDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IHairStyleDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'Create' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/HairStyleDomainService/CreateDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/HairStyleDomainService/Create", ReplyAction="http://tempuri.org/HairStyleDomainService/CreateResponse")]
            [WebGet()]
            IAsyncResult BeginCreate(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginCreate'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginCreate'.</param>
            /// <returns>The 'QueryResult' returned from the 'Create' operation.</returns>
            QueryResult<HairStyleProxy> EndCreate(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetAll' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/HairStyleDomainService/GetAllDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/HairStyleDomainService/GetAll", ReplyAction="http://tempuri.org/HairStyleDomainService/GetAllResponse")]
            [WebGet()]
            IAsyncResult BeginGetAll(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetAll'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetAll'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetAll' operation.</returns>
            QueryResult<HairStyleProxy> EndGetAll(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetById' operation.
            /// </summary>
            /// <param name="id">The value for the 'id' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/HairStyleDomainService/GetByIdDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/HairStyleDomainService/GetById", ReplyAction="http://tempuri.org/HairStyleDomainService/GetByIdResponse")]
            IAsyncResult BeginGetById(int id, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetById'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetById'.</param>
            /// <returns>The 'HairStyleProxy' returned from the 'GetById' operation.</returns>
            HairStyleProxy EndGetById(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Save' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/HairStyleDomainService/SaveDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/HairStyleDomainService/Save", ReplyAction="http://tempuri.org/HairStyleDomainService/SaveResponse")]
            IAsyncResult BeginSave(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSave'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSave'.</param>
            void EndSave(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/HairStyleDomainService/SubmitChangesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/HairStyleDomainService/SubmitChanges", ReplyAction="http://tempuri.org/HairStyleDomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class HairStyleDomainContextEntityContainer : EntityContainer
        {
            
            public HairStyleDomainContextEntityContainer()
            {
                this.CreateEntitySet<HairStyleProxy>(EntitySetOperations.All);
            }
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'TaskDomainService' DomainService.
    /// </summary>
    public sealed partial class TaskDomainContext : DomainContext
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class.
        /// </summary>
        public TaskDomainContext() : 
                this(new WebDomainClient<ITaskDomainServiceContract>(new Uri("MakeBeauty-Services-Web-TaskDomainService.svc", UriKind.Relative)))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The TaskDomainService service URI.</param>
        public TaskDomainContext(Uri serviceUri) : 
                this(new WebDomainClient<ITaskDomainServiceContract>(serviceUri))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDomainContext"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public TaskDomainContext(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="TaskProxy"/> entity instances that have been loaded into this <see cref="TaskDomainContext"/> instance.
        /// </summary>
        public EntitySet<TaskProxy> TaskProxies
        {
            get
            {
                return base.EntityContainer.GetEntitySet<TaskProxy>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="TaskProxy"/> entity instances using the 'Create' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="TaskProxy"/> entity instances.</returns>
        public EntityQuery<TaskProxy> CreateQuery()
        {
            this.ValidateMethod("CreateQuery", null);
            return base.CreateQuery<TaskProxy>("Create", null, false, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="TaskProxy"/> entity instances using the 'GetAll' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="TaskProxy"/> entity instances.</returns>
        public EntityQuery<TaskProxy> GetAllQuery()
        {
            this.ValidateMethod("GetAllQuery", null);
            return base.CreateQuery<TaskProxy>("GetAll", null, false, true);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetById' method of the DomainService.
        /// </summary>
        /// <param name="id">The value for the 'id' parameter of this action.</param>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<TaskProxy> GetById(int id, Action<InvokeOperation<TaskProxy>> callback, object userState)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            this.ValidateMethod("GetById", parameters);
            return ((InvokeOperation<TaskProxy>)(this.InvokeOperation("GetById", typeof(TaskProxy), parameters, true, callback, userState)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'GetById' method of the DomainService.
        /// </summary>
        /// <param name="id">The value for the 'id' parameter of this action.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation<TaskProxy> GetById(int id)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("id", id);
            this.ValidateMethod("GetById", parameters);
            return ((InvokeOperation<TaskProxy>)(this.InvokeOperation("GetById", typeof(TaskProxy), parameters, true, null, null)));
        }
        
        /// <summary>
        /// Asynchronously invokes the 'Save' method of the DomainService.
        /// </summary>
        /// <param name="callback">Callback to invoke when the operation completes.</param>
        /// <param name="userState">Value to pass to the callback.  It can be <c>null</c>.</param>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation Save(Action<InvokeOperation> callback, object userState)
        {
            this.ValidateMethod("Save", null);
            return this.InvokeOperation("Save", typeof(void), null, true, callback, userState);
        }
        
        /// <summary>
        /// Asynchronously invokes the 'Save' method of the DomainService.
        /// </summary>
        /// <returns>An operation instance that can be used to manage the asynchronous request.</returns>
        public InvokeOperation Save()
        {
            this.ValidateMethod("Save", null);
            return this.InvokeOperation("Save", typeof(void), null, true, null, null);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new TaskDomainContextEntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'TaskDomainService' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface ITaskDomainServiceContract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'Create' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/CreateDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/Create", ReplyAction="http://tempuri.org/TaskDomainService/CreateResponse")]
            [WebGet()]
            IAsyncResult BeginCreate(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginCreate'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginCreate'.</param>
            /// <returns>The 'QueryResult' returned from the 'Create' operation.</returns>
            QueryResult<TaskProxy> EndCreate(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetAll' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/GetAllDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/GetAll", ReplyAction="http://tempuri.org/TaskDomainService/GetAllResponse")]
            [WebGet()]
            IAsyncResult BeginGetAll(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetAll'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetAll'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetAll' operation.</returns>
            QueryResult<TaskProxy> EndGetAll(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'GetById' operation.
            /// </summary>
            /// <param name="id">The value for the 'id' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/GetByIdDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/GetById", ReplyAction="http://tempuri.org/TaskDomainService/GetByIdResponse")]
            IAsyncResult BeginGetById(int id, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetById'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetById'.</param>
            /// <returns>The 'TaskProxy' returned from the 'GetById' operation.</returns>
            TaskProxy EndGetById(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Save' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/SaveDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/Save", ReplyAction="http://tempuri.org/TaskDomainService/SaveResponse")]
            IAsyncResult BeginSave(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSave'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSave'.</param>
            void EndSave(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [FaultContract(typeof(DomainServiceFault), Action="http://tempuri.org/TaskDomainService/SubmitChangesDomainServiceFault", Name="DomainServiceFault", Namespace="DomainServices")]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/TaskDomainService/SubmitChanges", ReplyAction="http://tempuri.org/TaskDomainService/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class TaskDomainContextEntityContainer : EntityContainer
        {
            
            public TaskDomainContextEntityContainer()
            {
                this.CreateEntitySet<TaskProxy>(EntitySetOperations.All);
            }
        }
    }
}
namespace MakeBeauty.Services.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel.DomainServices;
    using System.ServiceModel.DomainServices.Client;
    using System.ServiceModel.DomainServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// The 'HairStyleProxy' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/MakeBeauty.Services.Web.Models")]
    public sealed partial class HairStyleProxy : Entity
    {
        
        private int _id;
        
        private string _name;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HairStyleProxy"/> class.
        /// </summary>
        public HairStyleProxy()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Name' value.
        /// </summary>
        [DataMember()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnNameChanging(value);
                    this.RaiseDataMemberChanging("Name");
                    this.ValidateProperty("Name", value);
                    this._name = value;
                    this.RaiseDataMemberChanged("Name");
                    this.OnNameChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
    
    /// <summary>
    /// The 'TaskProxy' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/MakeBeauty.Services.Web.Models")]
    public sealed partial class TaskProxy : Entity
    {
        
        private string _client;
        
        private DateTime _date;
        
        private string _description;
        
        private int _hairStyleId;
        
        private int _id;
        
        private string _phone;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnClientChanging(string value);
        partial void OnClientChanged();
        partial void OnDateChanging(DateTime value);
        partial void OnDateChanged();
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        partial void OnHairStyleIdChanging(int value);
        partial void OnHairStyleIdChanged();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProxy"/> class.
        /// </summary>
        public TaskProxy()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Client' value.
        /// </summary>
        [DataMember()]
        public string Client
        {
            get
            {
                return this._client;
            }
            set
            {
                if ((this._client != value))
                {
                    this.OnClientChanging(value);
                    this.RaiseDataMemberChanging("Client");
                    this.ValidateProperty("Client", value);
                    this._client = value;
                    this.RaiseDataMemberChanged("Client");
                    this.OnClientChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Date' value.
        /// </summary>
        [DataMember()]
        public DateTime Date
        {
            get
            {
                return this._date;
            }
            set
            {
                if ((this._date != value))
                {
                    this.OnDateChanging(value);
                    this.RaiseDataMemberChanging("Date");
                    this.ValidateProperty("Date", value);
                    this._date = value;
                    this.RaiseDataMemberChanged("Date");
                    this.OnDateChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Description' value.
        /// </summary>
        [DataMember()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                if ((this._description != value))
                {
                    this.OnDescriptionChanging(value);
                    this.RaiseDataMemberChanging("Description");
                    this.ValidateProperty("Description", value);
                    this._description = value;
                    this.RaiseDataMemberChanged("Description");
                    this.OnDescriptionChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'HairStyleId' value.
        /// </summary>
        [DataMember()]
        public int HairStyleId
        {
            get
            {
                return this._hairStyleId;
            }
            set
            {
                if ((this._hairStyleId != value))
                {
                    this.OnHairStyleIdChanging(value);
                    this.RaiseDataMemberChanging("HairStyleId");
                    this.ValidateProperty("HairStyleId", value);
                    this._hairStyleId = value;
                    this.RaiseDataMemberChanged("HairStyleId");
                    this.OnHairStyleIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Id' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    this.OnIdChanging(value);
                    this.ValidateProperty("Id", value);
                    this._id = value;
                    this.RaisePropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Phone' value.
        /// </summary>
        [DataMember()]
        public string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                if ((this._phone != value))
                {
                    this.OnPhoneChanging(value);
                    this.RaiseDataMemberChanging("Phone");
                    this.ValidateProperty("Phone", value);
                    this._phone = value;
                    this.RaiseDataMemberChanged("Phone");
                    this.OnPhoneChanged();
                }
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._id;
        }
    }
}
