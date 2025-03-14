using Connected.Annotations;
using Connected.Processes.Workflows.Consumptions.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Workflows.Production;

[Service, ServiceUrl(ProcessesUrls.Production)]
public interface IProductionService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<long> Insert(IInsertProductionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateProductionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<IProduction?> Select(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<ImmutableList<IProduction>> Query(IHeadDto<int> dto);
}
