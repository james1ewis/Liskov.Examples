using Liskov.Examples.Tasks.Model;
using NUnit.Framework;

namespace Liskov.Examples.Tasks.ModelTests
{
	[TestFixture]
	public class TaskTests
	{
		[Test]
		public void should_be_able_to_close_a_task()
		{
			var sut = new Task();

			sut.Close();

			Assert.That(sut.Status, Is.EqualTo(TaskStatus.Closed));
		}
	}
}
