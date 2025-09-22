using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class Update(IProcessService processes, IStorageProvider storage, IEventService events, IProcessCache cache)
	: ServiceAction<IUpdateProcessDto>
{
	protected override async Task OnInvoke()
	{
		SetState(await processes.Select(Dto));

		await storage.Open<Process>().Update(Dto.AsEntity<Process>(State.Update), Dto, async () =>
		{
			await cache.Remove(Dto.Id);

			return SetState(await processes.Select(Dto)) as Process;
		}, Caller);

		await events.Updated(this, processes, Dto.Id);
	}
}
