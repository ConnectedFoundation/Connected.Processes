using Connected.Entities;
using Connected.Services;

namespace Connected.Processes.Design.Dtos;

public interface IProcessDto : IDto
{
	string Code { get; set; }
	string Name { get; set; }
	string? Description { get; set; }
	Status Status { get; set; }
}
