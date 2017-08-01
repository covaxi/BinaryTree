using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// An interface to check binary tree
    /// </summary>
    /// <typeparamref name="T">A type of a tree node value</typeparamref>
    public interface ITreeChecker<T>
    {
        /// <summary>
        /// Returns true if a tree is a binary search tree, false otherwise
        /// </summary>
        /// <param name="tree">A binary tree to check</param>
        /// <returns></returns>
        bool IsSearchTree(ITree<T> tree);

        /// <summary>
        /// Returns true if a tree is balanced, false otherwise
        /// </summary>
        /// <param name="tree">A binary tree to check</param>
        /// <returns></returns>
        bool IsBalancedTree(ITree<T> tree);
    }
}
