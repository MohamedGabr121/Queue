using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q2
{
	public class Queue
	{
		int[] queue;

		int front;
		int rear;
		int capacity;

		public Queue(int c)
		{
			front = 0;
			rear = 0;
			capacity = c;
			queue = new int[capacity];
		}
		bool IsEmpty()
		{
			if (front == -1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void Enqueue(int item)
		{
			if (capacity == rear)
			{
				return;
			}
			else if (IsEmpty())
			{
				front = rear = 0;
			}
			else
			{
				queue[rear] = item;
				rear++;
			}
		}

		public int Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty. Cannot dequeue elements.");
				return -1;
			}

			int dequeued = queue[front++];
			return dequeued;
		}

		public int Sum()
		{
			int sum = 0;
			for (int i = front; i < rear; i++)
			{
				sum += queue[i];
			}
			return sum;
		}
		public int Count()
		{
			int count = 1;
			for (int i = front; i < rear; i++)
			{
				count++;
			}
			return count;
		}
		public void Average()
		{
			int count = queue.Count();
			int sum = queue.Sum();
			int avg = sum / count;
			Console.WriteLine(avg);
		}

		public void PopNth(int n)
		{
			for (int i = 0; i <= n - 1; i++)
			{
				Dequeue();
			}
		}

		public void Ascending()
		{
			queue = queue.OrderBy(x => x).ToArray();
		}

		public double MedianElement()
		{
			int count = Count();
			int midIndex = count / 2;
			if (count % 2 == 0)
			{
				int midValue1 = queue[midIndex - 1];
				int midValue2 = queue[midIndex];
				return (midValue1 + midValue2) / 2.0;
			}
			else
			{
				return queue[midIndex];

			}

		}
		public void DisplayQueue()
		{
			for (int i = front; i < rear; i++)
			{
				Console.Write(queue[i] + " ");
			}
			Console.WriteLine();
		}
	}
}
