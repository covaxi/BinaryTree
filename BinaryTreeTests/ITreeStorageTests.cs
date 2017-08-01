using BinaryTree;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    [TestFixture]
    class ITreeStorageTests : BaseTest
    {
        [Test]
        public void CheckSaveAndLoad(
            [Random(-100, 100, 2)] int num1,
            [Random(-100, 100, 2)] int num2,
            [Random(-100, 100, 2)] int num3)
        {
            
            var tree = Service.Append(Service.Append(
                Service.Create(num1), Position.Left, num2),
                Position.Right, num3);
            var file = Path.GetTempFileName();
            using (var stream = File.OpenWrite(file))
            {
                Service.Save(stream, tree);
            }

            Tree<int> expected;
            using (var stream = File.OpenRead(file))
            {
                expected = Service.Load(stream);
            }

            Assert.That(expected, Is.Not.Null);
            Assert.That(expected.Value, Is.EqualTo(tree.Value));
            Assert.That(expected.Left.Value, Is.EqualTo(tree.Left.Value));
            Assert.That(expected.Right.Value, Is.EqualTo(tree.Right.Value));

        }
    }
}
