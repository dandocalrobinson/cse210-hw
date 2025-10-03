using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = AskName();
        int num = AskNum();
        int BR;
        Yearnum(out BR);
        int squared = SquareNumber(num);
        DisplayResult(name, squared, BR);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string AskName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); return name;
    }
    static int AskNum()
    {
        Console.Write("Enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int Yearnum(out int BR)
    {
        Console.Write("Enter your birth year: ");
        BR = int.Parse(Console.ReadLine());
        return BR;
    }
    static int SquareNumber(int num)
    {
        int squared = num * num;
        return squared;
    }
    static void DisplayResult(string name, int squared, int BR)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}.");

        int currentYear = DateTime.Now.Year;
        int age = currentYear - BR;
        Console.WriteLine($"{name}, you will turn {age} this year.");

    }
    
}
