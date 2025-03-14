using Connected.Annotations;
using Connected.Annotations.Entities;
using Connected.Entities;

namespace Connected.Processes.Design;

[Table(Schema = SchemaAttribute.CommonSchema)]
internal sealed record Process : Entity<int>, IProcess
{
	[Ordinal(0), Length(128)]
	public required string Code { get; init; }

	[Ordinal(1), Length(128)]
	public required string Name { get; init; }

	[Ordinal(2), Length(1024)]
	public string? Description { get; init; }

	[Ordinal(0)]
	public Status Status { get; init; }
}
