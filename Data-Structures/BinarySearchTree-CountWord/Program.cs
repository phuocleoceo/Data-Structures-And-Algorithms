using System;

namespace BinarySearchTree_CountWord
{
	class Program
	{
		static void Handling(string text, BST bst, Node root)
		{
			string[] LINES = text.ToUpper().Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
			foreach (string UniqueWord in LINES)
			{
				Node search = bst.Search(root, UniqueWord);
				if (search == null)
				{
					if (!string.IsNullOrWhiteSpace(UniqueWord))
					{
						root = bst.InsertNode(root, UniqueWord, 1);
					}
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
		static void Main(string[] args)
		{
			Node root = null;
			BST bst = new BST();
			string text = "hehe minh la phuoc phuoc nice to meet you";
			Handling(text, bst, root);
		}
	}
}
