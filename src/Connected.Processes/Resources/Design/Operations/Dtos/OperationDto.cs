using Connected.Annotations;
using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Processes.Design.Operations.Dtos;

internal abstract class OperationDto : Dto, IOperationDto
{
	[MinValue(1)]
	public int Parent { get; set; }

	[Required, MaxLength(128)]
	public required string Code { get; set; }

	[Required, MaxLength(128)]
	public required string Name { get; set; }

	[MaxLength(1024)]
	public string? Description { get; set; }

	public int Index { get; set; }

	public ActivationBehavior Activation { get; set; } = ActivationBehavior.Manual;
	public CompletionBehavior Completion { get; set; } = CompletionBehavior.Manual;
}
