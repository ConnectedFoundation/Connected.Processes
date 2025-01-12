using Connected.Entities;

namespace Connected.Processes.Design;

public enum VersionStatus
{
	Design = 1,
	Valid = 2,
	Archive = 3
}
public interface IProcessVersion : IEntity<int>
{
	int Process { get; init; }
	string Name { get; init; }
	VersionStatus Status { get; init; }
}
