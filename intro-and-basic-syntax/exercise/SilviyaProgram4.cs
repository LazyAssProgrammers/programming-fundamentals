using System;


namespace HexadecimalConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console input
            var hexNumber = Console.ReadLine();

            //We make new string from second index to the end of inserted number
            var newHexNumber = hexNumber.Substring(2);

            //Convert the string to integer base ten
            var tenBaseNumber = Convert.ToInt32(newHexNumber, 16);

            //Print the base ten number
            Console.WriteLine(tenBaseNumber);
        }
    }
}
