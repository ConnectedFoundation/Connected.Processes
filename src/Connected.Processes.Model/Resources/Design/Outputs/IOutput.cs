using Connected.Entities;

namespace Connected.Processes.Design.Outputs;

public enum OutputType
{
	EndProduct = 1,
	SemiProduct = 2
}
public interface IOutput : IEntityContainer<int>
{
	int Operation { get; init; }
	double Quantity { get; init; }
	OutputType Type { get; init; }
}
