using Connected.Caching;

namespace Connected.Processes.Design.Operations;

internal sealed class OperationCache(ICachingService cachingService)
	: CacheContainer<Operation, int>(cachingService, ProcessesMetaData.OperationKey), IOperationCache
{
}
