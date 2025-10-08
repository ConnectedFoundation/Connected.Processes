using Connected.Services;

namespace Connected.Processes.Workflows.Utilization.Dtos;
public interface IInsertUtilizationDto : IEntityDto
{
	int Activity { get; set; }
	int? Resource { get; set; }
	double Quantity { get; set; }
}
