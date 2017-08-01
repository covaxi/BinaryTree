using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public interface ITreeTraverser<T> where T : IComparable<T>
    {
        /// <summary>
        /// Gets all nodes containing in a tree level by level
        /// </summary>
        /// <param name="tree">The tree</param>
        /// <returns>List of nodes in a tree</returns>
        IEnumerable<T> Traverse(Tree<T> tree);
    }
}
