using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum.TestCase
{
    class MaximumNumber
    {
        ///<summary>
        ///This method is created for getting mu
        /// </summary>
        public int maximumInteger(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                return 0;
            }
        }

        ///<summary>
        ///This is method is created for maximum float number
        /// </summary>
        public double doubleArray(double firstValue, double secondValue, double thirdValue)
        {
            double[] doubleNumber = { firstValue, secondValue, thirdValue };
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            else
            {
                return 0;
            }
        }

        public string MaxString(string firstString, string secondString, string thirdString)
        {
            // compare and return maximum value else return default value
            if (firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            else if (secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            else if (thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            else return default;
        }

    }
}
