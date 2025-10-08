using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Operations.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Operations.Ops;

internal sealed class Update(IOperationService operations, IStorageProvider storage, IEventService events, IOperationCache cache)
	: ServiceAction<IUpdateOperationDto>
{
	protected override async Task OnInvoke()
	{
		SetState(await operations.Select(Dto));

		await storage.Open<Operation>().Update(Dto.AsEntity<Operation>(State.Update), Dto, async () =>
		{
			await cache.Remove(Dto.Id);

			return SetState(await operations.Select(Dto)) as Operation;
		}, Caller);

		await events.Updated(this, operations, Dto.Id);
	}
}
