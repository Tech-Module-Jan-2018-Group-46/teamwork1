using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reveiving name from the console as string
            string name = Console.ReadLine();

            //Reveiving ingredients from the console as double
            double volume = double.Parse(Console.ReadLine());
            double energycontent = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            //Calculating sugar and energy content
            double sper100 = (sugar / 100) * volume;
            double eper100 = (energycontent / 100) * volume;

            //Writing result on the console
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{Math.Round(eper100, 2)}kcal, {Math.Round(sper100, 2)}g sugars");

        }
    }
}
