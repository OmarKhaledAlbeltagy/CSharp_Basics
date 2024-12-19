using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CS04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //bool TryParseFlag = false;
            //int Number = 0;
            //while (!TryParseFlag || Number <= 0) {
            //    Console.Write("Enter an integer higher than zero: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}
            //for (int i = 1; i <= Number; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q2. Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //bool TryParseFlag = false;
            //int Number = 0;

            //while (!TryParseFlag)
            //{
            //    Console.Write("Enter an integer: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //for (int i = 0; i <= 12; i++)
            //{
            //    Console.WriteLine($"{Number} x {i} = {Number * i}");
            //}
            #endregion

            #region Q3. Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //bool TryParseFlag = false;
            //int Number = 0;

            //while (!TryParseFlag)
            //{
            //    Console.Write("Enter an integer: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //if (Number >= 0)
            //{
            //    for (int i = 0; i <= Number; i++)
            //    {
            //        if (i % 2 == 0 && i != 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            //else
            //{
            //    for (int i = -1; i >= Number; i--)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }

            //}
            #endregion

            #region Q4. Write a program that takes two integers then prints the power
            //bool TryParseFlagNumber1 = false;
            //bool TryParseFlagNumber2 = false;
            //int Number = 0;
            //int Power = 0;
            //while (!TryParseFlagNumber1)
            //{
            //    Console.Write("Enter first integer: ");
            //    TryParseFlagNumber1 = int.TryParse(Console.ReadLine(), out Number);

            //}

            //while (!TryParseFlagNumber2)
            //{
            //    Console.Write("Enter second integer: ");
            //    TryParseFlagNumber2 = int.TryParse(Console.ReadLine(), out Power);
            //}

            ////Solve 1 using pow method
            //Console.WriteLine($"{Number}^{Power} = {Math.Pow(Number, Power)}");


            ////Solve 2 using for loop
            //double result = 1;
            //if (Power >= 0)
            //{
            //    for (int i = 0; i < Power; i++)
            //    {
            //        result *= Number;
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i > Power; i--)
            //    {
            //        result /= Number;
            //    }
            //}
            //Console.WriteLine($"{Number}^{Power} = {result}");
            #endregion

            #region Q5.Write a program to allow the user to enter a string and print the REVERSE of it
            //Console.Write("Enter a text to reverse: ");
            //string input = Console.ReadLine();

            //StringBuilder ReversedString = new StringBuilder();
            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    ReversedString.Append(input[i]);
            //}

            //Console.WriteLine("Reversed text: " + ReversedString.ToString());
            #endregion

            #region Q6. Write a program in C# Sharp to find prime numbers within a range of numbers
            //bool TryParseFlagNumber1 = false;
            //bool TryParseFlagNumber2 = false;
            //int Number1 = 0;
            //while (!TryParseFlagNumber1 || Number1 <= 0)
            //{
            //    Console.Write("Enter the first integer higher than zero: ");
            //    TryParseFlagNumber1 = int.TryParse(Console.ReadLine(), out Number1);
            //}
            //int Number2 = 0;
            //while (!TryParseFlagNumber2 || Number2 < Number1)
            //{
            //    Console.Write("Enter the second integer higher than first Number: ");
            //    TryParseFlagNumber2 = int.TryParse(Console.ReadLine(), out Number2);
            //}

            //for (int i = Number1; i <= Number2; i++)
            //{
            //    bool IsPrime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            IsPrime = false;
            //        }
            //    }
            //    if (!IsPrime)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q7.Write a program in C# Sharp to convert a decimal number into binary without using an array
            //bool TryParseFlag = false;
            //decimal Number = 0;
            //while (!TryParseFlag)
            //{
            //    Console.Write("Enter a decimal: ");
            //    TryParseFlag = decimal.TryParse(Console.ReadLine(), out  Number);

            //}

            //int IntegerPart = (int)Number;
            //decimal FractionalPart = Number - IntegerPart;


            ////Convert integer part to binary
            //string IntegerBinaryResult = string.Empty;
            //if (IntegerPart == 0)
            //{
            //    IntegerBinaryResult = "0";
            //}
            //else
            //{

            //    while (IntegerPart > 0)
            //    {
            //        int Remainder = IntegerPart % 2;
            //        IntegerBinaryResult = Remainder + IntegerBinaryResult;
            //        IntegerPart /= 2;
            //    }
            //}


            ////Convert fractional part to binary
            //string FractionalBinaryResult = string.Empty;

            //while (FractionalPart > 0 && FractionalBinaryResult.Length < 10)
            //{
            //    FractionalPart *= 2;
            //    if (FractionalPart >= 1)
            //    {
            //        FractionalBinaryResult += "1";
            //        FractionalPart -= 1;
            //    }
            //    else
            //    {
            //        FractionalBinaryResult += "0";
            //    }
            //}


            ////display result
            //Console.WriteLine($"Binary result: {IntegerBinaryResult + (FractionalBinaryResult.Length > 0 ? "."+ FractionalBinaryResult : "")}");
            #endregion

            #region Q8. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n
            //Console.Write("Enter the size of the matrix: ");
            //bool TryParseFlag = false;
            //int Number = 0;

            //while (!TryParseFlag)
            //{
            //    Console.Write("Enter an integer: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //for (int i = 0; i < Number; i++)
            //{
            //    for (int j = 0; j < Number; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q9. Write C# program that Extract a substring from a given string
            //Console.Write("Enter some text: ");
            //string OriginalString = Console.ReadLine();

            //bool TryParseFlag = false;
            //int index = 0;
            //while (!TryParseFlag || index < 0 || index >= OriginalString.Length)
            //{
            //    Console.Write($"Enter the index to substring between 0 and {OriginalString.Length-1}: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out index);
            //}
            //Console.WriteLine($"Result: {OriginalString.Substring(index)}");
            #endregion

            #region Q10. Write C# program that take two string variables and print them as one variable
            //Console.Write("Enter first string: ");
            //string FirstString = Console.ReadLine();

            //Console.Write("Enter second string: ");
            //string SecondString = Console.ReadLine();

            //StringBuilder Result = new StringBuilder();
            //Result.Append(FirstString);
            //Result.Append(" ");
            //Result.Append(SecondString);
            //Console.WriteLine(Result);
            #endregion

            #region Q11. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the matrix: ");
            //bool TryParseFlag = false;
            //int Number = 0;

            //while (!TryParseFlag)
            //{
            //    Console.Write("Enter an integer: ");
            //    TryParseFlag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //for (int i = 0; i < Number; i++)
            //{
            //    for (int j = 0; j < Number; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12. write a program in C# Sharp to find the sum of all elements of the array.
            //int[] arr = { 1, 2, 3, 4, 5 };

            ////using sum() method
            //Console.WriteLine($"Result = {arr.Sum()}");

            ////using for loop
            //int result = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result += arr[i];
            //    Console.Write(arr[i]);
            //    if (i < arr.Length - 1)
            //    {
            //        Console.Write(" + ");
            //    }
            //}
            //Console.Write($" = {result}");
            #endregion

            #region Q13. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9, 10 };

            //int[] MergedArray = new int[arr1.Length + arr2.Length];
            //arr1.CopyTo(MergedArray, 0);
            //arr2.CopyTo(MergedArray, arr1.Length);
            //Array.Sort(MergedArray);
            //foreach (int i in MergedArray)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion

            #region Q14. Write a program in C# Sharp to count the frequency of each element of an array
            //int[] arr = { 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 7, 8, 8, 8, 8, 8, 9, 9, 10, 11, 12 };

            //bool[] Alreadychecked = new bool[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Alreadychecked[i])
            //    {

            //    }
            //    else
            //    {
            //        int count = 0;
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //                Alreadychecked[j] = true;
            //            }
            //        }
            //        Console.WriteLine($"{arr[i]} => appears {count} times");
            //    }
            //}
            #endregion

            #region Q15. Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] arr = { 1, 2, 3, 4, 5 };

            ////using max and min methods
            //Console.WriteLine($"Maximum element is {arr.Max()}");
            //Console.WriteLine($"Minimum element is {arr.Min()}");


            ////using for loop
            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }  
            //}
            #endregion

            #region Q16. Write a program in C# Sharp to find the second largest element in an array
            //int[] arr = { 1, 2, 3, 4, 5 };

            //int MaxValue = 0;
            //int SecondMaxValue = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > MaxValue)
            //    {
            //        SecondMaxValue = MaxValue;
            //        MaxValue = arr[i];
            //    }
            //    else if (arr[i] > SecondMaxValue && arr[i] != MaxValue)
            //    {
            //        SecondMaxValue = arr[i];
            //    }
            //}
            //Console.WriteLine($"The second largest element is: {SecondMaxValue}");
            #endregion

            #region Q17. Consider an Array of Integer values with size N, having values as in this Example
            //// { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 }
            ////write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).

            //bool TryParseSizeFlag = false;
            //int Size = 0;
            //while (!TryParseSizeFlag || Size <= 0)
            //{
            //    Console.Write("Enter the size of the array: ");
            //    TryParseSizeFlag = int.TryParse(Console.ReadLine(), out Size);
            //}
            //int[] arr = new int[Size];
            //for (int i = 0; i < Size; i++)
            //{

            //    bool TryParseItemFlag = false;
            //    int value = 0;
            //    while (!TryParseItemFlag)
            //    {
            //        Console.Write($"Enter ELement #{i}: ");
            //        TryParseItemFlag = int.TryParse(Console.ReadLine(), out value);
            //    }
            //    arr[i] = value;
            //}


            //int MaxDistance = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > MaxDistance)
            //            {
            //                MaxDistance = distance;
            //            }

            //        }
            //    }
            //}
            //Console.WriteLine($"Max Distance = {MaxDistance}");
            #endregion

            #region Q18. Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[rows, cols];
            //int[,] arr2 = new int[rows, cols];


            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element [{i},{j}]: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q19. Write a Program to Print One Dimensional Array in Reverse Order
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine($"{arr[i]}");
            //}
            #endregion
        }
    }
}
