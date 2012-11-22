namespace Liskov.Examples.Collections.Model
{
	public class IndexedList<T> : SimpleList<T>
	{
		public T GetItem(int index)
		{
			return _anActualList[index];
		}
	}
}
