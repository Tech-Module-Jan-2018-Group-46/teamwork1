using System;

namespace _01._Debit
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            long third = long.Parse(Console.ReadLine());        //Edited
            long forth = long.Parse(Console.ReadLine());        //Edited

            Console.WriteLine($"{first:d4} {second:d4} {third:d4} {forth:d4}");
        }
    }
}