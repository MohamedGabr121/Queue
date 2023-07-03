namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Some Problem In Queue Use Singel Linked List */
			Queue queue = new Queue();
			Console.WriteLine("Insert some elements into the queue:");
			for (int i = 1; i <= 3; i++)
			{
				int node = int.Parse(Console.ReadLine());
				queue.EnQueue(node);
			}
			int max = queue.GetMaxElement();
            Console.WriteLine("Max Element Queue "+max);

			int min = queue.GetMinElement();
			Console.WriteLine("min Element Queue " + min);

		}
	}
}