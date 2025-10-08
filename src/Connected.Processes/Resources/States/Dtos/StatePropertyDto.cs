using Connected.Annotations;
using Connected.Services;

namespace Connected.Processes.States.Dtos;
internal sealed class StatePropertyDto : EntityDto, IStatePropertyDto
{
	[NonDefault]
	public List<IStateProperty> Items { get; set; } = [];
}
