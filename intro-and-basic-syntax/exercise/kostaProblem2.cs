using System;

namespace _02._Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the Console Rectangle side "a" and "b" 
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            //Calculate rectangle area
            double area = a * b;
            //Print result
            Console.WriteLine($"{area:f2}");
        }
    }
}
