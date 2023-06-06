using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProblemsUsingGenericsinCsharp
{
    internal class DeleteArrayElementUsingGenericsclass<T>
    {

        public static T[] DeleteMethod(T[] array, int index)
        {
            if(index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }

            T[] newArray = new T[array.Length - 1];
            int newArrayIndex = 0;

            for(int i=0; i < array.Length; i++)
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
