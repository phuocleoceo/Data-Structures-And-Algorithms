using static System.Console;
namespace ArrangementWithRepetition
{
	public class AWR_BT
	{
		private int k;
		private int n;
		private int[] A;
		private static int count;
		private const int MAX = 20;

		public AWR_BT()
		{
			A = new int[MAX];
		}

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
			for (int j = 1; j <= n; j++)
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
			count = 1;
			Try(1);
		}
	}
}