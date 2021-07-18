using static System.Console;
namespace Permutation
{
	public class Permutation_BT
	{
		private int n;
		private int[] A;
		private bool[] USED;
		private static int count;
		private const int MAX = 20;

		public Permutation_BT()
		{
			A = new int[MAX];
		}

		private void Export()
		{
			Write((count++) + " : ");
			for (int i = 1; i <= n; i++)
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
					if (i == n) Export();
					else Try(i + 1);
					USED[j] = false;
				}
			}
		}

		public void Execute(int n)
		{
			this.n = n;
			count = 1;
			USED = new bool[MAX];
			Try(1);
		}
	}
}