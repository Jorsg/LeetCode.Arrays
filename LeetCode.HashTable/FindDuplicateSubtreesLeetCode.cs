using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashTable
{
	internal class FindDuplicateSubtreesLeetCode
	{
		public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
		{
			var dups = new Dictionary<string, IList<TreeNode>>();

			Dfs(root);

			return dups.Values
				.Where(_ => _.Count() > 1)
				.Select(_ => _.First()).ToList();

			string Dfs(TreeNode node)
			{
				if (node == null) return null;

				var key = $"({Dfs(node.left)},{node.val},{Dfs(node.right)})";

				if (!dups.TryGetValue(key, out var l))
					dups[key] = l = new List<TreeNode>();

				l.Add(node);

				return key;
			}
		}
	}

	// Definition for a binary tree node.
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}
}
