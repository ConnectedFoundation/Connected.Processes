using Connected.Annotations;
using Connected.Processes.Design.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design;

[Service, ServiceUrl(ProcessesUrls.ProcessVersions)]
public interface IProcessVersionService
{

	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<int> Insert(IInsertProcessVersionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateProcessVersionDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<IProcessVersion?> Select(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<ImmutableList<IProcessVersion>> Query(IHeadDto<int> dto);
}
