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
    public class TreeService<T> : ITreeService<T> where T : IComparable<T>
    {
        private ITreeChecker<T> checker { get; set; }
        private ITreeEditor<T> editor { get; set; }
        private ITreeStorage<T> storage { get; set; }
        private ITreeVisualizer<T> visualizer { get; set; }

        [Inject]
        public TreeService(ITreeChecker<T> checker, ITreeEditor<T> editor,
            ITreeStorage<T> storage, ITreeVisualizer<T> visualizer)
        {
            this.checker = checker;
            this.editor = editor;
            this.storage = storage;
            this.visualizer = visualizer;
        }

        public Tree<T> Append(Tree<T> parent, Position position, T value, Action<Tree<T>> operation = null)
        {
            return editor.Append(parent, position, value, operation);
        }

        public Tree<T> Create(T value)
        {
            return editor.Create(value);
        }

        public bool IsSearchTree(Tree<T> tree)
        {
            return checker.IsSearchTree(tree);
        }

        public Tree<T> Load(Stream stream)
        {
            return storage.Load(stream);
        }

        public Stream Save(Tree<T> tree)
        {
            return storage.Save(tree);
        }

        public string Show(Tree<T> tree)
        {
            return visualizer.Show(tree);
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
