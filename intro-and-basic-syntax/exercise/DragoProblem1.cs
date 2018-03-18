// CONFIRMED from kostanikolov
using System;

namespace DebitCardNumber
{
    class DebitCardNumbers
    {
        static void Main()
        {
            // We received four numbers from Console 
            int firstFourNumbers=int.Parse(Console.ReadLine());
            int secondFourDigits = int.Parse(Console.ReadLine());
            int thirdFourDigits = int.Parse(Console.ReadLine());
            int forthFourDigits = int.Parse(Console.ReadLine());
            //Prints received numbers in 4-digit debit card format
            Console.WriteLine($"{firstFourNumbers:D4} {secondFourDigits:D4} {thirdFourDigits:D4} {forthFourDigits:D4}");
            
        }
    }
}
