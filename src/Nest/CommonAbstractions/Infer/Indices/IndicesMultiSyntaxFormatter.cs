// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Transport.Serialization;
using Elastic.Transport.Utf8Json;
using Elasticsearch.Net;


namespace Nest
{
	internal class IndicesMultiSyntaxFormatter : IJsonFormatter<Indices>
	{
		public Indices Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver)
		{
			if (reader.GetCurrentJsonToken() == JsonToken.String)
			{
				Indices indices = reader.ReadString();
				return indices;
			}

			reader.ReadNextBlock();
			return null;
		}

		public void Serialize(ref JsonWriter writer, Indices value, IJsonFormatterResolver formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			switch (value.Tag)
			{
				case 0:
					writer.WriteString("_all");
					break;
				case 1:
					var connectionSettings = formatterResolver.GetConnectionSettings();
					writer.WriteString(((IUrlParameter)value).GetString(connectionSettings));
					break;
			}
		}
	}
}
