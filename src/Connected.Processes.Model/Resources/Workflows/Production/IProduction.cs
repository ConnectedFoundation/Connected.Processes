using Connected.Entities;

namespace Connected.Processes.Workflows.Production;
public interface IProduction : IEntity<long>
{
	int Activity { get; init; }
	int Output { get; init; }
	double Quantity { get; init; }
}
