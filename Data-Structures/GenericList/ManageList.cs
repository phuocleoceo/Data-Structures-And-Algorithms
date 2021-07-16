using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace GenericList
{
	public class ManageList<T>
	{
		private T[] data;
		private int size;
		public ManageList()
		{
			this.size = 0;
			this.data = null;
		}
		// Count Length of List
		public int Count
		{
			get { return size; }
		}
		// Get and Set data[index]
		public T this[int index]
		{
			get
			{
				if (index >= 0 && index < size)
					return data[index];
				else throw new IndexOutOfRangeException();
			}
			set
			{
				if (index >= 0 && index < size)
					data[index] = value;
				else throw new IndexOutOfRangeException();
			}
		}
		// Add a new Item to TailList
		public void Add(T item)
		{
			if (size == 0)
			{
				data = new T[size + 1];
				data[size] = item;
			}
			else
			{
				T[] temp = new T[size];
				for (int i = 0; i < size; i++)
				{
					temp[i] = data[i];
				}
				data = null;
				data = new T[size + 1];
				data[size] = item;
				for (int i = 0; i < size; i++)
				{
					data[i] = temp[i];
				}
			}
			size++;
		}

		// Return First Position of a Item, but It's wrong with Class Instance (Object)
		public int IndexOf(T item)
		{
			for (int i = 0; i < size; i++)
				if (Equals(data[i], item)) return i;
			return -1;
		}
		// Remove a Item, wrong because IndexOf is wrong
		public void Remove(T item)
		{
			int position = IndexOf(item);
			if (position != -1)
			{
				for (int i = position; i < size - 1; i++)
				{
					data[i] = data[i + 1];
				}
				T[] temp = new T[size - 1];
				for (int i = 0; i < size - 1; i++)
				{
					temp[i] = data[i];
				}
				data = null;
				data = new T[size - 1];
				for (int i = 0; i < size - 1; i++)
				{
					data[i] = temp[i];
				}
				size--;
			}
		}
		// Remove Item by Index
		public void RemoveAt(int position)
		{
			if (position >= 0 && position < size)
			{
				for (int i = position; i < size - 1; i++)
				{
					data[i] = data[i + 1];
				}
				T[] temp = new T[size - 1];
				for (int i = 0; i < size - 1; i++)
				{
					temp[i] = data[i];
				}
				data = null;
				data = new T[size - 1];
				for (int i = 0; i < size - 1; i++)
				{
					data[i] = temp[i];
				}
				size--;
			}
		}
		// Item appear in List ? 
		public bool Contains(T item)
		{
			if (IndexOf(item) == -1) return false;
			return true;
		}
		// Clear List
		public void Clear()
		{
			data = null;
			size = 0;
		}
	}
}
