using System;

namespace ibdibdibd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userBag = new string[5];
            int i = 0;
            while(i < userBag.Length)
            {
                Console.WriteLine("what's there in your bag");
                userBag[i] = Console.ReadLine();
                i++;
            }

            Random rnd = new Random();
            Console.WriteLine($"In case of zombie apocalypse you will have to" +
                $"fight zombies off with a {userBag[rnd.Next(0, userBag.Length)]}");
        }
    }
}
