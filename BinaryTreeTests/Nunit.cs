using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeTests
{
    [TestFixture]
    public class NunitIntegrationTests
    {
        [TestCase]
        public void NunitInVs()
        {
            Assert.True(true, "NUnit is not Working inside Visual Studio");
        }
    }
}
