using BinaryTree;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    [TestFixture]
    public class ITreeEditorTests : BaseTest
    {
        [Test]
        public void Create([Random(-100, 100, 2)] int num)
        {
            var tree = Service.Create(num);

            Assert.That(tree, Is.Not.Null);
            Assert.That(tree.Left, Is.Null);
            Assert.That(tree.Right, Is.Null);
            Assert.That(tree.Value, Is.EqualTo(num));
        }

        [Test]
        public void Append([Random(-100, 100, 2)] int num,
            [Values(Position.Left, Position.Right)] Position position)
        {
            var tree = Service.Create(123);
            Assert.That(Service.Append(tree, position, num), Is.EqualTo(tree));

            var correctSubNode = position == Position.Left ? tree.Left : tree.Right;
            var otherSubNode = position == Position.Left ? tree.Right : tree.Left;


            Assert.That(correctSubNode, Is.Not.Null);
            Assert.That(otherSubNode, Is.Null);
            Assert.That(correctSubNode.Value, Is.EqualTo(num));
        }

        [Test]
        public void DoubleAppend([Random(-100, 100, 2)] int num,
            [Values(Position.Left, Position.Right)] Position position)
        {
            var tree = Service.Create(123);
            Assert.That(Service.Append(tree, position, num), Is.EqualTo(tree));
            Assert.That(() => Service.Append(tree, position, num), Throws.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void AppendWithChild([Random(-100, 100, 2)] int num1,
            [Values(Position.Left, Position.Right)] Position position1,
            [Random(-100, 100, 2)] int num2,
            [Values(Position.Left, Position.Right)] Position position2)
        {
            var tree = Service.Create(123);
            Assert.That(Service.Append(tree, position1, num1, 
                node => Service.Append(node, position2, num2)
                ), Is.EqualTo(tree));

            var correctSubNode = position1 == Position.Left ? tree.Left : tree.Right;
            var otherSubNode = position1 == Position.Left ? tree.Right : tree.Left;

            Assert.That(correctSubNode, Is.Not.Null);
            Assert.That(otherSubNode, Is.Null);
            Assert.That(correctSubNode.Value, Is.EqualTo(num1));

            var correctChildNode = position2 == Position.Left ? correctSubNode.Left : correctSubNode.Right;
            var otherChildNode = position2 == Position.Right ? correctSubNode.Left : correctSubNode.Right;

            Assert.That(correctChildNode, Is.Not.Null);
            Assert.That(otherChildNode, Is.Null);
            Assert.That(correctChildNode.Value, Is.EqualTo(num2));
        }
    }
}
