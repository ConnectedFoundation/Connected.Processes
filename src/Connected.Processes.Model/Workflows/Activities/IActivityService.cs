using Connected.Annotations;
using Connected.Processes.Workflows.Activities.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Workflows.Activities;

[Service, ServiceUrl(ProcessesUrls.Activities)]
public interface IActivityService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<long> Insert(IInsertActivityDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateActivityDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<IActivity?> Select(IPrimaryKeyDto<long> dto);

	[ServiceOperation(ServiceOperationVerbs.Post | ServiceOperationVerbs.Get)]
	Task<ImmutableList<IActivity>> Query(IHeadDto<int> dto);
}
