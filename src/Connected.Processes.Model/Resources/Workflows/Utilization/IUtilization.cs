using Connected.Entities;

namespace Connected.Processes.Workflows.Utilization;
public interface IUtilization : IEntityContainer<long>
{
	int Activity { get; init; }
	/// <summary>
	/// The designed resource. It's not necessary that utilizization
	/// strictly follows operation. If that's not the case, this property
	/// won't be set but the Entity & EntityId properties are set in any
	/// case even if this property has value.
	/// </summary>
	int? Resource { get; init; }
	/// <summary>
	/// The actual resource used.
	/// </summary>
	double Quantity { get; init; }
}
