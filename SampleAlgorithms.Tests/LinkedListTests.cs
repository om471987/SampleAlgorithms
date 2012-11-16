using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SampleAlgorithms;

namespace SampleAlgorithms.Tests
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void TestItTest()
        {
            Assert.IsTrue(LinkedList.TestIt());
        }
        
    }
}
