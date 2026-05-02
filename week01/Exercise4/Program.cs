using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0) break;
            numbers.Add(number);
        } while (number != 0);
        double sum = 0.0;
        int largest = -100000;
        int smallest = 100000;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
            if (numbers[i] < smallest && numbers[i] > 0)
            {
                smallest = numbers[i];
            }
        }
        double average = sum / numbers.Count;
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + largest);
        Console.WriteLine("The smallest positive number is: " + smallest);
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}