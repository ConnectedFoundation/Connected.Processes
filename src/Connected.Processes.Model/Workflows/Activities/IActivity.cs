using Connected.Entities;

namespace Connected.Processes.Workflows.Activities;

public enum ActivityStatus
{
	Pending = 1,
	Active = 2,
	Complete = 3
}
public interface IActivity : IEntity<int>
{
	int Workflow { get; init; }
	int? Operation { get; init; }
	int Index { get; init; }
	ActivityStatus Status { get; init; }
}
