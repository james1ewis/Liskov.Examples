namespace Liskov.Examples.Tasks.Model
{
	public class Task
	{
		public TaskStatus Status { get; set; }

		public virtual void Start()
		{
			Status = TaskStatus.Started;
		}

		public virtual void Close()
		{
			Status = TaskStatus.Closed;
		}
	}
}
