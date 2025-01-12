using Connected.Annotations;
using Connected.Services;

namespace Connected.Processes.States.Dtos;
internal sealed class StateActionDto : Dto, IStateActionDto
{
	[MinValue(1)]
	public long Activity { get; set; }

	[NonDefault]
	public List<IStateAction> Items { get; set; } = [];
}
