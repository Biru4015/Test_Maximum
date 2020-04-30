using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum.TestCase
{
    public class GenericMaxValue<generic_type> where generic_type : IComparable
    {
        /// <summary>
        /// Method to find Max in given Types
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        public generic_type MaxValue(generic_type val1, generic_type val2, generic_type val3)
        {
            // compare and return maximum value else return default value
            if (val1.CompareTo(val2) >= 0 && val1.CompareTo(val3) >= 0)
            {
                return val1;
            }
            else if (val2.CompareTo(val1) >= 0 && val2.CompareTo(val3) >= 0)
            {
                return val2;
            }
            else if (val3.CompareTo(val1) >= 0 && val3.CompareTo(val2) >= 0)
            {
                return val3;
            }
            else return default;
        }
    }
}
