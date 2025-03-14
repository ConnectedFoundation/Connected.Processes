using Connected.Processes.Design.Dtos;
using Connected.Processes.Design.Ops;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design;

internal sealed class ProcessService(IServiceProvider services) : Service(services), IProcessService
{
	public async Task Delete(IPrimaryKeyDto<int> dto)
	{
		await Invoke(GetOperation<Delete>(), dto);
	}

	public async Task<int> Insert(IInsertProcessDto dto)
	{
		return await Invoke(GetOperation<Insert>(), dto);
	}

	public async Task<ImmutableList<IProcess>> Query(IQueryDto? dto)
	{
		return await Invoke(GetOperation<Query>(), dto ?? QueryDto.NoPaging);
	}

	public async Task<IProcess?> Select(IPrimaryKeyDto<int> dto)
	{
		return await Invoke(GetOperation<Select>(), dto);
	}

	public async Task Update(IUpdateProcessDto dto)
	{
		await Invoke(GetOperation<Update>(), dto);
	}
}
