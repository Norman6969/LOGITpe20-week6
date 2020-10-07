using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "red", "blue", "white", "green", "pink" };
            string[] patterns = { "flowery", "striped", "polka dot", "circles", "chequer" };


            Console.WriteLine("Do you need help with picking an outfit");
            string UserInput = Console.ReadLine();
            if (UserInput == "no")
            {
                Console.WriteLine("Farewell");
            }else
            {
                Console.WriteLine($"Today you should wear" +
                    $"{colors[rnd.Next(0, colors.Length)]}" +
                    $"{patterns[rnd.Next(0, patterns.Length)]} " +
                    $"{wardrobe[rnd.Next(0, wardrobe.Length)]}");
            }
        }
    }
}
