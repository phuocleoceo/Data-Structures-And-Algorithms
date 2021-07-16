namespace LinkedList_CafeManagement
{
	public class LinkedList
	{
		public Drink CreateNode(string Name, double Price)
		{
			Drink d = new Drink();
			d.Name = Name;
			d.Price = Price;
			d.Next = null;
			return d;
		}
		public Drink AddToHead(Drink List, string Name, double Price)
		{
			Drink temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				temp.Next = List;
				List = temp;
			}
			return List;
		}

		public Drink AddToTail(Drink List, string Name, double Price)
		{
			Drink temp = CreateNode(Name, Price);
			if (List == null) List = temp;
			else
			{
				Drink p = List;
				while (p.Next != null) p = p.Next;
				p.Next = temp;
			}
			return List;
		}

		public Drink AddToAnyPosition(Drink List, int position, string Name, double Price)
		{
			if (position == 0 || List == null)
			{
				List = AddToHead(List, Name, Price);
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
					List = AddToTail(List, Name, Price);
				}
				else
				{
					Drink temp = CreateNode(Name, Price);
					temp.Next = p.Next;
					p.Next = temp;
				}
			}
			return List;
		}
	}
}