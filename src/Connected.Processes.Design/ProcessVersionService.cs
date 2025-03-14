using Connected.Processes.Design.Dtos;
using Connected.Processes.Design.Ops;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design;

internal sealed class ProcessVersionService(IServiceProvider services) : Service(services), IProcessVersionService
{
	public async Task Delete(IPrimaryKeyDto<int> dto)
	{
		await Invoke(GetOperation<DeleteVersion>(), dto);
	}

	public async Task<int> Insert(IInsertProcessVersionDto dto)
	{
		return await Invoke(GetOperation<InsertVersion>(), dto);
	}

	public async Task<ImmutableList<IProcessVersion>> Query(IHeadDto<int> dto)
	{
		return await Invoke(GetOperation<QueryVersions>(), dto);
	}

	public async Task<IProcessVersion?> Select(IPrimaryKeyDto<int> dto)
	{
		return await Invoke(GetOperation<SelectVersion>(), dto);
	}

	public async Task Update(IUpdateProcessVersionDto dto)
	{
		await Invoke(GetOperation<UpdateVersion>(), dto);
	}
}
