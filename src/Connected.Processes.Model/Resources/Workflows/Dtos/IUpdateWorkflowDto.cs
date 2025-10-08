using Connected.Entities;
using Connected.Services;

namespace Connected.Processes.Workflows.Dtos;
public interface IUpdateWorkflowDto : IPrimaryKeyDto<int>
{
	Status Status { get; set; }
}
