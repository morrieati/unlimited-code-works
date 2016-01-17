using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_SameTree
{
	class Program
	{
		static void Main(string[] args)
		{
			TreeNode p = new TreeNode(10);
			p.left = new TreeNode(5);
			p.right = new TreeNode(15);

			TreeNode q = new TreeNode(10);
			q.left = new TreeNode(5);
			q.left.right = new TreeNode(15);

			Console.WriteLine(IsSameTree(p, q));
			Console.ReadLine();
		}

		public static bool IsSameTree(TreeNode p, TreeNode q)
		{
			if (p == null && q == null)
			{
				return true;
			}
			if (p == null || q == null)
			{
				return false;
			}

			if (p.val != q.val)
			{
				return false;
			}

			return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
		}
	}
}
