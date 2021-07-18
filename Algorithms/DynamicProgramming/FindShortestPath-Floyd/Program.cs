using System;

namespace FindShortestPath_Floyd
{
	class Program
	{
		static void Main(string[] args)
		{
			int Infinity = 999999; // No path exist between 2 node
			int[,] input = new int[,]
			{
				{ 0, 5, Infinity, 9, 1 },
				{ 5, 0, 2, Infinity, Infinity },
				{ Infinity, 2, 0, 7, Infinity },
				{ 9, Infinity, 7, 0, 2 },
				{ 1, Infinity, Infinity, 2, 0 }
			};
			Floyd floyd = new Floyd();
			floyd.Execute(input);
		}
	}
}
