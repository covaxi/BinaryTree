using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeService<T> : ITreeChecker<T>, ITreeEditor<T>, ITreeStorage<T> where T : IComparable<T>
    {
        public Tree<T> Append(Tree<T> parent, Position position, T value, Action<Tree<T>> operation = null)
        {
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
            operation?.Invoke(node);
            return parent;
        }

        public Tree<T> Create(T value)
        {
            return new Tree<T>(value);
        }

        public bool IsSearchTree(Tree<T> tree)
        {
            return tree.IsSearch;
        }

        public Tree<T> Load(Stream stream)
        {
            throw new NotImplementedException();
        }

        public Stream Save(Tree<T> tree)
        {
            throw new NotImplementedException();
        }
    }
}
