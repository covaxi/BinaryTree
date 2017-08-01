using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class TreeStorage<T> : ITreeStorage<T> where T : IComparable<T>
    {
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
