using Connected.Annotations;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States;

[Service, ServiceUrl(Urls.States)]
public interface IStateService
{
	Task<ImmutableList<IStateAction>> QueryActions(IPrimaryKeyDto<long> dto);
	Task<ImmutableList<IStateProperty>> QueryProperties(IPrimaryKeyDto<long> dto);
}
