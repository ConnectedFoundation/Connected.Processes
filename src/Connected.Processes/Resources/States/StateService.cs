using Connected.Processes.States.Ops;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States;

internal sealed class StateService(IServiceProvider services)
	: Service(services), IStateService
{
	public async Task<ImmutableList<IStateAction>> QueryActions(IEntityDto dto)
	{
		return await Invoke(GetOperation<QueryActions>(), dto);
	}

	public async Task<ImmutableList<IStateProperty>> QueryProperties(IEntityDto dto)
	{
		return await Invoke(GetOperation<QueryProperties>(), dto);
	}
}
