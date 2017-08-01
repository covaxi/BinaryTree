using BinaryTree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    [TestFixture]
    public class BaseTest
    {
        protected ITreeService<int> Service { get; set; }

        [OneTimeSetUp]
        public void Setup()
        {
            Service = TreeService.Get<int>();
        }
    }
}
