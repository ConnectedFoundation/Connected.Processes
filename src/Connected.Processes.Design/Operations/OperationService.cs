using Connected.Processes.Design.Operations.Dtos;
using Connected.Processes.Design.Operations.Ops;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Operations;

internal sealed class OperationService(IServiceProvider services)
	: Service(services), IOperationService
{
	public async Task Delete(IPrimaryKeyDto<int> dto)
	{
		await Invoke(GetOperation<Delete>(), dto);
	}

	public async Task<int> Insert(IInsertOperationDto dto)
	{
		return await Invoke(GetOperation<Insert>(), dto);
	}

	public async Task<ImmutableList<IOperation>> Query(IHeadDto<int> dto)
	{
		return await Invoke(GetOperation<Query>(), dto);
	}

	public async Task<IOperation?> Select(IPrimaryKeyDto<int> dto)
	{
		return await Invoke(GetOperation<Select>(), dto);
	}

	public async Task Update(IUpdateOperationDto dto)
	{
		await Invoke(GetOperation<Update>(), dto);
	}
}
