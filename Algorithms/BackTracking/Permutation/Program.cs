using static System.Console;

namespace Permutation
{
	class Program
	{
		static void Main(string[] args)
		{
			// Hoán vị là số cách sắp xếp thứ tự của n phần tử = n!
			// Cũng chính là chỉnh hợp không lặp n chập n
			Permutation_BT pbt = new Permutation_BT();
			pbt.Execute(1);
			WriteLine("---------------------------------------");
			pbt.Execute(2);
			WriteLine("---------------------------------------");
			pbt.Execute(3);
		}
	}
}
