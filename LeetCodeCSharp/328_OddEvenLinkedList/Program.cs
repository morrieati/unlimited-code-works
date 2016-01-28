using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _328_OddEvenLinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			ListNode head = new ListNode(1);
			head.next = new ListNode(2);
			head.next.next = new ListNode(3);
			head.next.next.next = new ListNode(4);
			head.next.next.next.next = new ListNode(5);
			head.next.next.next.next.next = new ListNode(6);
			head.next.next.next.next.next.next = new ListNode(7);
			head.next.next.next.next.next.next.next = new ListNode(8);

			head = OddEvenList(head);

			ListNode t = head;
			while(t != null)
			{
				Console.WriteLine(t.val);
				t = t.next;
			}
			Console.ReadLine();
		}

		public static ListNode OddEvenList(ListNode head)
		{
			if (head == null || head.next == null || head.next.next == null)
			{
				return head;
			}

			ListNode tempOdd = head;
			ListNode tempEven = head.next;
			ListNode Even = tempEven;
			ListNode current = tempEven.next;
			bool isOdd = true;

			while (current != null)
			{
				if (isOdd)
				{
					tempOdd.next = current;
					tempOdd = current;
				}
				else
				{
					tempEven.next = current;
					tempEven = current;
				}
				current = current.next;
				isOdd = !isOdd;
			}
			tempEven.next = null;
			tempOdd.next = Even;

			return head;
		}
	}
}
