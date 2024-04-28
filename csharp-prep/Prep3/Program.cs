using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("What is the magic number? ");
            int magic_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your guess? ");
            int guess = Convert.ToInt32(Console.ReadLine());

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
                break;
            }
        }
    }
}