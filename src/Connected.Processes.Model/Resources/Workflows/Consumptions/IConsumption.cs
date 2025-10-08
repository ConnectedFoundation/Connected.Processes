using Connected.Entities;

namespace Connected.Processes.Workflows.Consumptions;
public interface IConsumption : IEntityContainer<long>
{
	int Activity { get; init; }
	int? Input { get; init; }
	double Quantity { get; init; }
}
