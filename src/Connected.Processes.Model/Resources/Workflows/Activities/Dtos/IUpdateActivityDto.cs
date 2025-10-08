using Connected.Services;

namespace Connected.Processes.Workflows.Activities.Dtos;
public interface IUpdateActivityDto : IPrimaryKeyDto<long>
{
	ActivityStatus Status { get; set; }
}
