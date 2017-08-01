using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public interface ITreeService<T> : ITreeChecker<T>, ITreeEditor<T>, 
        ITreeStorage<T>, ITreeVisualizer<T> where T : IComparable<T>
    {
    }
}
