using Connected.Annotations;
using Connected.Processes.Workflows.Dtos;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.Workflows;

[Service, ServiceUrl(Urls.Workflows)]
public interface IWorkflowService
{
	[ServiceOperation(ServiceOperationVerbs.Put)]
	Task<int> Insert(IInsertWorkflowDto dto);

	[ServiceOperation(ServiceOperationVerbs.Post)]
	Task Update(IUpdateWorkflowDto dto);

	[ServiceOperation(ServiceOperationVerbs.Delete)]
	Task Delete(IPrimaryKeyDto<int> dto);

	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<IWorkflow?> Select(IPrimaryKeyDto<int> dto);
	/// <summary>
	/// Returns a list of <see cref="IWorkflow"> entites for the specified <see cref="Design.IProcessVersion">.
	/// </summary>
	/// <param name="dto"></param>
	/// <returns></returns>
	[ServiceOperation(ServiceOperationVerbs.Get | ServiceOperationVerbs.Post)]
	Task<ImmutableList<IWorkflow>> Query(IValueDto<int> dto);
}
