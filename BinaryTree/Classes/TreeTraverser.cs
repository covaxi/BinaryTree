using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeTraverser<T> : ITreeTraverser<T> where T : IComparable<T>
    {
        public IEnumerable<T> Traverse(Tree<T> tree)
        {
            Helpers.Check(tree, nameof(tree));

            var queue = new Queue<Tree<T>>();

            queue.Enqueue(tree);

            while (queue.Any())
            {
                var node = queue.Dequeue();
                yield return node.Value;

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }

                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
        }
    }
}
