using Connected.Annotations;

namespace Connected.Processes.Design.Operations.Dtos;

internal sealed class UpdateOperationDto : OperationDto, IUpdateOperationDto
{
	[MinValue(1)]
	public int Id { get; set; }
}
