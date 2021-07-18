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
			Arrangement_BT abt = new Arrangement_BT();
			abt.Execute(1, 2);
			WriteLine("---------------------------------------");
			abt.Execute(2, 3);
			WriteLine("---------------------------------------");
			abt.Execute(2, 2);
		}
	}
}
