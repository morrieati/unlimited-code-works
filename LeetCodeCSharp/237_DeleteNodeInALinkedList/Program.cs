using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _237_DeleteNodeInALinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public void DeleteNode(ListNode node)
		{
			if (node.next != null)
			{
				node.val = node.next.val;
				node.next = node.next.next;
			}
		}
	}
}
