using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

         List<int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int newNumber; 

        while ((newNumber = Convert.ToInt32(Console.ReadLine())) != 0)
        {
            numbersList.Add(newNumber);
            Console.WriteLine("Number added successfully!");
                    
        }                             
                
        int sum = numbersList.Sum();
        Console.WriteLine($"Sum of numbers in the list: {sum}");
    
        double average = numbersList.Average();
        Console.WriteLine($"Average of numbers in the list: {average}");
                            
        int max = numbersList.Max();
        Console.WriteLine($"The largest number in the list: {max}");
           
    }
}

