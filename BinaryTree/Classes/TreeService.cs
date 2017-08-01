using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class TreeService<T> : ITreeService<T> where T : IComparable<T>
    {
        private ITreeChecker<T> checker { get; set; }
        private ITreeEditor<T> editor { get; set; }
        private ITreeStorage<T> storage { get; set; }
        private ITreeTraverser<T> visualizer { get; set; }

        [Inject]
        public TreeService(ITreeChecker<T> checker, ITreeEditor<T> editor,
            ITreeStorage<T> storage, ITreeTraverser<T> visualizer)
        {
            this.checker = Helpers.Check(checker, nameof(checker));
            this.editor = Helpers.Check(editor, nameof(editor));
            this.storage = Helpers.Check(storage, nameof(storage));
            this.visualizer = Helpers.Check(visualizer, nameof(visualizer));
        }

        public Tree<T> Append(Tree<T> parent, Position position, T value, Action<Tree<T>> operation = null)
        {
            Helpers.Check(parent, nameof(parent));
            Helpers.Check(value, nameof(value));
            return editor.Append(parent, position, value, operation);
        }

        public Tree<T> Create(T value)
        {
            Helpers.Check(value, nameof(value));
            return editor.Create(value);
        }

        public bool IsSearchTree(Tree<T> tree)
        {
            Helpers.Check(tree, nameof(tree));
            return checker.IsSearchTree(tree);
        }

        public Tree<T> Load(Stream stream)
        {
            Helpers.Check(stream, nameof(stream));
            return storage.Load(stream);
        }

        public void Save(Stream stream, Tree<T> tree)
        {
            Helpers.Check(stream, nameof(stream));
            Helpers.Check(tree, nameof(tree));
            storage.Save(stream, tree);
        }

        public IEnumerable<T> Traverse(Tree<T> tree)
        {
            Helpers.Check(tree, nameof(tree));
            return visualizer.Traverse(tree);
        }
    }

    public static class TreeService
    {
        static volatile StandardKernel kernel;
        static object lockObject = new object();

        /// <summary>
        /// Configure dependency injections
        /// </summary>
        static void Configure()
        {
            if (kernel == null)
            {
                lock(lockObject)
                {
                    if (kernel == null)
                    {
                        kernel = new StandardKernel();
                        kernel.Load<NinjectBindings>();
                    }
                }
            }
        }

        /// <summary>
        /// Get an IService instance with a selected type parameter
        /// </summary>
        /// <typeparam name="T">The type to use</typeparam>
        /// <returns>IService instance with a selected type parameter</returns>
        public static ITreeService<T> Get<T>() where T : IComparable<T>
        {
            Configure();
            return kernel.Get<ITreeService<T>>();
        }

    }
}
