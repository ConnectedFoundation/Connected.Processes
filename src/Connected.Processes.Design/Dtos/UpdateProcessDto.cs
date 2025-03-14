using Connected.Annotations;

namespace Connected.Processes.Design.Dtos;

internal sealed class UpdateProcessDto : ProcessDto, IUpdateProcessDto
{
	[MinValue(1)]
	public int Id { get; set; }
}
