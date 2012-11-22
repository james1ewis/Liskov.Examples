using System.Collections.Generic;

namespace Liskov.Examples.Collections.Model
{
	public class SimpleList<T>
	{
		protected List<T> _anActualList = new List<T>();

		public virtual void Add(T item)
		{
			_anActualList.Add(item);
		}

		public List<T>.Enumerator GetEnumerator()
		{
			return _anActualList.GetEnumerator();
		}

		public int Count()
		{
			return _anActualList.Count;
		}
	}
}
