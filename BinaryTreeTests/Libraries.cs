using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    //TODO: Incinirate this later
    [TestFixture]
    public class NunitIntegrationTests
    {
        [TestCase]
        public void NunitInVs()
        {
            Assert.That(true, Is.True);
        }
    }
}
