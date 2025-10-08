using Connected.Entities;

namespace Connected.Processes.Design.Inputs;
public interface IInput : IEntityContainer<int>
{
	int Operation { get; init; }
	double Quantity { get; init; }
}
