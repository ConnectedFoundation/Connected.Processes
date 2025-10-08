using Connected.Services;

namespace Connected.Processes.Design.Dtos;

public interface IProcessVersionDto : IDto
{
	string Name { get; set; }
	VersionStatus Status { get; set; }
}
