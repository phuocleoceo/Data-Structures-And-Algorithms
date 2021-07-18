using static System.Console;
namespace FindShortestPath_Floyd
{
	public class Floyd
	{
		private int[,] A;
		private int n;

		public Floyd() { }

		private void Calculate()
		{
			for (int k = 1; k <= n; k++)
			{
				for (int i = 1; i <= n; i++)
				{
					for (int j = 1; j <= n; j++)
					{
						if (A[i, j] > A[i, k] + A[k, j])
						{
							A[i, j] = A[i, k] + A[k, j];
						}
					}
				}
			}
		}

		private void Export()
		{
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n; j++)
				{
					Write(A[i, j] + "  ");
				}
				Write("\n");
			}
		}

		public void Execute(int[,] A)
		{
			if (A.GetLength(0) != A.GetLength(1))
			{
				WriteLine("Invalid input !");
				return;
			}
			this.n = A.GetLength(0);
			this.A = new int[this.n + 1, this.n + 1];
			for (int i = 1; i <= this.n; i++)
			{
				for (int j = 1; j <= this.n; j++)
				{
					(this.A)[i, j] = A[i - 1, j - 1];
				}
			}
			Calculate();
			Export();
		}
	}
}