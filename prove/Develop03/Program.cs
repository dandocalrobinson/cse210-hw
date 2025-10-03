using System;

class Program
{
    static void Main(string[] args)
    {
        var randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);

        Console.Write("Guess the magic number between 1 and 100: ");

        int guess;
        int attempts = 0;

        while (!int.TryParse(Console.ReadLine(), out guess))
        {
            Console.Write("Please enter a valid integer: ");
        }
        attempts++;

        while (guess != randomNumber)
        {
            if (guess < randomNumber)
            {
                Console.Write("Too low. Try again: ");
            }
            else
            {
                Console.Write("Too high. Try again: ");
            }

            while (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.Write("Please enter a valid integer: ");
            }
            attempts++;
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Number of attempts: {attempts}");
    }
}