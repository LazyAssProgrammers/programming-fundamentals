// CONFIRMED from SMircheva
using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
			// Reading the miles from the console.
            var miles = double.Parse(Console.ReadLine());
			
			// Calculating the kilometers.
            var kms = miles * 1.60934;
			
			// ... and printing them.
            Console.WriteLine("{0:F2}", kms);
        }
    }
}
