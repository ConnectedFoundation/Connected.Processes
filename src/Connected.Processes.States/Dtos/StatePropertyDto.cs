using Connected.Annotations;
using Connected.Services;

namespace Connected.Processes.States.Dtos;
internal sealed class StatePropertyDto : Dto, IStatePropertyDto
{
	[MinValue(1)]
	public long Activity { get; set; }

	[NonDefault]
	public List<IStateProperty> Items { get; set; } = [];
}
