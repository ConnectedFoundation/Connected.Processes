using Connected.Entities;
using Connected.Notifications;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Operations.Ops;

internal sealed class Delete(IOperationService operations, IStorageProvider storage, IEventService events, IOperationCache cache)
	: ServiceAction<IPrimaryKeyDto<int>>
{
	protected override async Task OnInvoke()
	{
		SetState(await operations.Select(Dto));

		await storage.Open<Operation>().Update(Dto.AsEntity<Operation>(State.Delete));
		await cache.Remove(Dto.Id);
		await events.Deleted(this, operations, Dto.Id);
	}
}
