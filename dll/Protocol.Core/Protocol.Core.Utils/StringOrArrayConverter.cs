using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Protocol.Core.Utils;

public class StringOrArrayConverter : JsonConverter<List<string>>
{
	public override void WriteJson(JsonWriter writer, List<string> value, JsonSerializer serializer)
	{
		if (value == null || value.Count == 0)
		{
			writer.WriteNull();
			return;
		}
		if (value.Count == 1)
		{
			writer.WriteValue(value[0]);
			return;
		}
		writer.WriteStartArray();
		foreach (string item in value)
		{
			writer.WriteValue(item);
		}
		writer.WriteEndArray();
	}

	public override List<string> ReadJson(JsonReader reader, Type objectType, List<string> existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((int)reader.TokenType == 11)
		{
			return null;
		}
		if ((int)reader.TokenType == 2)
		{
			return serializer.Deserialize<List<string>>(reader);
		}
		string text = serializer.Deserialize<string>(reader);
		return (text == null) ? null : new List<string> { text };
	}
}
