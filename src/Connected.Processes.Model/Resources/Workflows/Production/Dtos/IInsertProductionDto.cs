using Connected.Services;

namespace Connected.Processes.Workflows.Consumptions.Dtos;
public interface IInsertProductionDto : IEntityDto
{
	int Activity { get; init; }
	int Output { get; init; }
	double Quantity { get; init; }

}
