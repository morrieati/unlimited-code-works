using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104_MaximumDepthOfBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public int MaxDepth(TreeNode root)
		{
			int leftDepth, rightDepth;
			if (root == null)
			{
				return 0;
			}
			else
			{
				leftDepth = MaxDepth(root.left);
				rightDepth = MaxDepth(root.right);
			}

			if (leftDepth > rightDepth)
			{
				root.val = leftDepth + 1;
			}
			else
			{
				root.val = rightDepth + 1;
			}

			return root.val;
		}
	}
}
