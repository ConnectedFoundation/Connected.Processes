using Connected.Entities;
using Connected.Services;
using Connected.Storage;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Ops;

internal sealed class Query(IStorageProvider storage)
	: ServiceFunction<IQueryDto, IImmutableList<IProcess>>
{
	protected override async Task<IImmutableList<IProcess>> OnInvoke()
	{
		return await storage.Open<Process>().WithDto(Dto).AsEntities<IProcess>();
	}
}
