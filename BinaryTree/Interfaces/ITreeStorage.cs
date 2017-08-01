using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// An interface to serialize and deserialize a binary tree to or from Streams
    /// </summary>
    /// <typeparamref name="T">A type of a tree node value</typeparamref>
    public interface ITreeStorage<T> where T : IComparable<T>
    {
        /// <summary>
        /// Save a tree to a stream
        /// </summary>
        /// <param name="tree">The tree to save</param>
        /// <param name="stream">The stream</param>
        void Save(Stream stream, Tree<T> tree);

        /// <summary>
        /// Load a tree from a stream
        /// </summary>
        /// <param name="stream">A strean with a tree</param>
        /// <returns>A tree loaded from the stream</returns>
        Tree<T> Load(Stream stream);
    }
}
