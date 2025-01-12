using Connected.Entities;

namespace Connected.Processes.Workflows.Activities;
public interface IActivityLog : IEntity<long>
{
	int Activity { get; init; }
	ActivityStatus Status { get; init; }
	DateTimeOffset Created { get; init; }
	string? Description { get; init; }
}
