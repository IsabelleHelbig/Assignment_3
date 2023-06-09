﻿using Assignment_3_Skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_3_skeleton
{
	public class SLL : LinkedListADT
	{
		private Node _head;
		private Node _tail;

		public SLL()
		{
			this._head = null;
			this._tail = null;
		}

		public void Append(object data)
		{
			Node newNode = new Node(data);
			// the list is empty
			if (this._head == null)
			{
				this._head = this._tail = newNode;
			}

			// if not empty
			else
			{
				this._tail.Next = newNode;
				this._tail = newNode;
			}
			//throw new NotImplementedException();
		}

		public void Clear()
		{
			this._head = this._tail = null;
			//throw new NotImplementedException();
		}

		public bool Contains(object data)
		{
			Node current = this._head;
			while (current != null)
			{
				if (current.Data == data)
				{
					return true;
				}
				current = current.Next;
			}
			return false;
			//throw new NotImplementedException();
		}

		public void Delete(int index)
		{
			int count = Size();
			if (index < 0 || index >= count)
			{
				throw new ArgumentOutOfRangeException("Index is out of range.");
			}

			Node current = this._head;
			Node previous = null;
			for (int i = 0; i < index; i++)
			{
				previous = current;
				current = current.Next;
			}

			if (previous == null)
			{
				this._head = null;
			}
			else
			{
				previous.Next = current.Next;
				if (current.Next == null)
				{
					this._tail = previous;
				}
			}

			//throw new NotImplementedException();
		}

		public int IndexOf(object data)
		{
			Node current = this._head;
			int index = 0;
			while (current != null)
			{
				if (current.Data == data)
				{
					return index;
				}
				current = current.Next;
				index++;
			}
			return -1;
			//throw new NotImplementedException();
		}

		public void Insert(object data, int index)
		{
			if (index < 0 || index > this.Size())
			{
				throw new IndexOutOfRangeException();
			}
			Node newNode = new Node(data);

			if (index == 0)
			{
				newNode.Next = this._head;
				this._head = newNode;
				return;
			}

			Node current = this._head;
			for (int i = 0; i < index - 1; i++)
			{
				if (current == null)
				{
					throw new IndexOutOfRangeException();
				}
				current = current.Next;
			}

			newNode.Next = current.Next;
			current.Next = newNode;
		}

		public bool IsEmpty()
		{
			if (this._head == null)
			{
				return true;
			}
			return false;
			//throw new NotImplementedException();
		}

		public void Prepend(object data)
		{
			Node newNode = new Node(data);
			if (this._head == null)
			{
				this._head = newNode;
			}
			else
			{
				newNode.Next = this._head;
				this._head = newNode;
			}
			//throw new NotImplementedException();
		}

		public void Replace(object data, int index)
		{
			if (index < 0 || index > this.Size())
			{
				throw new IndexOutOfRangeException();
			}
			Node newNode = new Node(data);

			if (index == 0)
			{
				newNode.Next = this._head.Next;
				this._head = newNode;
				return;
			}

			Node current = this._head;
			for (int i = 0; i < index - 1; i++)
			{
				if (current == null)
				{
					throw new IndexOutOfRangeException();
				}
				current = current.Next;
			}

			newNode.Next = current.Next.Next;
			current.Next = newNode;
		}

		public object Retrieve(int index)
		{
			if (index < 0 || index > this.Size())
			{
				throw new IndexOutOfRangeException();
			}
			Node current = this._head;
			for (int i = 0; i < index; i++)
			{
				if (current == null)
				{
					throw new IndexOutOfRangeException();
				}
				current = current.Next;
			}
			return current.Data;
		}

		public int Size()
		{
			int count = 0;
			Node current = this._head;
			while (current != null)
			{
				count++;
				current = current.Next;
			}
			return count;
			//throw new NotImplementedException();
		}
	}
}
