using System;

namespace _01._Debit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initializing variables.
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());        //Edited
            int forth = int.Parse(Console.ReadLine());        //Edited

            //Printing result.
            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {forth:d4}");
        }
    }
}