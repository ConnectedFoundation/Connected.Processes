using Connected.Entities;
using Connected.Services;
using Connected.Storage;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Ops;

internal sealed class QueryVersions(IStorageProvider storage)
	: ServiceFunction<IHeadDto<int>, IImmutableList<IProcessVersion>>
{
	protected override async Task<IImmutableList<IProcessVersion>> OnInvoke()
	{
		return await storage.Open<ProcessVersion>().AsEntities<IProcessVersion>(f => f.Process == Dto.Head);
	}
}
