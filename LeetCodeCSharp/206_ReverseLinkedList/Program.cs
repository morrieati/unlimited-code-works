using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _206_ReverseLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode head = new ListNode(1);
			head.next = new ListNode(2);
			head = ReverseList(head);
		}

		public static ListNode ReverseList(ListNode head)
		{
			ListNode tempNode = head;
			ListNode p, q = null;

			while (tempNode != null)
			{
				p = tempNode;
				tempNode = tempNode.next;

				p.next = q;
				q = p;
			}
			head = q;

			return head;
		}
	}
}
