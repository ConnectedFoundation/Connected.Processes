using Connected.Annotations;

namespace Connected.Processes.Design.Dtos;

internal sealed class UpdateProcessVersionDto : ProcessVersionDto, IUpdateProcessVersionDto
{
	[MinValue(1)]
	public int Id { get; set; }
}
