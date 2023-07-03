using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	public class Queue
	{
		Node front;
		Node rear;

		public Queue()
		{
			front = rear = null;
		}
		bool IsEmpty()
		{
			if (front == null)
				return true;
			else
				return false;
		}
		public void EnQueue(int item)
		{
			Node newNode = new Node(item);
			newNode.Data = item;
			if (IsEmpty())
			{
				front=rear=newNode;
			}
			else
			{
				rear.Next = newNode;
				rear=newNode; 
			}
		}
		public int Count()
		{
			Node temp = front;
			int count =0;
			while (temp != null)
			{
				count++;
				temp = temp.Next;
			}
			return count;
		}

		public int GetMaxElement()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("queue is empty");
			}

			int maxElement = int.MinValue;
			Node current = front;
			while (current != null)
			{
				if (current.Data > maxElement)
				{
					maxElement = current.Data;
				}
				current = current.Next;
			}

			return maxElement;
		}

		public int GetMinElement()
		{
			if (IsEmpty())
			{
				throw new InvalidOperationException("queue is empty");
			}

			int minxElement = int.MaxValue;
			Node current = front;
			while (current != null)
			{
				if (current.Data < minxElement)
				{
					minxElement = current.Data;
				}
				current = current.Next;
			}

			return minxElement;
		}

		
		public void Reverse()
		{

			if (IsEmpty())
			{
				Console.WriteLine("Queue is empty. Cannot reverse elements.");
				return;
			}

			Node prev = null;
			Node current = front;
			Node next = null;

			while (current != null)
			{
				next = current.Next;
				current.Next = prev;
				prev = current;
				current = next;
			}

			rear = front;
			front = prev;

		}
		public void DisplayQueue()
		{
			Node temp = front;
			while (temp != null)
			{
                Console.Write(temp.Data + " ");
				temp = temp.Next;
            }
		}
	}
}
