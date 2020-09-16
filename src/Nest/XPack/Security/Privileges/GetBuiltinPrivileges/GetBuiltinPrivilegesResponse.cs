// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Runtime.Serialization;
using Elastic.SharedExtensions;
using Elasticsearch.Net;

namespace Nest
{
	[DataContract]
	public class GetBuiltinPrivilegesResponse : ResponseBase
	{
		private IReadOnlyCollection<string> _cluster = EmptyReadOnly<string>.Collection;

		[DataMember(Name = "cluster")]
		public IReadOnlyCollection<string> Cluster
		{
			get => _cluster;
			internal set => _cluster = value;
		}

		[DataMember(Name = "index")]
		public IReadOnlyCollection<string> Index { get; internal set; } = EmptyReadOnly<string>.Collection;
	}
}
