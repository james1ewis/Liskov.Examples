using Liskov.Examples.Collections.Model;
using NUnit.Framework;

namespace Liskov.ModelTests
{
	[TestFixture]
	public class IndexedListTests
	{
		[Test]
		public void should_be_able_to_get_an_item_using_an_index()
		{
			var sut = new IndexedList<ShopItem>();
			
			var item = new ShopItem { Id = 1, Name = "Megaphone", Price = 200m }; 
			
			sut.Add(item);

			var result = sut.GetItem(0);

			Assert.That(result, Is.EqualTo(item));
		}
	}
}
