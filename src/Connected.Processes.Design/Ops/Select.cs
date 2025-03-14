using Connected.Entities;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class Select(IStorageProvider storage, IProcessCache cache)
	: ServiceFunction<IPrimaryKeyDto<int>, IProcess?>
{
	protected override async Task<IProcess?> OnInvoke()
	{
		return await cache.Get(Dto.Id, async (f) =>
		{
			return await storage.Open<Process>().AsEntity(f => f.Id == Dto.Id);
		});
	}
}
