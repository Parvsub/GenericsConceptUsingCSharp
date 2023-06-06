using static ArraysProblemsUsingGenericsinCsharp.MinimumFloatNumber;

namespace ArraysProblemsUsingGenericsinCsharp
{
    class Program
    {
        static void Main()
        {
            {

                //object[] array = { 1, 2.5, 'A', 3.14, 'B' };
                //int index = 2;

                //object[] newArray = DeleteArray.DeleteMethod(array, index);

                //Console.WriteLine("Original array: " + string.Join(", ", array));
                //Console.WriteLine("New array: " + string.Join(", ", newArray));

                //object[] array = { 1, 2.5, 'A', 3.14, 'B' };
                //int index = 2;

                //object[] newArray = DeleteArrayElementUsingGenericsclass<object>.DeleteMethod(array, index);

                //Console.WriteLine("Original array: " + string.Join(", ", array));
                //Console.WriteLine("Modified array: " + string.Join(", ", newArray));

                //object[] array = { 1, 5.6, 'k', 'f', 4.14 };
                //int index = 4;

                //object[] newArray = DeleteArray.DeleteMethod(array, index);

                //Console.WriteLine("Original array: " + string.Join(", ", array));
                //Console.WriteLine("New array: " + string.Join(", ", newArray));


                //Get user input for three integers


                //Console.WriteLine("Enter the first integer:");
                //int num1 = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("Enter the first integer:");
                // int num2 = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("Enter the first integer:");
                // int num3 = Convert.ToInt32(Console.ReadLine());

                // int minimum = MinimumIntegerNumber<int>.FindMinimum(num1, num2, num3);

                // Console.WriteLine("The minimum number is : " + minimum);

                //Console.WriteLine("Enter the first float:");
                //float num1 = float.Parse(Console.ReadLine());


                //Console.WriteLine("Enter the second float:");
                //float num2 = float.Parse(Console.ReadLine());


                //Console.WriteLine("Enter the third float:");
                //float num3 = float.Parse(Console.ReadLine());

                //float minimum = MinimumNumber<float>.FindFloatMinimum(num1, num2, num3);

                //Console.WriteLine("The minimum number is : " + minimum);

                String string1 = "Mango";
                string string2 = "apple";
                string string3 = "Orange";

                string minimum = MinimumOfString.FindMinimum(string1, string2, string3);

                int minIntValue = RefactorCodeUsingGenerics.FindMinimum(6, 2, 3);
                Console.WriteLine("Minimum int value: " + minIntValue);

                float minFloatValue = RefactorCodeUsingGenerics.FindMinimum(2.5f, 1.3f, 2.8f);
                Console.WriteLine("Minimum float value: " + minFloatValue);

                string minStringValue = RefactorCodeUsingGenerics.FindMinimum("Carrat", "Brinjal", "Tomata");
                Console.WriteLine("Minumum String value: " + minStringValue);
            }
        }
    }
}