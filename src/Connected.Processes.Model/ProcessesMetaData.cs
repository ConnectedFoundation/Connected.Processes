using Connected.Annotations.Entities;
using Connected.Processes.Design;
using Connected.Processes.Design.Operations;

namespace Connected.Processes;

public static class ProcessesMetaData
{
	public const string ProcessKey = $"{SchemaAttribute.CommonSchema}.{nameof(IProcess)}";
	public const string ProcessVersionKey = $"{SchemaAttribute.CommonSchema}.{nameof(IProcessVersion)}";
	public const string OperationKey = $"{SchemaAttribute.CommonSchema}.{nameof(IOperation)}";
}
