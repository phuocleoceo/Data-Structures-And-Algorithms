namespace LinkedList_CafeManagement
{
	public class Node<T> where T : class
	{
		public T entity { get; set; }

		public Node<T> Next { get; set; }
	}
}