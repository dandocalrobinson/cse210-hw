using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbs = new List<int>();
        Console.WriteLine("Enter list of numbers (type '0' when you are finished):");
        while (true)
        {
            Console.Write("Enter a number: ");
            string inputnum = Console.ReadLine();
            if (int.TryParse(inputnum, out int number))
            {
                if (number == 0)
                {
                    break;
                }
                numbs.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid number. ");
            }

        }
        Console.WriteLine("You entered the following numbers:");
        foreach (int num in numbs)
        {
            Console.WriteLine(num);
        }
        int sum = 0;
        foreach (int num in numbs)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        double average = (double)sum / numbs.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = numbs[0];
        foreach (int num in numbs)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
        
    }
}