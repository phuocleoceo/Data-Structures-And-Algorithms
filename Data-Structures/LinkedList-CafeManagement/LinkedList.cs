using static System.Console;

namespace LinkedList_CafeManagement
{
	public class LinkedList<T> where T : class
	{
		private Node<T> List;

		public LinkedList()
		{
			List = null;
		}
		public Node<T> CreateNode(T entity)
		{
			Node<T> temp = new Node<T>();
			temp.entity = entity;
			temp.Next = null;
			return temp;
		}
		public void AddToHead(T entity)
		{
			Node<T> temp = CreateNode(entity);
			if (List == null) List = temp;
			else
			{
				temp.Next = List;
				List = temp;
			}
		}

		public void AddToTail(T entity)
		{
			Node<T> temp = CreateNode(entity);
			if (List == null) List = temp;
			else
			{
				Node<T> p = List;
				while (p.Next != null) p = p.Next;
				p.Next = temp;
			}
		}

		public void AddToAnyPosition(int position, T entity)
		{
			if (position == 0 || List == null)
			{
				AddToHead(entity);
			}
			else
			{
				Node<T> p = List;
				int k = 1;
				while (p != null && k != position)
				{
					p = p.Next;
					k++;
				}
				// k > List.Lenght-1
				if (k != position)
				{
					AddToTail(entity);
				}
				else
				{
					Node<T> temp = CreateNode(entity);
					temp.Next = p.Next;
					p.Next = temp;
				}
			}
		}

		public void AddRange(T[] entityArray)
		{
			for (int i = 0; i < entityArray.Length; i++)
			{
				AddToTail(entityArray[i]);
			}
		}

		public void ExportList()
		{
			for (Node<T> p = List; p != null; p = p.Next)
			{
				WriteLine(p.entity);
			}
		}
	}
}