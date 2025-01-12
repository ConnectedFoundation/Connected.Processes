using Connected.Entities;

namespace Connected.Processes.Design.Operations;

public enum ActivationBehavior
{
	Manual = 1,
	ParentCompletion = 2
}

public enum CompletionBehavior
{
	Auto = 1,
	Manual = 2
}

public interface IOperation : IEntity<int>
{
	int Version { get; init; }
	int Parent { get; init; }
	string Code { get; init; }
	string Name { get; init; }
	string Description { get; init; }
	int Index { get; init; }
	ActivationBehavior Activation { get; init; }
	CompletionBehavior Completion { get; init; }
}
