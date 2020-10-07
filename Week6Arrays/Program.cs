using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "lose your smartphone", "fall in love", "Buy youtube premium", "get addicted to crack" };
            //today you will...
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, predictions.Length + 1);
            Console.WriteLine($"Today you will{predictions[randomIndex]}");

        }
        
    }
}
