using Connected.Entities;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class SelectVersion(IStorageProvider storage, IProcessVersionCache cache)
	: ServiceFunction<IPrimaryKeyDto<int>, IProcessVersion?>
{
	protected override async Task<IProcessVersion?> OnInvoke()
	{
		return await cache.Get(Dto.Id, async (f) =>
		{
			return await storage.Open<ProcessVersion>().AsEntity(f => f.Id == Dto.Id);
		});
	}
}
