using System;

namespace Problem_3._Miles_to_Kilometers
{
    class MilesToKilometers
    {
        static void Main()
        {
            //Recieve miles from the Console as double
            double miles = double.Parse(Console.ReadLine());
            double resultmiles =  miles * 1.60934;       //Convert miles to km
            //print result
            Console.WriteLine($"{resultmiles:F2}");
        }
    }
}
