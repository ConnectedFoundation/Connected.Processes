using Connected.Entities;
using Connected.Notifications;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class Delete(IProcessService processes, IStorageProvider storage, IEventService events, IProcessCache cache)
	: ServiceAction<IPrimaryKeyDto<int>>
{
	protected override async Task OnInvoke()
	{
		SetState(await processes.Select(Dto));

		await storage.Open<Process>().Update(Dto.AsEntity<Process>(State.Deleted));
		await cache.Remove(Dto.Id);
		await events.Deleted(this, processes, Dto.Id);
	}
}
