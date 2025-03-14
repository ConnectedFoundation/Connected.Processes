using Connected.Annotations;
using Connected.Annotations.Entities;
using Connected.Entities;

namespace Connected.Processes.Design;

internal sealed record ProcessVersion : Entity<int>, IProcessVersion
{
	[Ordinal(0)]
	public int Process { get; init; }

	[Ordinal(1), Length(128)]
	public required string Name { get; init; }

	[Ordinal(2)]
	public VersionStatus Status { get; init; }
}
