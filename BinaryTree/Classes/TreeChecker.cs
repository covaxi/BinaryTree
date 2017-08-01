using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class TreeChecker<T> : ITreeChecker<T> where T : IComparable<T>
    {
        public bool IsSearchTree(Tree<T> tree)
        {
            return tree.IsSearch;
        }
    }
}
