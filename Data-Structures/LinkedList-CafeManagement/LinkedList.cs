using static System.Console;

namespace LinkedList_CafeManagement
{
	public class LinkedList
	{
		private Node List;

		public LinkedList()
		{
			List = null;
		}
		public Node CreateNode(Drink d)
		{
			Node temp = new Node();
			temp.Drink = d;
			temp.Next = null;
			return temp;
		}
		public void AddToHead(Drink d)
		{
			Node temp = CreateNode(d);
			if (List == null) List = temp;
			else
			{
				temp.Next = List;
				List = temp;
			}
		}

		public void AddToTail(Drink d)
		{
			Node temp = CreateNode(d);
			if (List == null) List = temp;
			else
			{
				Node p = List;
				while (p.Next != null) p = p.Next;
				p.Next = temp;
			}
		}

		public void AddToAnyPosition(int position, Drink d)
		{
			if (position == 0 || List == null)
			{
				AddToHead(d);
			}
			else
			{
				Node p = List;
				int k = 1;
				while (p != null && k != position)
				{
					p = p.Next;
					k++;
				}
				// k > List.Lenght-1
				if (k != position)
				{
					AddToTail(d);
				}
				else
				{
					Node temp = CreateNode(d);
					temp.Next = p.Next;
					p.Next = temp;
				}
			}
		}

		public void ExportList()
		{
			for (Node p = List; p != null; p = p.Next)
			{
				WriteLine(p.Drink);
			}
		}
	}
}