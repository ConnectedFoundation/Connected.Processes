using Connected.Services;

namespace Connected.Processes.Workflows.Activities.Dtos;
public interface IInsertActivityDto : IDto
{
	int Workflow { get; set; }
	int Operation { get; set; }
	ActivityStatus Status { get; set; }
}
