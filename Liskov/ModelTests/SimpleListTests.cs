using Liskov.Examples.Collections.Model;
using NUnit.Framework;

namespace Liskov.ModelTests
{
	[TestFixture]
	public class SimpleListTests
	{
		[Test]
		public void should_be_able_to_add_items_to_the_list()
		{
			var sut = new SimpleList<ShopItem>();

			var item1 = new ShopItem {Id = 1, Name = "Megaphone", Price = 200m};

			sut.Add(item1);
			sut.Add(item1);
			sut.Add(item1);

			Assert.That(sut.Count(), Is.EqualTo(3));
		}
	}
}
