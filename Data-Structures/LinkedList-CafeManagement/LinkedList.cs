using static System.Console;

namespace LinkedList_CafeManagement
{
	public class LinkedList
	{
		private Drink List;

		public LinkedList()
		{
			List = null;
		}
		public Drink CreateNode(string Name, double Price)
		{
			Drink d = new Drink();
			d.Name = Name;
			d.Price = Price;
			d.Next = null;
			return d;
		}
		public void AddToHead(string Name, double Price)
		{
			Drink temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				temp.Next = List;
				List = temp;
			}
		}

		public void AddToTail(string Name, double Price)
		{
			Drink temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				Drink p = List;
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
				Drink p = List;
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
					Drink temp = CreateNode(Name, Price);
					temp.Next = p.Next;
					p.Next = temp;
				}
			}
		}

		public void ExportList()
		{
			for (Drink p = List; p != null; p = p.Next)
			{
				WriteLine($"{p.Name,20}\t{p.Price}VND");
			}
		}
	}
}