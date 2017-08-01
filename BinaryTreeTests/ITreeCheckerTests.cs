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
    class ITreeCheckerTests : BaseTest
    {
        //[Test]
        public void CheckSearch(
            [Random(-39, 39, 2)] int num1,
            [Random(-100, -40, 2)] int num2,
            [Random(40, 100, 2)] int num3)
        {
            var tree = Service.Append(Service.Append(
                Service.Create(num1), Position.Left, num2),
                Position.Right, num3);

            Assert.That(Service.IsSearchTree(tree), Is.True);
        }

        //[Test]
        public void CheckNotSearch1(
            [Random(-100, -40, 2)]int num1,
            [Random(-39, 39, 2)] int num2,
            [Random(40, 100, 2)] int num3)
        {
            var tree = Service.Append(Service.Append(
                Service.Create(num1), Position.Left, num2),
                Position.Right, num3);

            Assert.That(Service.IsSearchTree(tree), Is.False);
        }

        [Test]
        public void CheckNotSearch2(
            [Random(-39, 39, 2)] int num1,
            [Random(40, 100, 2)] int num2,
            [Random(-100, -40, 2)] int num3)
        {
            var tree = Service.Append(Service.Append(
                Service.Create(num1), Position.Left, num2),
                Position.Right, num3);

            Assert.That(Service.IsSearchTree(tree), Is.False);
        }
    }
}
