using Connected.Entities;

namespace Connected.Processes.States;
public interface IStateAction : IEntity<string>
{
	string Text { get; init; }
}
