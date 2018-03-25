// CONFIRMED by kratun
using System;

namespace HexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
            double proportion = volume / 100.0;
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, energyContent * proportion, sugarContent * proportion);
            //wrong task
            ////Console input
            //var hexNumber = Console.ReadLine();

            ////We make new string from second index to the end of inserted number
            //var newHexNumber = hexNumber.Substring(2);

            ////Convert the string to integer base ten
            //var tenBaseNumber = Convert.ToInt32(newHexNumber, 16);

            ////Print the base ten number
            //Console.WriteLine(tenBaseNumber);
        }
    }
}
