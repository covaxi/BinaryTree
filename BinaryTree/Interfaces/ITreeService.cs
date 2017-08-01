using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// An interface to deal with a binary tree
    /// </summary>
    /// <typeparam name="T">A tree value type</typeparam>
    public interface ITreeService<T> : ITreeChecker<T>, ITreeEditor<T>, 
        ITreeStorage<T>, ITreeTraverser<T> where T : IComparable<T>
    {
    }
}
