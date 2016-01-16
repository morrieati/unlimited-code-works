using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226_InvertBinaryTree
{
	class Program
	{
		static void Main(string[] args)
		{
		}

		public TreeNode InvertTree(TreeNode root)
		{
			if (root == null)
			{
				return null;
			}

			TreeNode temp;
			temp = root.left;
			root.left = InvertTree(root.right);
			root.right = InvertTree(temp);
			
			return root;
		}
	}
}
