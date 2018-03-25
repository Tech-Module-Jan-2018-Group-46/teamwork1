using System;

namespace _01._Debit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing variables.
            int firstNum = int.Parse(Console.ReadLine());   // changed variable name
            int secondNum = int.Parse(Console.ReadLine());  //changed variable name
            int third = int.Parse(Console.ReadLine());        //Edited
            int forth = int.Parse(Console.ReadLine());        //Edited

            //Printing result.
            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {forth:d4}");
        }
    }
}