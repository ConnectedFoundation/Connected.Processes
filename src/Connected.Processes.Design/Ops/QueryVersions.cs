using Connected.Entities;
using Connected.Services;
using Connected.Storage;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Ops;

internal sealed class QueryVersions(IStorageProvider storage)
	: ServiceFunction<IHeadDto<int>, ImmutableList<IProcessVersion>>
{
	protected override async Task<ImmutableList<IProcessVersion>> OnInvoke()
	{
		return await storage.Open<ProcessVersion>().AsEntities<IProcessVersion>(f => f.Process == Dto.Head);
	}
}
