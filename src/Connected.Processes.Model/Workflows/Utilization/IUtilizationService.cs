using Connected.Annotations;
using Connected.Processes.Workflows.Utilization.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Workflows.Utilization;

[Service, ServiceUrl(Urls.Utilization)]
public interface IUtilizationService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<long> Insert(IInsertUtilizationDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateUtilizationDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<IUtilization?> Select(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<ImmutableList<IUtilization>> Query(IHeadDto<int> dto);
}
