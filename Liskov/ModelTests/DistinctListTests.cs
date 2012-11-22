using Liskov.Examples.Collections.Model;
using NUnit.Framework;

namespace Liskov.ModelTests
{
	[TestFixture]
	public class DistinctListTests
	{
		[Test]
		public void should_not_add_the_same_item_twice()
		{
			var sut = new DistinctList<ShopItem>();

			var item = new ShopItem { Id = 1, Name = "Megaphone", Price = 200m };

			sut.Add(item);
			sut.Add(item);

			Assert.That(sut.Count(), Is.EqualTo(1));
		}
	}
}
