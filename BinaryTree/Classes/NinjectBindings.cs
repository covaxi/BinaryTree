using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(ITreeChecker<>)).To(typeof(TreeChecker<>));
            Bind(typeof(ITreeEditor<>)).To(typeof(TreeEditor<>));
            Bind(typeof(ITreeStorage<>)).To(typeof(TreeStorage<>));
            Bind(typeof(ITreeTraverser<>)).To(typeof(TreeTraverser<>));
            Bind(typeof(ITreeService<>)).To(typeof(TreeService<>));
        }
    }
}
