using Connected.Caching;

namespace Connected.Processes.Design;

internal sealed class ProcessVersionCache(ICachingService cachingService)
	: CacheContainer<ProcessVersion, int>(cachingService, ProcessesMetaData.ProcessVersionKey), IProcessVersionCache
{
}
