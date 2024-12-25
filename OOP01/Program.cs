using OOP01.Enums;
using OOP01.Models;
using OOP01.Q1;
using OOP01.Q2;
using System.Drawing;
using System.Net.WebSockets;
namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            //for (int i = 0; i < Enum.GetValues<WeekDays>().Length; i++)
            //{
            //    Console.WriteLine(Enum.GetValues<WeekDays>()[i]);
            //}
            #endregion

            #region Q2. Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //bool SeasonFlag = false;
            //Season SelectedSeason;
            //do
            //{
            //    Console.Write("Enter a Season: ");
            //    string Season = Console.ReadLine();
            //    SeasonFlag = Enum.TryParse<Season>(Season, true, out SelectedSeason);
            //}
            //while (!SeasonFlag);

            //switch (SelectedSeason)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("March, April and May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("June, July and August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("September, October and November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("December, January and February");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}
            #endregion

            #region Q3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum, Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
            //Employee E1 = new Employee();
            //E1.Name = "Ahmed";
            //E1.Age = 30;
            //Permissions P;
            //bool PermissionFlag = false;
            //bool Restart = true;
            //do
            //{

            //    do
            //    {
            //        Console.Write($"Enter a permissions to (add to or remove from) {E1.Name}: ");
            //        string Permission = Console.ReadLine();
            //        PermissionFlag = Enum.TryParse<Permissions>(Permission, true, out P);
            //    } while (!PermissionFlag);

            //    E1.Permissions = E1.Permissions ^ P;

            //    Console.WriteLine($"Current {E1.Name} Permissions: {E1.Permissions}");

            //    Console.Write("Do you want to add or remove more permissions? (Press Y or N) => ");
            //    Restart = Console.ReadKey().KeyChar == 'y' ? true : false;
            //    Console.WriteLine();
            //} while (Restart);
            #endregion

            #region Q4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not
            //Colors SelectedColor;
            //Console.Write("Enter a Color: ");
            //string Color = Console.ReadLine();
            //bool SeasonFlag = Enum.TryParse<Colors>(Color, true, out SelectedColor);

            //if (SeasonFlag)
            //{
            //    Console.WriteLine($"{Color} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Color} is not a primary color");
            //}
            #endregion

            #region Q5. Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point P1 = new Point();
            //Console.WriteLine("Enter Point 1 Coordinates:");
            //Console.Write("Enter X1: ");
            //P1.X = int.Parse(Console.ReadLine());
            //Console.Write("Enter Y1: ");
            //P1.Y = int.Parse(Console.ReadLine());

            //Console.WriteLine("--------------------------------");

            //Point P2 = new Point();
            //Console.WriteLine("Enter Point 2 Coordinates:");
            //Console.Write("Enter X2: ");
            //P2.X = int.Parse(Console.ReadLine());
            //Console.Write("Enter Y2: ");
            //P2.Y = int.Parse(Console.ReadLine());

            //double Distance = Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
            //Console.WriteLine($"Distance between ({P1.X},{P1.Y}) and ({P2.X}, {P2.Y}) is {Distance}");
            #endregion
        }
    }
}
