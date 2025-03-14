using Connected.Services;
using System.ComponentModel.DataAnnotations;

namespace Connected.Processes.Design.Dtos;

internal class ProcessVersionDto : Dto, IProcessVersionDto
{
	[Required, MaxLength(128)]
	public required string Name { get; set; }

	public VersionStatus Status { get; set; } = VersionStatus.Design;
}
