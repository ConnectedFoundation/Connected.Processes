using Connected.Entities;

namespace Connected.Processes.Workflows;

public enum WorkflowStatus
{
	Pending = 1,
	Active = 2,
	Complete = 3
}

public interface IWorkflow : IEntity<int>
{
	int Version { get; init; }
	Status Status { get; init; }
}
