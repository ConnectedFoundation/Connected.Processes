using Connected.Services;

namespace Connected.Processes.Workflows.Consumptions.Dtos;
public interface IUpdateConsumptionDto : IPrimaryKeyDto<long>
{
	double Quantity { get; init; }
}
