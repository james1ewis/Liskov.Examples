using Liskov.Examples.Collections.Model;

namespace Liskov
{
	public class Client
	{
		private readonly SimpleList<ShopItem> _basket;
		
		public Client(SimpleList<ShopItem> basket)
		{
			_basket = basket;
		}

		public void AddAllPurchasesToBasket(ShopItem[] purchases)
		{
			if ((_basket as DistinctList<ShopItem>) != null)
				DistinctListHack(purchases);

			for (int itemCount = 0; itemCount < purchases.Length; itemCount++)
			{
				_basket.Add(purchases[itemCount]);
			}
		}

		private void DistinctListHack(ShopItem[] purchases)
		{
			for (int itemCount = 0; itemCount < purchases.Length; itemCount++)
			{
				var item = purchases[itemCount];
				item.Id += itemCount;
				_basket.Add(item);
			}			
		}
	}
}
