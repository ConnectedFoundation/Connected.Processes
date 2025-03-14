using Connected.Entities;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Operations.Ops;

internal sealed class Select(IStorageProvider storage, IOperationCache cache)
	: ServiceFunction<IPrimaryKeyDto<int>, IOperation?>
{
	protected override async Task<IOperation?> OnInvoke()
	{
		return await cache.Get(Dto.Id, async (f) =>
		{
			return await storage.Open<Operation>().AsEntity(f => f.Id == Dto.Id);
		});
	}
}
