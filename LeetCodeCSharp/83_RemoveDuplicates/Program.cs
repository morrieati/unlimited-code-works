using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _83_RemoveDuplicates
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode head = new ListNode(1);
			head.next = new ListNode(1);
			DeleteDuplicates(head);
		}

		public static ListNode DeleteDuplicates(ListNode head)
		{
			int temp = 0;
			ListNode p = head;
			while (p != null && p.next != null)
			{
				temp = p.val;
				while (p.next.val == temp)
				{
					p.next = p.next.next;
					if (p.next == null)
					{
						break;
					}
				}

				p = p.next;
			}

			return head;
		}
	}
}
