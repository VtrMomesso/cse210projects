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
            if (grade >= 97)
            {
                Console.WriteLine("Your grade is A+");
            }
            else if (grade <= 93)
            {
                Console.WriteLine("Your grade is A-");
            }
            else
            {
                Console.WriteLine("Your grade is A");
            }
            
        }
        else if (grade >= 80) 
        {
            if (grade >= 87)
            {
                Console.WriteLine("Your grade is B+");
            }
            else if (grade <= 83)
            {
                Console.WriteLine("Your grade is B-");
            }
            else
            {
                Console.WriteLine("Your grade is B");
            }
        }
        else if (grade >= 70) 
        {
            if (grade >= 77)
            {
                Console.WriteLine("Your grade is C+");
            }
            else if (grade <= 73)
            {
                Console.WriteLine("Your grade is C-");
            }
            else
            {
                Console.WriteLine("Your grade is C");
            }
        }
        else if (grade >= 60) 
        {
            if (grade >= 67)
            {
                Console.WriteLine("Your grade is D+");
            }
            else if (grade <= 63)
            {
                Console.WriteLine("Your grade is D-");
            }
            else
            {
                Console.WriteLine("Your grade is D");
            }
        }
        else if (grade < 60)
        {
            Console.WriteLine("Your grade is F");
        }
        else
        {
            Console.WriteLine("I don't understand, please try it again. ");
        }


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Pass.");
        }
        else
        {
            Console.WriteLine("Sorry, you don't pass, but you can try in the next semester.");
        }
    }
}