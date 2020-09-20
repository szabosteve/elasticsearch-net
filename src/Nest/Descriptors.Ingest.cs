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
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net;

using Elasticsearch.Net.Specification.IngestApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	///<summary>Descriptor for DeletePipeline <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/delete-pipeline-api.html</para></summary>
	public partial class DeletePipelineDescriptor : RequestDescriptorBase<DeletePipelineDescriptor, DeletePipelineRequestParameters, IDeletePipelineRequest>, IDeletePipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestDeletePipeline;
		///<summary>/_ingest/pipeline/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public DeletePipelineDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeletePipelineDescriptor(): base()
		{
		}

		// values part of the url path
		Id IDeletePipelineRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public DeletePipelineDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout</summary>
		public DeletePipelineDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for GetPipeline <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/get-pipeline-api.html</para></summary>
	public partial class GetPipelineDescriptor : RequestDescriptorBase<GetPipelineDescriptor, GetPipelineRequestParameters, IGetPipelineRequest>, IGetPipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGetPipeline;
		///<summary>/_ingest/pipeline</summary>
		public GetPipelineDescriptor(): base()
		{
		}

		///<summary>/_ingest/pipeline/{id}</summary>
		///<param name = "id">Optional, accepts null</param>
		public GetPipelineDescriptor(Id id): base(r => r.Optional("id", id))
		{
		}

		// values part of the url path
		Id IGetPipelineRequest.Id => Self.RouteValues.Get<Id>("id");
		///<summary>Comma separated list of pipeline ids. Wildcards supported</summary>
		public GetPipelineDescriptor Id(Id id) => Assign(id, (a, v) => a.RouteValues.Optional("id", v));
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public GetPipelineDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
	}

	///<summary>Descriptor for GrokProcessorPatterns <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/grok-processor.html#grok-processor-rest-get</para></summary>
	public partial class GrokProcessorPatternsDescriptor : RequestDescriptorBase<GrokProcessorPatternsDescriptor, GrokProcessorPatternsRequestParameters, IGrokProcessorPatternsRequest>, IGrokProcessorPatternsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGrokProcessorPatterns;
	// values part of the url path
	// Request parameters
	}

	///<summary>Descriptor for PutPipeline <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/put-pipeline-api.html</para></summary>
	public partial class PutPipelineDescriptor : RequestDescriptorBase<PutPipelineDescriptor, PutPipelineRequestParameters, IPutPipelineRequest>, IPutPipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestPutPipeline;
		///<summary>/_ingest/pipeline/{id}</summary>
		///<param name = "id">this parameter is required</param>
		public PutPipelineDescriptor(Id id): base(r => r.Required("id", id))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutPipelineDescriptor(): base()
		{
		}

		// values part of the url path
		Id IPutPipelineRequest.Id => Self.RouteValues.Get<Id>("id");
		// Request parameters
		///<summary>Explicit operation timeout for connection to master node</summary>
		public PutPipelineDescriptor MasterTimeout(Time mastertimeout) => Qs("master_timeout", mastertimeout);
		///<summary>Explicit operation timeout</summary>
		public PutPipelineDescriptor Timeout(Time timeout) => Qs("timeout", timeout);
	}

	///<summary>Descriptor for SimulatePipeline <para>https://www.elastic.co/guide/en/elasticsearch/reference/master/simulate-pipeline-api.html</para></summary>
	public partial class SimulatePipelineDescriptor : RequestDescriptorBase<SimulatePipelineDescriptor, SimulatePipelineRequestParameters, ISimulatePipelineRequest>, ISimulatePipelineRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestSimulatePipeline;
		///<summary>/_ingest/pipeline/_simulate</summary>
		public SimulatePipelineDescriptor(): base()
		{
		}

		///<summary>/_ingest/pipeline/{id}/_simulate</summary>
		///<param name = "id">Optional, accepts null</param>
		public SimulatePipelineDescriptor(Id id): base(r => r.Optional("id", id))
		{
		}

		// values part of the url path
		Id ISimulatePipelineRequest.Id => Self.RouteValues.Get<Id>("id");
		///<summary>Pipeline ID</summary>
		public SimulatePipelineDescriptor Id(Id id) => Assign(id, (a, v) => a.RouteValues.Optional("id", v));
		// Request parameters
		///<summary>Verbose mode. Display data output for each processor in executed pipeline</summary>
		public SimulatePipelineDescriptor Verbose(bool? verbose = true) => Qs("verbose", verbose);
	}
}
