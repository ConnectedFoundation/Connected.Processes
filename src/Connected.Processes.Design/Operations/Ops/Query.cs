using Connected.Entities;
using Connected.Services;
using Connected.Storage;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Operations.Ops;

internal sealed class Query(IStorageProvider storage)
	: ServiceFunction<IHeadDto<int>, ImmutableList<IOperation>>
{
	protected override async Task<ImmutableList<IOperation>> OnInvoke()
	{
		return await storage.Open<Operation>().AsEntities<IOperation>(f => f.Version == Dto.Head);
	}
}
