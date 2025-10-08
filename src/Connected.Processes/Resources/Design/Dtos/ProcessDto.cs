using Connected.Entities;
using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Processes.Design.Dtos;

internal class ProcessDto : Dto, IProcessDto
{
	[Required, MaxLength(128)]
	public required string Code { get; set; }

	[Required, MaxLength(128)]
	public required string Name { get; set; }

	[MaxLength(1024)]
	public string? Description { get; set; }

	public Status Status { get; set; } = Status.Disabled;
}
