using Connected.Annotations;
using Connected.Processes.Workflows.Consumptions.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Workflows.Consumptions;

[Service, ServiceUrl(ProcessesUrls.Consumptions)]
public interface IConsumptionService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<long> Insert(IInsertConsumptionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateConsumptionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<IConsumption?> Select(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<ImmutableList<IConsumption>> Query(IHeadDto<int> dto);
}
