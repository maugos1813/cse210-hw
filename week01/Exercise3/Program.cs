using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess (1-100)? ");
            guess = int.Parse(Console.ReadLine());

            Console.WriteLine($"Debug: magic={magicNumber}, guess={guess}");
            if (magicNumber > guess)
            {
                Console.WriteLine("The number is higher than your guess.");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("The number is lower than your guess.");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}