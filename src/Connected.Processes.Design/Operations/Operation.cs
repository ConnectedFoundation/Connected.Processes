using Connected.Annotations;
using Connected.Annotations.Entities;
using Connected.Entities;

namespace Connected.Processes.Design.Operations;

internal sealed record Operation : Entity<int>, IOperation
{
	[Ordinal(0)]
	[Index(false, $"idx_{ProcessesMetaData.OperationKey}_version")]
	public int Version { get; init; }

	[Ordinal(1)]
	public int Parent { get; init; }

	[Ordinal(2), Length(128)]
	public required string Code { get; init; }

	[Ordinal(3), Length(128)]
	public required string Name { get; init; }

	[Ordinal(4), Length(1024)]
	public string? Description { get; init; }

	[Ordinal(5)]
	public int Index { get; init; }

	[Ordinal(6)]
	public ActivationBehavior Activation { get; init; }

	[Ordinal(7)]
	public CompletionBehavior Completion { get; init; }
}
