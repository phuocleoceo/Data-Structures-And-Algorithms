using System;
using System.Collections.Generic;
using static System.Console;

namespace Dictionary_CountWord
{
	class Program
	{
		static Dictionary<string, int> Handling(string text)
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			string[] LINES = text.ToUpper().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			foreach (string UniqueWord in LINES)
			{
				if (!dict.ContainsKey(UniqueWord))
				{
					dict.Add(UniqueWord, 1);
				}
				else
				{
					dict[UniqueWord]++;
				}
			}
			return dict;
		}
		static void Print(Dictionary<string, int> dict)
		{
			foreach (KeyValuePair<string, int> i in dict)
			{
				WriteLine($"{i.Key,10}\t{i.Value}");
			}
		}
		static void Main(string[] args)
		{
			string text = "hehe minh la phuoc phuoc nice to meet you";
			Dictionary<string, int> dict = Handling(text);
			Print(dict);
		}
	}
}
