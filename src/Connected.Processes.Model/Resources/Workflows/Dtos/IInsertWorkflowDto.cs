using Connected.Entities;
using Connected.Services;

namespace Connected.Processes.Workflows.Dtos;
public interface IInsertWorkflowDto : IDto
{
	int Version { get; set; }
	Status Status { get; set; }
}
