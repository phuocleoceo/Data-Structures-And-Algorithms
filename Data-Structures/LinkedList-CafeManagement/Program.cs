﻿namespace LinkedList_CafeManagement
{
	class Program
	{
		static void Main(string[] args)
		{
			LinkedList<Drink> lkl = new LinkedList<Drink>();
			lkl.AddToHead(new Drink("Ca phe den", 8000));
			lkl.AddToHead(new Drink("Ca phe sua da", 10000));
			lkl.AddToHead(new Drink("Capuchino", 25000));
			lkl.AddToHead(new Drink("Ca phe trung", 30000));
			lkl.AddToHead(new Drink("Tra sua tran chau", 20000));
			lkl.AddToTail(new Drink("Gin", 100000));
			lkl.AddToAnyPosition(5, new Drink("Vodka", 90000));
			lkl.AddRange(new Drink[]{
				new Drink("Tra tac",10000),
				new Drink("Sua dua",5000)
			});
			lkl.ExportList();
		}
	}
}
