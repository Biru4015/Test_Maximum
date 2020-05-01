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
            int[] arr = { 225, 100, 24 };
            GenericMaxValue<int> obj_maxvalue = new GenericMaxValue<int>(arr);
            int actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(225, actualMax);
        }

        /// <summary>
        /// Test case 1.2
        /// </summary>
        [Test]
        public void givenMaxNumSecondPosition_whenFindMaxNum_shouldReturnsMaxSecond()
        {
            int[] arr = { 225, 375, 157 };
            GenericMaxValue<int> obj_maxvalue = new GenericMaxValue<int>(arr);
            int actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(375, actualMax);
        }

        /// <summary>
        /// Test case 1.3
        /// </summary>
        [Test]
        public void givenMaxNumThirdPosition_whenFindMaxNum_shouldReturnsMaxThird()
        {
            int[] arr = { 225, 375, 467 };
            GenericMaxValue<int> obj_maxvalue = new GenericMaxValue<int>(arr);
            int actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(467, actualMax);
        }

        /// <summary>
        /// Test case 2.1
        /// </summary>
        [Test]
        public void givenFloatNumFirstPostion_whenFindMax_shouldReturnsMaxFirst()
        {
            double[] arr = { 55.5, 40.5, 20.5 };
            GenericMaxValue<double> obj_maxvalue = new GenericMaxValue<double>(arr);
            double actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.2
        /// </summary>
        [Test]
        public void givenFloatNumSecondPostion_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            double[] arr = { 40.5, 55.5, 20.5 };
            GenericMaxValue<double> obj_maxvalue = new GenericMaxValue<double>(arr);
            double actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 2.3
        /// </summary>
        [Test]
        public void givenFloatNumThirdPostion_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            double[] arr = { 40.5, 55.5, 20.5 };
            GenericMaxValue<double> obj_maxvalue = new GenericMaxValue<double>(arr);
            double actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(55.5, actualMax);
        }

        /// <summary>
        /// Test case 3.1
        /// </summary>
        [Test]
        public void givenMaxStringFirstPositon_whenFindMax_shouldReturnsMaxFirstPosition()
        {
            String[] arr = { "Peach", "Banana", "Apple" };
            GenericMaxValue<string> obj_maxvalue = new GenericMaxValue<string>(arr);
            String actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual("Peach",actualMax);
        }

        /// <summary>
        /// Test case 3.2
        /// </summary>
        [Test]
        public void givenMaxStringSecondPositon_whenFindMax_shouldReturnsMaxSecondPosition()
        {
            String[] arr = { "Banana", "Peach", "Apple"};
            GenericMaxValue<string> obj_maxvalue = new GenericMaxValue<string>(arr);
            String actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test case 3.3
        /// </summary>
        [Test]
        public void givenMaxStringThirdPositon_whenFindMax_shouldReturnsMaxThirdPosition()
        {
            String[] arr = { "Apple", "Banana", "Peach" };
            GenericMaxValue<string> obj_maxvalue = new GenericMaxValue<string>(arr);
            String actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual("Peach", actualMax);
        }

        /// <summary>
        /// Test case 4.1
        /// </summary>
        [Test]
        public void givenMoreThreeValue_whenFindMax_shouldReturnsMaxValue()
        {
            int[] arr = { 67, 23, 99, 44 };
            GenericMaxValue<int> obj_maxvalue = new GenericMaxValue<int>(arr);
            int actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(99,actualMax);
        }

        /// <summary>
        /// Test case 4.2
        /// </summary>
        [Test]
        public void givenMoreThreeValue1_whenFindMax_shouldReturnsMaxValue()
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            GenericMaxValue<int> obj_maxvalue = new GenericMaxValue<int>(arr);
            int actualMax = obj_maxvalue.MaxMethod();
            Assert.AreEqual(678, actualMax);
        }
    }
}