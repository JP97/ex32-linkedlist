using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adt
{
	class MyLinkedList
	{
		private int count;


		public int Count { get {return this.count; } set {this.count = value; } }
		public Node Head;



		public void Insert(object m)
		{
			throw new NotImplementedException();
		}

		public void Insert(object m, int b)
		{
			Node n = new Node(m);
			// 1) tom 
			// index 0 
			switch (b)
			{
				case 0:
					n.Next = Head;
					Head = n;
					break;

				//2) insert i midten
				// vis index er mellem 0 og antallet af listen
				case b.count:

					break;

				//3) slutingen af listen
				// index er antallet af listen plus 1
				case default:
					Node temp = Head;
					for (int i = 0; i < b - 1; i++)
					{
						temp = temp.Next;
					}

					n.Next = temp.Next;
					temp = n;

					break;
			}
			count++;
			throw new NotImplementedException();
		}

		public void Delete()
		{
			throw new NotImplementedException();
		}


		public void Delete(int b)
		{
			throw new NotImplementedException();
		}

		public Node ItemAt(int b)
		{
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			throw new NotImplementedException();
		}

	}
}
