using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblemsUsingGenericsinCsharp
{
    internal class MinimumFloatNumber
    {
        internal class MinimumNumber<T> where T : IComparable<T>
        {
            public static T FindFloatMinimum(T num1, T num2, T num3)
            {
                T minimum = num1;

                if (num2.CompareTo(minimum) < 0)
                {
                    minimum = num2;
                }

                if (num3.CompareTo(minimum) < 0)
                {
                    minimum = num3;
                }
                return minimum;
            }
        }
    }
}


