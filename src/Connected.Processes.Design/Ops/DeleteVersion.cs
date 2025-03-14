using Connected.Entities;
using Connected.Notifications;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class DeleteVersion(IProcessVersionService versions, IStorageProvider storage, IEventService events, IProcessVersionCache cache)
	: ServiceAction<IPrimaryKeyDto<int>>
{
	protected override async Task OnInvoke()
	{
		SetState(await versions.Select(Dto));

		await storage.Open<ProcessVersion>().Update(Dto.AsEntity<ProcessVersion>(State.Deleted));
		await cache.Remove(Dto.Id);
		await events.Deleted(this, versions, Dto.Id);
	}
}
