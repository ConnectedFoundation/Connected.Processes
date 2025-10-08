using Connected.Caching;

namespace Connected.Processes.Design;

internal sealed class ProcessCache(ICachingService cachingService)
	: CacheContainer<Process, int>(cachingService, ProcessesMetaData.ProcessKey), IProcessCache
{
}
