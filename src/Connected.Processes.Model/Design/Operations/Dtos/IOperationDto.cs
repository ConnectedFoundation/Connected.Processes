using Connected.Services;

namespace Connected.Processes.Design.Operations.Dtos;

public interface IOperationDto : IDto
{
	int Parent { get; set; }
	string Code { get; set; }
	string Name { get; set; }
	string? Description { get; set; }
	int Index { get; set; }
	ActivationBehavior Activation { get; set; }
	CompletionBehavior Completion { get; set; }
}
