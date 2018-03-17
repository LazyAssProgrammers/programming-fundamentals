using System;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main()
        {
            // read the name, current and max stats from the console - each or a separate line
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // print the name and visualise the stats
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|',health)}{new string('.',maxHealth-health)}|");
            Console.WriteLine($"Energy: |{new string('|', energy)}{new string('.', maxEnergy - energy )}|");

        }
    }
}