using System.Collections.Generic;
using Newtonsoft.Json;
using Protocol.Core.Base;
using Protocol.Core.Enums;
using Protocol.Core.Utils;

namespace Protocol.Core.Messages;

[CommandMapping(CommandType.ReplyTrackOutReq)]
public class ReplyTrackOutReqMessage : ReplyBase
{
	public string MaterialID { get; set; }

	[JsonConverter(typeof(StringOrArrayConverter))]
	public List<string> CassetteID { get; set; }

	[JsonConverter(typeof(StringOrArrayConverter))]
	public List<string> WorkOrder { get; set; }

	public string UserID { get; set; }

	public string ToolingID { get; set; }

	public string PanelID { get; set; }
}
