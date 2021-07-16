using System;

namespace LinkedList_CafeManagement
{
	class Program
	{
		static void Handling(LinkedList lkl)
		{
			Drink List = null;
			List = lkl.AddToHead(List, "Ca phe den", 8000);
			List = lkl.AddToHead(List, "Ca phe sua da", 10000);
			List = lkl.AddToHead(List, "Capuchino", 25000);
			List = lkl.AddToHead(List, "Ca phe trung", 30000);
			List = lkl.AddToHead(List, "Tra sua tran chau", 20000);
			lkl.ExportList(List);
		}
		static void Main(string[] args)
		{
			LinkedList lkl = new LinkedList();
			Handling(lkl);
		}
	}
}
