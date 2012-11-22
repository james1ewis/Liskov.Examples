using Liskov.Examples.Tasks.Model;
using NUnit.Framework;

namespace Liskov.Examples.Tasks.ModelTests
{
	[TestFixture]
	public class ProjectTaskTests
	{
		[Test]
		public void should_not_be_able_to_close_a_projectTask_once_started()
		{
			var sut = new ProjectTask();

			sut.Start();

			sut.Close();

			Assert.That(sut.Status, Is.EqualTo(TaskStatus.Started));
		}
	}
}
