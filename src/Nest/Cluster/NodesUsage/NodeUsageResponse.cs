// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Runtime.Serialization;
using Elastic.SharedExtensions;
using Elasticsearch.Net;

namespace Nest
{
	public class NodesUsageResponse : NodesResponseBase
	{
		[DataMember(Name ="cluster_name")]
		public string ClusterName { get; internal set; }

		[DataMember(Name ="nodes")]
		public IReadOnlyDictionary<string, NodeUsageInformation> Nodes { get; internal set; } =
			EmptyReadOnly<string, NodeUsageInformation>.Dictionary;
	}
}
