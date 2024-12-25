using System.Diagnostics.Metrics;

namespace CS05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int a = 5, b = 10;
            ////1. Passing by value for value type parameter
            //Functions.Swap(a, b);
            //Console.WriteLine("Passing by value effect:");
            //Console.WriteLine($"a = {a}\nb = {b}");
            ////on passing by value for value type parameter the original values for a & b variables didn't affected, because the swap() function changed x & y values in the function stack frame

            ////2. passing by reference for value type parameter
            //Functions.Swap(ref a, ref b);
            //Console.WriteLine("\n\nPassing by reference effect:");
            //Console.WriteLine($"a = {a}\nb = {b}");
            ////on passing by reference for value type parameter the original values for a & b has been affected, because the swap() function got the references for the parameters which made changes for a & b in the main stack frame
            #endregion

            #region Q2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] arr = { 1, 2, 3 };
            ////Example 1:
            ////1. Passing by value for reference type parameter
            //Console.WriteLine("Example 1:");
            //int Sum1 = Functions.SumArray(arr);
            //Console.WriteLine($"SumArray(arr) = {Sum1}");
            //Console.Write("Array elements: ");
            //foreach (var item in arr)
            //{

            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            ////on passing by value for reference type parameter in this example, the address of the array is passed to the SumArray() function, so any changes in the array elements will effect the original values of the array in the heap

            ////2. Passing by reference for reference type parameter
            //Console.WriteLine("Example 1:");
            //int Sum2 = Functions.SumArray(ref arr);
            //Console.WriteLine($"SumArray(ref arr) = {Sum2}");
            //Console.Write("Array elements: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("------------------------------");
            ////on passing by reference for reference type parameter in this example, the reference for the array is passed to SumArray() function, so the result will be the same as the previous case (Passing by value), any changes in the array elements will effect the original values of the array in the heap


            ////Example 2:
            ////1. Passing by value for reference type parameter
            //Console.WriteLine("Example 2:");
            //int Sum3 = Functions.SumArrayWithNewInstance(arr);
            //Console.WriteLine($"SumArrayWithNewInstance(arr) = {Sum3}");
            //Console.Write("Array elements: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            ////on passing by value for reference type parameter in this example a new array with new location in the heap created due to this code (Arr = new int[] { 4, 5, 6 }), so the original array elements will stay the same but the sum result will be the sum of new array elements (4 + 5 + 6 = 15)

            ////2. Passing by reference for reference type parameter
            //Console.WriteLine("Example 2: ");
            //int Sum4 = Functions.SumArrayWithNewInstance(ref arr);
            //Console.WriteLine($"SumArrayWithNewInstance(ref arr) = {Sum4}");
            //Console.Write("Array elements: ");
            //foreach (var item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            ////on passing by reference for reference type parameter in this example, the reference of the original array will be changed to new address for a new location in the heap, this will cause to change the whole original array to new array, so the sum result will be (4 + 5 + 6 = 15), and the original array elements will be changed to {4, 5, 6}
            #endregion

            #region Q3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int a = 20, b = 10;
            //int sum, substract;
            //Functions.SummationAndSubtraction(a, b, out sum, out substract);
            //Console.WriteLine($"{a} + {b} = {sum}\n{a} - {b} = {substract}");
            #endregion

            #region Q4. Write a program in C# Sharp to create a function to calculate the sum of: (the individual digits of a given number) (Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7)
            //Console.Write("Enter a number:");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Functions.SumOfIndividualDigits(Number));
            #endregion

            #region Q5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //Console.Write("Enter a number:");
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine(Functions.IsPrime(Number));
            #endregion

            #region Q6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 10, 9, 8 };
            //int max = 0, min = 0;
            //Functions.MinMaxArray(ref arr, ref max, ref min);
            //Console.WriteLine($"Maximum value is: {max}");
            //Console.WriteLine($"Minimum value is: {min}");
            #endregion

            #region Q7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //bool ParseFlag = false;
            //int Number = 0;
            //while (!ParseFlag || Number <= 0) 
            //{
            //    Console.Write("Enter a positive Number: ");
            //    ParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //long Result = Functions.CalculateFactorial(Number);
            //Console.WriteLine($"{Number}! = {Result}");
            #endregion

            #region Q8. Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter some text: ");
            //string Text = Console.ReadLine();

            //bool ParsePositionFlag = false;
            //int Postion = -1;
            //while (!ParsePositionFlag || Postion < 0 || Postion >= Text.Length)
            //{
            //    Console.Write("Enter the position to replace: ");
            //    ParsePositionFlag = int.TryParse(Console.ReadLine(), out Postion);
            //}

            //bool ParseCharacterFlag = false;
            //char NewCharacter = '\0';
            //while (!ParseCharacterFlag || NewCharacter == '\0')
            //{
            //    Console.Write("Enter the new character: ");
            //    ParseCharacterFlag = char.TryParse(Console.ReadLine(), out NewCharacter);
            //}
   

            //string result = Functions.ChangeCharacter(Text, NewCharacter, Postion);
            //Console.WriteLine($"New text: {result}");
            #endregion
        }


    }
}
