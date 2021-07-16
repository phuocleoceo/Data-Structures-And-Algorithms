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
		public Node CreateNode(string Name, double Price)
		{
			Node d = new Node();
			d.Name = Name;
			d.Price = Price;
			d.Next = null;
			return d;
		}
		public void AddToHead(string Name, double Price)
		{
			Node temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				temp.Next = List;
				List = temp;
			}
		}

		public void AddToTail(string Name, double Price)
		{
			Node temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				Node p = List;
				while (p.Next != null) p = p.Next;
				p.Next = temp;
			}
		}

		public void AddToAnyPosition(int position, string Name, double Price)
		{
			if (position == 0 || List == null)
			{
				AddToHead(Name, Price);
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
					AddToTail(Name, Price);
				}
				else
				{
					Node temp = CreateNode(Name, Price);
					temp.Next = p.Next;
					p.Next = temp;
				}
			}
		}

		public void ExportList()
		{
			for (Node p = List; p != null; p = p.Next)
			{
				WriteLine($"{p.Name,20}\t{p.Price}VND");
			}
		}
	}
}