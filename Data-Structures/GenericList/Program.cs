using System;
using static System.Console;
namespace GenericList
{
	class Program
	{
		static void Main(string[] args)
		{
			ManageList<Account> list = new ManageList<Account>();
			Account Acc1 = new Account("phuoc", "tmp", "1", 1);
			Account Acc2 = new Account("sontung", "mtp", "1", 0);
			Account Acc3 = new Account("quanap", "ap", "2", 1);
			Account Acc4 = new Account("pmq", "PhanManhQuynh", "10", 1);

			list.Add(Acc1);
			list.Add(Acc2);
			list.Add(Acc3);
			list.Add(Acc4);

			list.Remove(new Account("quanap", "ap", "2", 1));
			list.RemoveAt(0);

			for (int i = 0; i < list.Count; i++)
			{
				WriteLine(list[i]);
			}
			WriteLine("----------------------------------------------------");
			list.AddRange(new Account[]{
				new Account("juky","Juky San","12",0),
				new Account("amee","Amee","23",0)
			});

			for (int i = 0; i < list.Count; i++)
			{
				WriteLine(list[i]);
			}
		}
	}
}
