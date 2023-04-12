using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Skeleton
{
	public class Node
	{
		private object _data;
		private Node _next;

		public object Data { get { return _data; } set { _data = value; } }
		public Node Next { get { return _next; } set { _next = value; } }

		public Node(object data)
		{
			this._next = null;
			this._data = data;
		}
	}
}
