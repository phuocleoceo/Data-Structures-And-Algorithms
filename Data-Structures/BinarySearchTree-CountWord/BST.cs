using System;
using static System.Console;

namespace BinarySearchTree_CountWord
{
	public class BST
	{
		/* Find the last node in the left of root
		 It bigger than "all left-side" nodes 
		 and smaller than "all right-side" nodes of current Node*/
		public Node EndLeftNode(Node root)
		{
			Node p = root;
			while (p.Left != null) p = p.Left;
			return p;
		}

		public Node CreateNode(string Word, int Count)
		{
			Node p = new Node();
			p.Left = null;
			p.Right = null;
			p.Word = Word;
			p.Count = Count;
			return p;
		}

		/*If Tree has 0 Node, create a Node
		If Word of the Node we wanna Insert smaller than current -> Insert to left-side
		else Insert to right-side
		*/
		public Node InsertNode(Node root, string Word, int Count)
		{
			if (root == null) root = CreateNode(Word, Count);
			else if (String.Compare(Word, root.Word) < 0)
				root.Left = InsertNode(root.Left, Word, Count);
			else
				root.Right = InsertNode(root.Right, Word, Count);
			return root;
		}

		public Node Search(Node root, string Word)
		{
			if (root == null) return null;
			Node p = root;
			while (p != null)
			{
				if (p.Word == Word) return p;
				else if (String.Compare(Word, p.Word) < 0) p = p.Left;
				else p = p.Right;
			}
			return p;
		}

		public Node DeleteNode(Node root, string Word)
		{
			if (root == null) return root;
			if (String.Compare(Word, root.Word) < 0)
				root.Left = DeleteNode(root.Left, Word);

			else if (String.Compare(Word, root.Word) > 0)
				root.Right = DeleteNode(root.Right, Word);
			//Word==root.Word
			else
			{
				// root has only right-side node
				if (root.Left == null)
				{
					Node p = root.Right;
					root = null;
					return p;
				}
				// root has only left-side node
				else if (root.Right == null)
				{
					Node p = root.Left;
					root = null;
					return p;
				}
				// root has both left-side and right-side node
				else
				{
					Node p = EndLeftNode(root.Right);
					root.Word = p.Word;
					root.Count = p.Count;
					root.Right = DeleteNode(root.Right, p.Word);
				}
			}
			return root;
		}

		public void LNR(Node root)
		{
			if (root != null)
			{
				LNR(root.Left);
				WriteLine(root.Word + " " + root.Count);
				LNR(root.Right);
			}
		}
	}
}