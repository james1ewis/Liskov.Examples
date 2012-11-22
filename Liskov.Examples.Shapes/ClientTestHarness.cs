using Liskov.Examples.Shapes.Model;
using NUnit.Framework;

namespace Liskov.Examples.Shapes
{
	[TestFixture]
	public class ClientTestHarness
	{
		[Test]
		public void client_test_harness()
		{
			var client = new Client();

			var shape = new Rectangle { Height = 20, Width = 30 };
			//var shape = new Square {Height = 30, Width = 30};
			
			client.ShrinkByHeight(shape);

			Assert.That(shape.Width, Is.EqualTo(10));
		}
	}
}
