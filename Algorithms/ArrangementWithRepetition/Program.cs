using System;
using static System.Console;

namespace ArrangementWithRepetition
{
	class Program
	{
		static void Main(string[] args)
		{
			// Chỉnh hợp lặp chập k của n phần tử là một cách sắp xếp 
			// có thứ tự của k phần tử, mà mỗi phần tử lấy từ n phần tử 
			// đã cho có thể có mặt nhiều lần => n^k
			AWR_BT awr1 = new AWR_BT();
			awr1.Execute();
			WriteLine("---------------------------------------");
			AWR_BT awr2 = new AWR_BT(3, 2);
			awr2.Execute();
			WriteLine("---------------------------------------");
			awr2.SetValue(2, 2);
			awr2.Execute();
		}
	}
}
