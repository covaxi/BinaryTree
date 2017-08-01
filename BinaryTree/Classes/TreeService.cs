using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeService<T> : ITreeChecker<T>, ITreeEditor<T>, ITreeStorage<T>
    {
        public ITree<T> Append(ITree<T> parent, Position position, T value, Action<ITree<T>> operation = null)
        {
            ITree<T> node;
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

        public ITree<T> Create(T value)
        {
            return new Tree<T>(value);
        }

        public bool IsBalancedTree(ITree<T> tree)
        {
            throw new NotImplementedException();
        }

        public bool IsSearchTree(ITree<T> tree)
        {
            throw new NotImplementedException();
        }

        public ITree<T> Load(Stream stream)
        {
            throw new NotImplementedException();
        }

        public ITree<T> Remove(ITree<T> parent, Position position)
        {
            throw new NotImplementedException();
        }

        public Stream Save(ITree<T> tree)
        {
            throw new NotImplementedException();
        }
    }
}
