﻿// See https://aka.ms/new-console-template for more information

class Program
{
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0) 
        {
            throw new ArgumentException("Tablica nie może być pusta.");
        }

        double sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }

    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Średnia: {average}");
        
        Console.WriteLine("Hello, World!");
        Console.WriteLine("First modification");
        Console.WriteLine("second modification");
        Console.WriteLine("Third modification");
    }
}