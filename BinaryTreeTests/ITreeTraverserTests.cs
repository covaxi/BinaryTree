using BinaryTree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    class ITreeTraverserTests : BaseTest
    {
        [Test]
        public void TestNullArguments()
        {
            Assert.That(() => Service.Traverse(null), Throws.ArgumentNullException);
        }

        [Test]
        public void CheckTraverse(
            [Random(-100, 100, 2)] int num1,
            [Random(-100, 100, 2)] int num2,
            [Random(-100, 100, 2)] int num3)
        {
            var tree = Service.Create(num1);
            Service.Append(tree, Position.Left, num2);
            Service.Append(tree, Position.Right, num3);

            CollectionAssert.AreEqual(
                Service.Traverse(tree).ToList(),
                new[] { num1, num2, num3 }.ToList());
        }
    }
}
