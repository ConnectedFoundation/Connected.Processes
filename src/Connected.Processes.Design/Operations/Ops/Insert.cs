using Connected.Entities;
using Connected.Notifications;
using Connected.Processes.Design.Operations.Dtos;
using Connected.Services;
using Connected.Storage;

namespace Connected.Processes.Design.Operations.Ops;

internal sealed class Insert(IOperationService operations, IStorageProvider storage, IEventService events)
	: ServiceFunction<IInsertOperationDto, int>
{
	protected override async Task<int> OnInvoke()
	{
		var result = await storage.Open<Operation>().Update(Dto.AsEntity<Operation>(State.New)) ?? throw new NullReferenceException(Strings.ErrEntityExpected);

		await events.Inserted(this, operations, result.Id);

		return result.Id;
	}
}
