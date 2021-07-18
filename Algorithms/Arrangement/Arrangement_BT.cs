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
			this.k = 1;
			this.n = 1;
			count = 1;
			A = new int[MAX];
			USED = new bool[MAX];
		}

		public Arrangement_BT(int k, int n)
		{
			this.k = k;
			this.n = n;
			count = 1;
			A = new int[MAX];
			USED = new bool[MAX];
		}

		public void SetValue(int k, int n)
		{
			this.k = k;
			this.n = n;
			count = 1;
			USED = new bool[MAX];
		}

		public void Export()
		{
			Write((count++) + " : ");
			for (int i = 1; i <= k; i++)
			{
				Write(A[i] + " ");
			}
			WriteLine("");
		}

		public void Try(int i)
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

		public void Execute()
		{
			Try(1);
		}
	}
}