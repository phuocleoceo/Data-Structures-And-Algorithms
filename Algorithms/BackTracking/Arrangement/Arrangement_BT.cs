using static System.Console;
namespace Arrangement
{
	public class Arrangement_BT
	{
		private int k;
		private int n;
		private int[] A;
		private bool[] USED;
		private static int count;
		private const int MAX = 20;

		public Arrangement_BT()
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
				if (!USED[j])
				{
					A[i] = j;
					USED[j] = true;
					if (i == k) Export();
					else Try(i + 1);
					USED[j] = false;
				}
			}
		}

		public void Execute(int k, int n)
		{
			this.k = k;
			this.n = n;
			count = 1;
			USED = new bool[MAX];
			Try(1);
		}
	}
}