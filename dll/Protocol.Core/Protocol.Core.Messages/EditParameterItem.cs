using Newtonsoft.Json;

namespace Protocol.Core.Messages;

public class EditParameterItem
{
	[JsonProperty("Parameter")]
	public string Parameter { get; set; }

	[JsonProperty("Value")]
	public string Value { get; set; }
}
