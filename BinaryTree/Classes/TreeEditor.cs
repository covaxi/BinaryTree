using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class TreeEditor<T> : ITreeEditor<T> where T : IComparable<T>
    {
        public Tree<T> Append(Tree<T> parent, Position position, T value)
        {
            Helpers.Check(parent, nameof(parent));
            Tree<T> node;
            var parentTree = parent as Tree<T>;
            if (parentTree == null)
            {
                throw new ArgumentException("Unable to work with another ITree implementation");
            }
            if (position == Position.Left)
            {
                node = parentTree.Left = new Tree<T>(value);
            }
            else
            {
                node = parentTree.Right = new Tree<T>(value);
            }
            return node;
        }

        public Tree<T> Create(T value)
        {
            return new Tree<T>(value);
        }
    }
}
