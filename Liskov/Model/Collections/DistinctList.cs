namespace Liskov.Examples.Collections.Model
{
	public class DistinctList<T> : SimpleList<T>
	{
		public override void Add(T item)
		{
			if (TheItemAlreadyExists(item))
				return;

			base.Add(item);
		}

		private bool TheItemAlreadyExists(T item)
		{
			return _anActualList.Contains(item);
		}
	}
}
