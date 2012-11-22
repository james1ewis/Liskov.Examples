namespace Liskov.Examples.Tasks.Model
{
	public class ProjectTask : Task
	{
		public override void Close()
		{
			if (TheTaskHasBeenStarted())
				return;

			base.Close();
		}

		private bool TheTaskHasBeenStarted()
		{
			return Status == TaskStatus.Started;
		}
	}
}
