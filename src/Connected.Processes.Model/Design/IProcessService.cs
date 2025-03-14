using Connected.Annotations;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design;

[Service, ServiceUrl(ProcessesUrls.Processes)]
public interface IProcessService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<int> Insert(IInsertProcessDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateProcessDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<IProcess?> Select(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<ImmutableList<IProcess>> Query(IQueryDto? dto);
}
