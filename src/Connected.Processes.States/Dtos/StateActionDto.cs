using Connected.Annotations;
using Connected.Services;

namespace Connected.Processes.States.Dtos;
internal sealed class StateActionDto : EntityDto, IStateActionDto
{
	[NonDefault]
	public List<IStateAction> Items { get; set; } = [];
}
