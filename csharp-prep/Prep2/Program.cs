using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Which is your grade percentage? ");
        string gradep = Console.ReadLine();

        int grade = int.Parse(gradep);

        if (grade >= 90) 
        {
            Console.WriteLine("Your grade is A");
        }
        else if (grade >= 80) 
        {
            Console.WriteLine("Your grade is B");
        }
        else if (grade >= 70) 
        {
            Console.WriteLine("Your grade is C");
        }
        else if (grade >= 60) 
        {
            Console.WriteLine("Your grade is D");
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your grade is F");
        }
        else
        {
            Console.WriteLine("I don't understand, please try it again. ");
        }
    }
}