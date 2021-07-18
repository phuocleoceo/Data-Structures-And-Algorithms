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
			AWR_BT awr = new AWR_BT();
			awr.Execute(1, 2);
			WriteLine("---------------------------------------");
			awr.Execute(2, 3);
			WriteLine("---------------------------------------");
			awr.Execute(4, 2);
		}
	}
}
