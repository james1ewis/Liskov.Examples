using System.Collections.Generic;
using Liskov.Examples.Tasks.Model;

namespace Liskov.Examples.Tasks
{
	public static class TaskManager
	{
		public static void CloseAllTasks(IEnumerable<Task> tasks)
		{
			foreach (var task in tasks)
				task.Close();
		}
	}
}
