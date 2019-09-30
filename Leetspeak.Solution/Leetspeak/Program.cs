using System;
using Translator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence or phrase:");
        string input = Console.ReadLine();
        Leetspeak newLeetspeak = new Leetspeak();
        Console.WriteLine(newLeetspeak.Translate(input));
    }
}