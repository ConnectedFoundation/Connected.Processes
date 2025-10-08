using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class Insert(IProcessService processes, IStorageProvider storage, IEventService events)
	: ServiceFunction<IInsertProcessDto, int>
{
	protected override async Task<int> OnInvoke()
	{
		var result = await storage.Open<Process>().Update(Dto.AsEntity<Process>(State.Add)) ?? throw new NullReferenceException(Strings.ErrEntityExpected);

		await events.Inserted(this, processes, result.Id);

		return result.Id;
	}
}
