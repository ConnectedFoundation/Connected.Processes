using Connected.Services;

namespace Connected.Processes.Workflows.Utilization.Dtos;
public interface IUpdateUtilizationDto : IPrimaryKeyDto<long>
{
	double Quantity { get; set; }
}
