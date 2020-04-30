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
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [Test]
        public void givenMaxNumFirstPosition_whenFindMaxNum_shouldReturnsMaxFirst()
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            int actualMax = maximumNumber.maximumInteger(225, 100, 14);
            Assert.AreEqual(225, actualMax);
        }

        /// <summary>
        /// Test case 1.2
        /// </summary>
        [Test]
        public void givenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            int actualMax = maximumNumber.maximumInteger(225, 375, 157);
            Assert.AreEqual(375, actualMax);
        }
    }
  
}