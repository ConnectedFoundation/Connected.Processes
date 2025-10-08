using Connected.Entities;

namespace Connected.Processes.States;
public interface IStateProperty : IEntity<string>
{
	string Text { get; init; }
}
