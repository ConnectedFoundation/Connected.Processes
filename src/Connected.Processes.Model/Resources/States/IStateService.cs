using Connected.Annotations;
using Connected.Services;
using System.Collections.Immutable;

namespace Connected.Processes.States;

[Service, ServiceUrl(ProcessesUrls.States)]
public interface IStateService
{
	Task<ImmutableList<IStateAction>> QueryActions(IEntityDto dto);
	Task<ImmutableList<IStateProperty>> QueryProperties(IEntityDto dto);
}
