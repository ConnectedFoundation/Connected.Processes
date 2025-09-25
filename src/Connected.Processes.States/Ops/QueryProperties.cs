using Connected.Processes.Extensions.States;
using Connected.Processes.States.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States.Ops;
internal sealed class QueryProperties(IMiddlewareService middlewares)
	: ServiceFunction<IEntityDto, ImmutableList<IStateProperty>>
{
	protected override async Task<ImmutableList<IStateProperty>> OnInvoke()
	{
		var items = await middlewares.Query<IStatePropertyProvider>();
		var dto = Dto.Create<IStatePropertyDto>();

		dto.Entity = Dto.Entity;
		dto.EntityId = Dto.EntityId;

		foreach (var item in items)
			await item.Invoke(dto);

		return [.. dto.Items];
	}
}
