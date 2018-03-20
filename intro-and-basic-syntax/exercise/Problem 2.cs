using System;

namespace rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiving width and height as double from the console
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //Calculating area
            double area = width * height;

            //Writing the result on the console
            Console.WriteLine($"{area:f2}");
        }
    }
}
