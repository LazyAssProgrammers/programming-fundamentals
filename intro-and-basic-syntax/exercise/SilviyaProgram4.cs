using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var baseTenNumber = Convert.ToInt32(newHexNumber, 16);

            //Print the base ten number
            Console.WriteLine(baseTenNumber);
        }
    }
}
