using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeVisualizer<T> : ITreeVisualizer<T> where T : IComparable<T>
    {
        public string Show(Tree<T> tree)
        {
            return "";
        }

        List<TreeNode> Convert(Tree<T> tree)
        {
            ConvertNode(null, tree, 0);
            Nodes.Reverse();
            return null;
        }

        TreeNode ConvertNode(TreeNode parent, Tree<T> tree, int level)
        {
            var result = new TreeNode
            {
                Level = level,
                Parent = parent,
                Value = tree.Value.ToString(),
            };

            result.Left = tree.Left == null ? null : ConvertNode(result, tree.Left, level + 1);
            result.Right = tree.Right == null ? null : ConvertNode(result, tree.Right, level + 1);

            Nodes.Add(result);
            return result;
        }

        List<TreeNode> Nodes { get; set; } = new List<TreeNode>();

        class TreeNode
        {
            public int Level { get; set; }
            public TreeNode Parent { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
            public string Value { get; set; }
            public int StartPos { get; set; }
            public int EndPos { get; set; }
        }
    }
}
