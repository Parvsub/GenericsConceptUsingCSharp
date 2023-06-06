using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblemsUsingGenericsinCsharp
{
    internal class MinimumOfString
    {
        public static T FindMinimum<T>(T value1, T value2, T value3) where T : IComparable<T>
        {
            T minimum = value1;
            if (value2.CompareTo(minimum) < 0)
            {
                minimum = value2;
            }
            if (value3.CompareTo(minimum) < 0)
            {
                minimum = value3;
            }
            return minimum;
        }
    }
}
