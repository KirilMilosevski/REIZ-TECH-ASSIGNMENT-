using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class TreeNode
    {
		public int data;
		public TreeNode left;
		public TreeNode right;
	
		public TreeNode(int data)
		{
		
			this.data = data;
			this.left = null;
			this.right = null;
		}
	}
	public class BinaryTree
	{
		public TreeNode root;
		public BinaryTree()
		{
		
			this.root = null;
		}
	
		public int depth(TreeNode node)
		{
			if (node != null)
			{
				var a = this.depth(node.left);
				var b = this.depth(node.right);
			
				if (a > b)
				{
					return a + 1;
				}
				else
				{
					return b + 1;
				}
			}
			else
			{
				return 0;
			}
		}

		static void Main(string[] args)
        {
			var tree = new BinaryTree();

			tree.root = new TreeNode(1);
			tree.root.left = new TreeNode(2);
			tree.root.right = new TreeNode(3);
			tree.root.right.right = new TreeNode(2);
			tree.root.right.left = new TreeNode(3);
			Console.WriteLine("The depth is" + " " + tree.depth(tree.root));
		}
    }
}
