using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Ops;

internal sealed class InsertVersion(IProcessVersionService versions, IStorageProvider storage, IEventService events, IProcessVersionCache cache)
	: ServiceFunction<IInsertProcessVersionDto, int>
{
	protected override async Task<int> OnInvoke()
	{
		var result = await storage.Open<ProcessVersion>().Update(Dto.AsEntity<ProcessVersion>(State.Add)) ?? throw new NullReferenceException(Strings.ErrEntityExpected);

		await events.Inserted(this, versions, result.Id);

		return result.Id;
	}
}
