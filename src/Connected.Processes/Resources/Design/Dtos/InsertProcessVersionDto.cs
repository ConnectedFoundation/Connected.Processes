using Connected.Annotations;

namespace Connected.Processes.Design.Dtos;

internal sealed class InsertProcessVersionDto : ProcessVersionDto, IInsertProcessVersionDto
{
	[MinValue(1)]
	public int Process { get; set; }
}
