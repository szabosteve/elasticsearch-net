// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//
// This file is automatically generated
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net;

using Elasticsearch.Net.Specification.SnapshotLifecycleManagementApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeleteSnapshotLifecycleRequest : IRequest<DeleteSnapshotLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for DeleteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-delete-policy.html</para></summary>
	public partial class DeleteSnapshotLifecycleRequest : PlainRequestBase<DeleteSnapshotLifecycleRequestParameters>, IDeleteSnapshotLifecycleRequest
	{
		protected IDeleteSnapshotLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public DeleteSnapshotLifecycleRequest(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteSnapshotLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IDeleteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IExecuteSnapshotLifecycleRequest : IRequest<ExecuteSnapshotLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for ExecuteSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-lifecycle.html</para></summary>
	public partial class ExecuteSnapshotLifecycleRequest : PlainRequestBase<ExecuteSnapshotLifecycleRequestParameters>, IExecuteSnapshotLifecycleRequest
	{
		protected IExecuteSnapshotLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}/_execute</summary>
		///<param name = "policyId">this parameter is required</param>
		public ExecuteSnapshotLifecycleRequest(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected ExecuteSnapshotLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IExecuteSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IExecuteRetentionRequest : IRequest<ExecuteRetentionRequestParameters>
	{
	}

	///<summary>Request for ExecuteRetention <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-execute-retention.html</para></summary>
	public partial class ExecuteRetentionRequest : PlainRequestBase<ExecuteRetentionRequestParameters>, IExecuteRetentionRequest
	{
		protected IExecuteRetentionRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementExecuteRetention;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetSnapshotLifecycleRequest : IRequest<GetSnapshotLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Ids PolicyId
		{
			get;
		}
	}

	///<summary>Request for GetSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-policy.html</para></summary>
	public partial class GetSnapshotLifecycleRequest : PlainRequestBase<GetSnapshotLifecycleRequestParameters>, IGetSnapshotLifecycleRequest
	{
		protected IGetSnapshotLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">Optional, accepts null</param>
		public GetSnapshotLifecycleRequest(Ids policyId): base(r => r.Optional("policy_id", policyId))
		{
		}

		///<summary>/_slm/policy</summary>
		public GetSnapshotLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Ids IGetSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Ids>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetSnapshotLifecycleStatsRequest : IRequest<GetSnapshotLifecycleStatsRequestParameters>
	{
	}

	///<summary>Request for GetSnapshotLifecycleStats <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/slm-api-get-stats.html</para></summary>
	public partial class GetSnapshotLifecycleStatsRequest : PlainRequestBase<GetSnapshotLifecycleStatsRequestParameters>, IGetSnapshotLifecycleStatsRequest
	{
		protected IGetSnapshotLifecycleStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetSnapshotLifecycleStats;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IGetSnapshotLifecycleManagementStatusRequest : IRequest<GetSnapshotLifecycleManagementStatusRequestParameters>
	{
	}

	///<summary>Request for GetStatus <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-get-status.html</para></summary>
	public partial class GetSnapshotLifecycleManagementStatusRequest : PlainRequestBase<GetSnapshotLifecycleManagementStatusRequestParameters>, IGetSnapshotLifecycleManagementStatusRequest
	{
		protected IGetSnapshotLifecycleManagementStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementGetStatus;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IPutSnapshotLifecycleRequest : IRequest<PutSnapshotLifecycleRequestParameters>
	{
		[IgnoreDataMember]
		Id PolicyId
		{
			get;
		}
	}

	///<summary>Request for PutSnapshotLifecycle <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-put-policy.html</para></summary>
	public partial class PutSnapshotLifecycleRequest : PlainRequestBase<PutSnapshotLifecycleRequestParameters>, IPutSnapshotLifecycleRequest
	{
		protected IPutSnapshotLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementPutSnapshotLifecycle;
		///<summary>/_slm/policy/{policy_id}</summary>
		///<param name = "policyId">this parameter is required</param>
		public PutSnapshotLifecycleRequest(Id policyId): base(r => r.Required("policy_id", policyId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutSnapshotLifecycleRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Id IPutSnapshotLifecycleRequest.PolicyId => Self.RouteValues.Get<Id>("policy_id");
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IStartSnapshotLifecycleManagementRequest : IRequest<StartSnapshotLifecycleManagementRequestParameters>
	{
	}

	///<summary>Request for Start <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-start.html</para></summary>
	public partial class StartSnapshotLifecycleManagementRequest : PlainRequestBase<StartSnapshotLifecycleManagementRequestParameters>, IStartSnapshotLifecycleManagementRequest
	{
		protected IStartSnapshotLifecycleManagementRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStart;
	// values part of the url path
	// Request parameters
	}

	[InterfaceDataContract]
	public partial interface IStopSnapshotLifecycleManagementRequest : IRequest<StopSnapshotLifecycleManagementRequestParameters>
	{
	}

	///<summary>Request for Stop <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/slm-api-stop.html</para></summary>
	public partial class StopSnapshotLifecycleManagementRequest : PlainRequestBase<StopSnapshotLifecycleManagementRequestParameters>, IStopSnapshotLifecycleManagementRequest
	{
		protected IStopSnapshotLifecycleManagementRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementStop;
	// values part of the url path
	// Request parameters
	}
}
