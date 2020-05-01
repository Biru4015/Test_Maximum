using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum.TestCase
{
    public class GenericMaxValue<generic_type> where generic_type : IComparable
    {
        //variables
        public generic_type[] val;

        /// <summary>
        /// This method is created for initialize the constructor of instance variable
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenericMaxValue(generic_type[] val)
        {
            this.val = val;
        }

        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public generic_type MaxMethod(params generic_type[] values)
        {
            // Maxvalue method
            var max = MaxValue(this.val);
            return max;
        }

        /// <summary>
        /// Method to sort and retuen max value
        /// </summary>
        /// <param name="values"> list of value</param>
        /// <returns> maximum value among the list of given values</returns>
        public  generic_type MaxValue(params generic_type[] values)
        {
            // call sorting method
            var sorted_values = Sort(values);
            return sorted_values[^1];
        }

        /// <summary>
        /// This method is created for sorting the values
        /// </summary>
        /// <param name="values"></param>
        /// <returns>sortedValue</returns>
        public  generic_type[] Sort(generic_type[] values)
        {
            // a temporary variable
            /*generic_type temp;
            // bobble sort
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {   // if 1st element is less than to sencond values-> swap elements
                    if (values[i].CompareTo(values[j]) > 0)
                    {
                        temp = values[i];
                        values[i] = values[j];
                        values[j] = temp;
                    }
                }
            }*/
            Array.Sort(values);
            return values;
        }
    }
}
