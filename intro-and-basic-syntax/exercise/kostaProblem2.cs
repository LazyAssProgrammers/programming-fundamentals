//CONFIRMED from cypetrova
using System;

namespace _02._Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the Console Rectangle side "a" and "b" 
            double lenght = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            //Calculate rectangle area
            double area = lenght * b;
            //Print result
            Console.WriteLine($"{area:f2}");
        }
    }
}
