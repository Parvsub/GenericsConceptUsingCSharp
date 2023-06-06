using System;
namespace ArraysProblemsUsingGenericsinCsharp
{
    internal class RefactorCodeUsingGenerics
    {
        public static T FindMinimum<T>(params T[] items) where T : IComparable<T>
        {
            if (items.Length == 0)
            {
                throw new ArgumentException("At least one item must be there.");
            }

            T minimum = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(minimum) < 0)
                {
                    minimum = items[i];
                }
            }
            return minimum;
        }
    }
}
