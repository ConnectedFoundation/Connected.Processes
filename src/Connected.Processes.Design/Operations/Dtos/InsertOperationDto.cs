using Connected.Annotations;

namespace Connected.Processes.Design.Operations.Dtos;

internal sealed class InsertOperationDto : OperationDto, IInsertOperationDto
{
	[MinValue(1)]
	public int Version { get; set; }
}
