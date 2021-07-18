using System;
using static System.Console;
namespace Combination
{
	class Program
	{
		static void Main(string[] args)
		{
			// Cách chọn ra k phần tử trong tập hợp gồm n phần tử 
			// không theo thứ tự được gọi là một tổ hợp chập k của n 
			// C(k)(n)= n! / (k!(n-k)!)
			Combination_BT cbt = new Combination_BT();
			cbt.Execute(1, 2);
			WriteLine("---------------------------------------");
			cbt.Execute(2, 3);
			WriteLine("---------------------------------------");
			cbt.Execute(2, 5);
		}
	}
}
