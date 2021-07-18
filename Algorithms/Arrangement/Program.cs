using System;
using static System.Console;

namespace Arrangement
{
	class Program
	{
		static void Main(string[] args)
		{
			// Cách sắp xếp k phần tử của tập hợp gồm n phần tử 
			// theo một thứ tự được gọi là một chỉnh hợp chập k của n 
			// A(k)(n)= n! / (n-k)!
			Arrangement_BT a1 = new Arrangement_BT();
			a1.Execute();
			WriteLine("---------------------------------------");
			Arrangement_BT a2 = new Arrangement_BT(2, 3);
			a2.Execute();
			WriteLine("---------------------------------------");
			a2.SetValue(2, 2);
			a2.Execute();
		}
	}
}
