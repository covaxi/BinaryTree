using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public interface ITreeVisualizer<T> where T : IComparable<T>
    {
        /// <summary>
        /// Displays a tree in a text string
        /// </summary>
        /// <param name="tree">The tree</param>
        /// <returns>A text representation of the tree</returns>
        string Show(Tree<T> tree);
    }
}
