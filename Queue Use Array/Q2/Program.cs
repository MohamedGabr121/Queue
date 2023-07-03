namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* Some Problem In Queue Use Array */

			Console.WriteLine("Enter The Size Of Queue");
			int size = int.Parse(Console.ReadLine());
			Queue queue = new Queue(size);
			Console.WriteLine("Insert some elements into the queue:");
			for (int i = 1; i <= size; i++)
			{
				int node = int.Parse(Console.ReadLine());
				queue.Enqueue(node);
			}
			queue.PopNth(2);
			queue.DisplayQueue();
		}
	}
}