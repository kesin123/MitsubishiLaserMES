using Newtonsoft.Json;

namespace Protocol.Core.Messages;

public class ParameterResultItem
{
	[JsonProperty("Parameter")]
	public string Parameter { get; set; }

	[JsonProperty("Value")]
	public string Value { get; set; }
}
