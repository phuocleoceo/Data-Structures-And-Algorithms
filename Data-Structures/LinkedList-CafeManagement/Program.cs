namespace LinkedList_CafeManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList lkl = new LinkedList();
			lkl.AddToHead("Ca phe den", 8000);
			lkl.AddToHead("Ca phe sua da", 10000);
			lkl.AddToHead("Capuchino", 25000);
			lkl.AddToHead("Ca phe trung", 30000);
			lkl.AddToHead("Tra sua tran chau", 20000);
			lkl.AddToTail("Gin", 100000);
			lkl.AddToAnyPosition(5, "Vodka", 90000);
			lkl.ExportList();
		}
	}
}
