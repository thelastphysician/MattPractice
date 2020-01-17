using System;

namespace DataStructures
{

	public class ArrayList<T>
	{
		private T[] list;
		private int count = 0;
		private int size = 1;
		private bool ignoreOoB = false;

		public ArrayList(bool ignoreOoB)
		{
			this.ignoreOoB = ignoreOoB;
		}
		public ArrayList()
		{
			
		}

		public int Count
		{
			get { return count; }
		}

		public int Capacity
		{
			get { return size; }
		}

		public void Append(T value)
		{
			if (count + 1 >= size)
			{
				T[] newList;
				try
				{
					newList = new T[size * 2];
				}
				catch
				{
					return;
				}
				
				for (int i = 0; i < count; ++i)
				{
					newList[i] = list[i];
				}
				list = newList;
				size = size * 2;
			}
			
			list[count] = value;
			++count;
			
		}

		public T Index(int i)
		{
			
			if(i > count || i < 0)
			{
				if (ignoreOoB)
				{
					return default(T);
				}
				else
				{
					throw new System.IndexOutOfRangeException("Index " + i + " out of Bounds for array of size " + count);
				}
				
			}
			return list[i];
		}
		public void Display()
		{
			
			for (int i = 0; i < count; ++i)
			{
				Console.Write(list[i] + ",");
			}
			Console.WriteLine();
			
			
			/*
			for (int i = 0; i < size; ++i)
			{
				if(i < count) { Console.Write(list[i] + ",");
				}
				else
				{
					Console.Write("null ,");
				}

				
			}
			Console.WriteLine();
			*/
		}

	}



	//Node Class
	class Node<T>
	{
		public T value;
		public Node<T> next;
		public Node(T value) 
		{
			this.value = value;
		}
	}


	 class LinkedList<T>
	{
		private Node<T> head;
		//private Node<T> tail;
		public LinkedList()
		{
		}

		public void Append(T value)
		{
			Node<T> newNode = new Node<T>(value);
			if(head == null)
			{
				//tail = newNode;
				head = newNode;
			}
			else
			{
				newNode.next = head;
				head = newNode;
			}
		}

		public T Pop()
		{
			if(head == null)
			{
				return default(T);
			}
			T ret = head.value;
			head = head.next;
			return ret;
				


		}

		//loop through the list and display each element in order
		public void Display()
		{
			Node<T> current = head;
			Console.Write("Head->");
			while (current != null)
			{
				Console.Write("[" + current.value + "]->");
				current = current.next;
			}
			Console.WriteLine("null");
		}
	}

}

