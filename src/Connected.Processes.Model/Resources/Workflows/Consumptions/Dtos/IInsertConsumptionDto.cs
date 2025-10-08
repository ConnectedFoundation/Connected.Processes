using Connected.Services;

namespace Connected.Processes.Workflows.Consumptions.Dtos;
public interface IInsertConsumptionDto : IEntityDto
{
	int Activity { get; init; }
	int? Input { get; init; }
	double Quantity { get; init; }

}
