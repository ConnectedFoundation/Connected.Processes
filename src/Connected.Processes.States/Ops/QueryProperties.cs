using Connected.Processes.Extensions.States;
using Connected.Processes.States.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States.Ops;
internal sealed class QueryProperties(IMiddlewareService middlewares)
	: ServiceFunction<IPrimaryKeyDto<long>, ImmutableList<IStateProperty>>
{
	protected override async Task<ImmutableList<IStateProperty>> OnInvoke()
	{
		var items = await middlewares.Query<IStatePropertyProvider>();
		var dto = Dto.Create<IStatePropertyDto>();

		dto.Activity = Dto.Id;

		foreach (var item in items)
			await item.Invoke(dto);

		return [.. dto.Items];
	}
}
