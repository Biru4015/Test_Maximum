using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum.TestCase
{
    public class GenericMaxValue<generic_type> where generic_type : IComparable
    {
        //variables
        public generic_type val1,val2,val3;

        /// <summary>
        /// This method is created for initialize the constructor of instance variable
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenericMaxValue(generic_type input_val1, generic_type input_val2, generic_type input_val3)
        {
            this.val1 = input_val1;
            this.val2 = input_val2;
            this.val3 = input_val3;
        }

        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public generic_type MaxMethod()
        {
            generic_type max = GenericMaxValue<generic_type>.MaxValue(val1, val2, val3);
            return max;
        }
        /// <summary>
        /// This method is created for finding max for given type
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        public static generic_type MaxValue(generic_type val1, generic_type val2, generic_type val3)
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
