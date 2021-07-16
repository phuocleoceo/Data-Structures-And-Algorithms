using System;

namespace BinarySearchTree_CountWord
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "hehe minh la phuoc phuoc nice to meet you";
			BST bst = new BST();
			Node root = null;
			string[] LINES = text.ToUpper().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			foreach (string UniqueWord in LINES)
			{
				Node search = bst.Search(root, UniqueWord);
				if (search == null && !string.IsNullOrWhiteSpace(UniqueWord))
				{
					root = bst.InsertNode(root, UniqueWord, 1);
				}
				else
				{
					int Count = search.Count;
					root = bst.DeleteNode(root, UniqueWord);
					root = bst.InsertNode(root, UniqueWord, Count + 1);
				}
			}
			bst.LNR(root);
		}
	}
}
