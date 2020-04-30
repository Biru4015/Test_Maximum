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

        /// <summary>
        /// Test case 1.3
        /// </summary>
        [Test]
        public void givenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            int actualMax = maximumNumber.maximumInteger(225, 375, 467);
            Assert.AreEqual(467, actualMax);
        }

        /// <summary>
        /// Test case 2.1
        /// </summary>
        [Test]
        public void givenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            MaximumNumber maximumNumber = new MaximumNumber();
            double actualMax = maximumNumber.doubleArray(55.5,40.5,20.5);
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.2
        /// </summary>
        [Test]
        public void givenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            MaximumNumber maximumnumber = new MaximumNumber();
            double actualMax = maximumnumber.doubleArray(40.5, 55.5, 20.5);
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.3
        /// </summary>
        [Test]
        public void givenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            MaximumNumber maximumnumber = new MaximumNumber();
            double actualMax = maximumnumber.doubleArray(40.5, 55.5, 20.5);
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test 3.1
        /// </summary>
        [Test]
        public void givenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            MaximumNumber maximum = new MaximumNumber();
            String actualMax = maximum.MaxString("Peach","Banana","Apple");
            Assert.AreEqual("Peach",actualMax);
        }

        /// <summary>
        /// Test 3.2
        /// </summary>
        [Test]
        public void givenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            MaximumNumber maximum = new MaximumNumber();
            String actualMax = maximum.MaxString("Banana", "Peach", "Apple");
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test 3.1
        /// </summary>
        [Test]
        public void givenMaxStringThirdPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            MaximumNumber maximum = new MaximumNumber();
            String actualMax = maximum.MaxString("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", actualMax);
        }
    }
}