namespace Connected.Processes.Design.Dtos;

public interface IInsertProcessVersionDto : IProcessVersionDto
{
	int Process { get; set; }
}
