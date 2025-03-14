using Connected.Annotations;
using Connected.Processes.Design.Operations.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Design.Operations;

[Service, ServiceUrl(ProcessesUrls.Operations)]
public interface IOperationService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<int> Insert(IInsertOperationDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateOperationDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<IOperation?> Select(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<ImmutableList<IOperation>> Query(IHeadDto<int> dto);
}
