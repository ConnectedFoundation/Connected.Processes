using Connected.Processes.Extensions.States;
using Connected.Processes.States.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States.Ops;
internal sealed class QueryActions(IMiddlewareService middlewares)
	: ServiceFunction<IEntityDto, ImmutableList<IStateAction>>
{
	protected override async Task<ImmutableList<IStateAction>> OnInvoke()
	{
		var items = await middlewares.Query<IStateActionProvider>();
		var dto = Dto.Create<IStateActionDto>();

		dto.Entity = Dto.Entity;
		dto.EntityId = Dto.EntityId;

		foreach (var item in items)
			await item.Invoke(dto);

		return [.. dto.Items];
	}
}
