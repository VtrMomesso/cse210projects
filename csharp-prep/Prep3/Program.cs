using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guessCount = 0;

        while (true)
        {
 //           Console.WriteLine("What is the magic number? ");
 //           int magic_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());
            guessCount++;

            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congratulations! You guess it!");
                Console.WriteLine($"It was in {guessCount} guesses.");
                Console.WriteLine();
                break;
            }
        }
    }
}