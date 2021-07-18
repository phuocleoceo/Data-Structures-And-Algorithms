using static System.Console;
namespace Combination
{
	public class Combination_BT
	{
		private int k;
		private int n;
		private int[] A;
		private static int count;
		private const int MAX = 20;

		public Combination_BT() { }

		private void Export()
		{
			Write((count++) + " : ");
			for (int i = 1; i <= k; i++)
			{
				Write(A[i] + " ");
			}
			WriteLine("");
		}

		private void Try(int i)
		{
			for (int j = 1 + A[i - 1]; j <= n - k + i; j++)
			{
				A[i] = j;
				if (i == k) Export();
				else Try(i + 1);
			}
		}

		public void Execute(int k, int n)
		{
			this.k = k;
			this.n = n;
			A = new int[MAX];
			count = 1;
			Try(1);
		}
	}
}