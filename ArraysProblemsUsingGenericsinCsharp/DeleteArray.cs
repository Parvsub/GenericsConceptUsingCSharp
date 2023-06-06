using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblemsUsingGenericsinCsharp
{
    internal class DeleteArray
    {
        // Method to delete the corresponding element from the array
        public static object[] DeleteMethod(object[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            object[] newArray = new object[array.Length - 1];
            int newArrayIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != index)
                {
                    newArray[newArrayIndex] = array[i];
                    newArrayIndex++;
                }
            }

            return newArray;
        }
    }
}

