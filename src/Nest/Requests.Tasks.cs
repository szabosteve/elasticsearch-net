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

using Elasticsearch.Net.Specification.TasksApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface ICancelTasksRequest : IRequest<CancelTasksRequestParameters>
	{
		[IgnoreDataMember]
		TaskId TaskId
		{
			get;
		}
	}

	///<summary>Request for Cancel <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public partial class CancelTasksRequest : PlainRequestBase<CancelTasksRequestParameters>, ICancelTasksRequest
	{
		protected ICancelTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
		///<summary>/_tasks/_cancel</summary>
		public CancelTasksRequest(): base()
		{
		}

		///<summary>/_tasks/{task_id}/_cancel</summary>
		///<param name = "taskId">Optional, accepts null</param>
		public CancelTasksRequest(TaskId taskId): base(r => r.Optional("task_id", taskId))
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		TaskId ICancelTasksRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		// Request parameters
		///<summary>A comma-separated list of actions that should be cancelled. Leave empty to cancel all.</summary>
		public string[] Actions
		{
			get => Q<string[]>("actions");
			set => Q("actions", value);
		}

		///<summary>
		/// A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're
		/// connecting to, leave empty to get information from all nodes
		///</summary>
		public string[] Nodes
		{
			get => Q<string[]>("nodes");
			set => Q("nodes", value);
		}

		///<summary>Cancel tasks with specified parent task id (node_id:task_number). Set to -1 to cancel all.</summary>
		public string ParentTaskId
		{
			get => Q<string>("parent_task_id");
			set => Q("parent_task_id", value);
		}

		///<summary>Should the request block until the cancellation of the task and its descendant tasks is completed. Defaults to false</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IGetTaskRequest : IRequest<GetTaskRequestParameters>
	{
		[IgnoreDataMember]
		TaskId TaskId
		{
			get;
		}
	}

	///<summary>Request for GetTask <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public partial class GetTaskRequest : PlainRequestBase<GetTaskRequestParameters>, IGetTaskRequest
	{
		protected IGetTaskRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGetTask;
		///<summary>/_tasks/{task_id}</summary>
		///<param name = "taskId">this parameter is required</param>
		public GetTaskRequest(TaskId taskId): base(r => r.Required("task_id", taskId))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetTaskRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		TaskId IGetTaskRequest.TaskId => Self.RouteValues.Get<TaskId>("task_id");
		// Request parameters
		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}

	[InterfaceDataContract]
	public partial interface IListTasksRequest : IRequest<ListTasksRequestParameters>
	{
	}

	///<summary>Request for List <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/tasks.html</para></summary>
	public partial class ListTasksRequest : PlainRequestBase<ListTasksRequestParameters>, IListTasksRequest
	{
		protected IListTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
		// values part of the url path
		// Request parameters
		///<summary>A comma-separated list of actions that should be returned. Leave empty to return all.</summary>
		public string[] Actions
		{
			get => Q<string[]>("actions");
			set => Q("actions", value);
		}

		///<summary>Return detailed task information (default: false)</summary>
		public bool? Detailed
		{
			get => Q<bool? >("detailed");
			set => Q("detailed", value);
		}

		///<summary>Group tasks by nodes or parent/child relationships</summary>
		public GroupBy? GroupBy
		{
			get => Q<GroupBy? >("group_by");
			set => Q("group_by", value);
		}

		///<summary>
		/// A comma-separated list of node IDs or names to limit the returned information; use `_local` to return information from the node you're
		/// connecting to, leave empty to get information from all nodes
		///</summary>
		public string[] Nodes
		{
			get => Q<string[]>("nodes");
			set => Q("nodes", value);
		}

		///<summary>Return tasks with specified parent task id (node_id:task_number). Set to -1 to return all.</summary>
		public string ParentTaskId
		{
			get => Q<string>("parent_task_id");
			set => Q("parent_task_id", value);
		}

		///<summary>Explicit operation timeout</summary>
		public Time Timeout
		{
			get => Q<Time>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Wait for the matching tasks to complete (default: false)</summary>
		public bool? WaitForCompletion
		{
			get => Q<bool? >("wait_for_completion");
			set => Q("wait_for_completion", value);
		}
	}
}
