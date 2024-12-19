namespace CS02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Enter a Number");
            try
            {
                int Number = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------");
                Console.WriteLine("The inserted number is: " + Number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion
            #region Q2: Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //1
            int x;
            /*When a new variable is defined, a specific space is allocated on the stack (4 bytes in the case of int), 
              regardless of whether it has a value or not*/
            //2
            int y = 5;
            /*Similar to the previous line, 4 bytes will be allocated on the stack for the variable y*/
            //3
            x = y;
            /*in the stack, the value stored in y (5) is copied to the space allocated for x*/
            #endregion
            #region Q3: Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //1
            Points P1 = new Points();
            /*In the heap, 8 bytes will be allocated for the variable P1 (4 bytes for X and 4 bytes for Y), 
              and the address will be stored in the stack*/
            //2
            Points P2 = new Points();
            /*Similar to the previous line, another 8 bytes will be allocated for the variable P2, 
              and another address for it will be stored in the stack*/
            //3
            P1 = P2;
            /*In the stack, the address of P1 will be changed to the address of P2 object in the heap, 
              and the old value of P1 in the heap will become an unreachable object, this unreachable object will be deleted
              once the garbage collector get run*/
        }
    }
}
