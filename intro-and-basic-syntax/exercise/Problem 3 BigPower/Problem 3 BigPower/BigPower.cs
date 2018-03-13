using System;
using System.Numerics;
namespace Problem_3_BigPower
{
    class BigPower
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 0; i < number; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);
        }
    }
}
