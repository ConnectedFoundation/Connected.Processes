using Connected.Services;

namespace Connected.Processes.Workflows.Consumptions.Dtos;
public interface IUpdateProductionDto : IPrimaryKeyDto<long>
{
	double Quantity { get; init; }
}
