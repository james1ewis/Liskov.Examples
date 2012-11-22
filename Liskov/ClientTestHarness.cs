using Liskov.Examples.Collections.Model;
using NUnit.Framework;

namespace Liskov
{
	[TestFixture]
    public class ClientTestHarness
    {
		[Test]
		public void client_test_harness()
		{
			//var basket = new SimpleList<ShopItem>();
			//var basket = new IndexedList<ShopItem>();
			var basket = new DistinctList<ShopItem>();

			var client = new Client(basket);

			var item1 = new ShopItem {Id = 1, Name = "Megaphone", Price = 200m};
			var item2 = new ShopItem {Id = 2, Name = "Trumpet", Price = 20m};
			var item3 = new ShopItem {Id = 3, Name = "Telescope", Price = 3200m};
			
			ShopItem[] purchases = {item1, item1, item1, item2, item3, item3};

			client.AddAllPurchasesToBasket(purchases);

			Assert.That(basket.Count(), Is.EqualTo(6));
		}
    }
}
