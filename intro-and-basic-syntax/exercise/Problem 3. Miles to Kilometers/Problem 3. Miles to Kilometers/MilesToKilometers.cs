using System;

namespace Problem_3._Miles_to_Kilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            double miles = double.Parse(Console.ReadLine());
            double result =  miles * 1.60934;

            Console.WriteLine($"{result:F2}");
        }
    }
}
