using System.Collections.Generic;
using Liskov.Examples.Tasks.Model;
using NUnit.Framework;

namespace Liskov.Examples.Tasks
{
	[TestFixture]
    public class ClientTestHarness
    {
		[Test]
		public void client_test_harness()
		{
			var tasks = new List<Task>
				            {
								new Task(),
								new Task(),
								new Task(),
								new Task(),
								new Task()
				            };

			TaskManager.CloseAllTasks(tasks);

			foreach (var task in tasks)
			{
				Assert.That(task.Status, Is.EqualTo(TaskStatus.Closed));
			}
		}

		[Test]
		public void client_test_harness_problem()
		{
			var projectTask = new ProjectTask();
			projectTask.Start();

			var tasks = new List<Task>
				            {
								projectTask,
								new Task(),
								new Task(),
								new Task(),
								new Task()
				            };

			TaskManager.CloseAllTasks(tasks);

			foreach (var task in tasks)
			{
				Assert.That(task.Status, Is.EqualTo(TaskStatus.Closed));
			}
		}
    }
}
