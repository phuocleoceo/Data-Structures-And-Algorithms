using System;
using static System.Console;
namespace BigFactorial
{
	class Program
	{
		static void Main(string[] args)
		{
			BF bF = new BF();
			bF.Execute(5);
			WriteLine("\n---------------------------------------------");
			bF.Execute(10);
			WriteLine("\n---------------------------------------------");
			bF.Execute(20);
		}
	}
}
