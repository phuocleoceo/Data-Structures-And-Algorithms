using static System.Console;
namespace BigFactorial
{
	public class BF
	{
		private int n;
		private int[] A;
		private int m;
		private const int MAX = 999999;
		public BF()
		{
			this.A = new int[MAX];
		}

		private void Calculate()
		{
			int remainder = 0, s;
			A[1] = 1;
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= m; j++)
				{
					s = A[j] * i + remainder;
					A[j] = s % 10;
					remainder = s / 10;
				}
				while (remainder > 0)
				{
					m++;
					A[m] = remainder % 10;
					remainder = remainder / 10;
				}
			}
		}

		private void Export()
		{
			Write(n + "! = ");
			for (int i = m; i >= 1; i--)
			{
				Write(A[i]);
			}
		}

		public void Execute(int n)
		{
			this.n = n;
			this.m = 1;
			if (n < 0)
			{
				WriteLine("Invalid Input !");
				return;
			}
			else
			{
				Calculate();
				Export();
			}
		}
	}
}