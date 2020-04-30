using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TestMaximum.TestCase;

namespace Test_Maximum.TestCase
{
    [TestFixture]
    class TestMaximum
    {
        [Test]
        public void givenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            int actualMax = maximumNumber.maximumInteger(225, 100, 14);
            Assert.AreEqual(225, actualMax);
        }
    }
  
}