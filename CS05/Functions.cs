using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS05
{
    internal class Functions
    {
        #region Q1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void Swap(int x, int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }

        public static void Swap(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        #endregion

        #region Q2. Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        #region Example 1
        public static int SumArray(int[] arr)
        {
            int Sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }

        public static int SumArray(ref int[] arr)
        {
            int Sum = 0;
            arr[0] = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }
        #endregion

        #region Example 2
        public static int SumArrayWithNewInstance(int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        public static int SumArrayWithNewInstance(ref int[] Arr)
        {
            int Sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion

        #endregion

        #region Q3. Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        public static void SummationAndSubtraction(int num1, int num2, out int sum, out int subtract)
        {
            sum = num1 + num2;
            if (num1 >= num2)
            {
                subtract = num1 - num2;
            }
            else
            {
                subtract = num2 - num1;
            }
           
        }
        #endregion

        #region Q4. Write a program in C# Sharp to create a function to calculate the sum of: (the individual digits of a given number) (Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7)
        public static int SumOfIndividualDigits(int Number)
        {
            string NumberToString = Number.ToString();
            int sum = 0;
            for (int i = 0; i < NumberToString.Length; i++)
            {
                sum += int.Parse(NumberToString[i].ToString());
            }
            return sum;
        }
        #endregion

        #region Q5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
        public static bool IsPrime(int Number)
        {
            if (Number <= 1)
            {
                return false;
            }
            if (Number == 2)
            {
                return true;
            }
            if (Number % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i <= Number / 2; i += 2)
            {
                if (Number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region Q6. Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        public static void MinMaxArray(ref int[] arr, ref int max, ref int min)
        {
            max = arr[0];
            min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
        }
        #endregion

        #region Q7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        public static long CalculateFactorial(int Number)
        {
            long Result = 1;
            for (int i = Number; i >= 1; i--)
            {
                Result *= i;
            }
            return Result;
        }
        #endregion

        #region Q8. Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        public static string ChangeCharacter(string Text, char NewCharacter, int index = 0)
        {
            char[] CharactersArray = Text.ToCharArray();
            CharactersArray[index] = NewCharacter;

            return new string(CharactersArray);
        }
        #endregion
    }
}
