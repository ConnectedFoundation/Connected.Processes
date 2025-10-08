using Connected.Entities;

namespace Connected.Processes.States;
public record StateAction : Entity<string>, IStateAction
{
	public StateAction(string id, string text)
	{
		Id = id;
		Text = text;
	}
	public string Text { get; init; }
}
