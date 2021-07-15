using System;
using static System.Console;

namespace BinarySearchTree_CountWord
{
	class Program
	{
		static bool IsAlpha(char c)
		{
			if (c >= 'A' && c <= 'Z') return true;
			return false;
		}
		static void Handling(string text, BST bst, ref Node root)
		{
			int Count;
			int k = 0;
			string[] LINES = text.ToUpper().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			foreach (string Line in LINES)
			{
				string UniqueWord = "";
				for (int i = 0; i < Line.Length; i++)
				{
					if (IsAlpha(Line[i]))
					{
						UniqueWord += Line[i];
					}
					if (!IsAlpha(Line[i]) || i == Line.Length - 1)
					{
						Node search = bst.Search(root, UniqueWord);
						if (search == null)
						{
							if (!string.IsNullOrWhiteSpace(UniqueWord))
							{
								k++;
								root = bst.InsertNode(root, UniqueWord, 1);
								UniqueWord = "";
							}
						}
						else
						{
							Count = search.Count;
							root = bst.DeleteNode(root, UniqueWord);
							Count++;
							root = bst.InsertNode(root, UniqueWord, Count);
							UniqueWord = "";
						}
					}
				}
			}
		}
		static void Main(string[] args)
		{
			Node root = null;
			BST bst = new BST();
			string text = "hehe minh la phuoc phuoc";
			Handling(text, bst, ref root);
			bst.LNR(root);
		}
	}
}
