namespace Connected.Processes;
public static class ProcessesUrls
{
	private const string Namespace = "/services/processes";

	public const string Processes = $"{Namespace}/processes";
	public const string ProcessVersions = $"{Namespace}/versions";
	public const string Operations = $"{Namespace}/operations";
	public const string Workflows = $"{Namespace}/workflows";
	public const string Activities = $"{Namespace}/activities";
	public const string Consumptions = $"{Namespace}/consumptions";
	public const string Production = $"{Namespace}/production";
	public const string Utilization = $"{Namespace}/utilization";
	public const string States = $"{Namespace}/states";
}
