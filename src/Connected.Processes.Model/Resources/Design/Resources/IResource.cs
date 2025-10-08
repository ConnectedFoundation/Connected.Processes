using Connected.Entities;

namespace Connected.Processes.Design.Resources;

public enum ResourceType
{
	Human = 1,
	NonHuman = 2,
	JobPosition = 3,
	Competence = 4
}

public interface IResource : IEntity<int>
{
	int Operation { get; init; }
	int? Resource { get; init; }
	ResourceType Type { get; init; }
	double Quantity { get; init; }
	bool Mandatory { get; init; }
}
