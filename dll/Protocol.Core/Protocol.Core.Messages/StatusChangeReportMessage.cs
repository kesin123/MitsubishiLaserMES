using Protocol.Core.Base;
using Protocol.Core.Enums;

namespace Protocol.Core.Messages;

[CommandMapping(CommandType.StatusChangeReport)]
public class StatusChangeReportMessage : BaseMessage
{
	public string OldStatus { get; set; }

	public string NewStatus { get; set; }
}
