using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        List<int> numbers = new List<int>();
        int inputNumber = -1;
        int sum = 0;
        float average = 0;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (inputNumber != 0)
        {
            Console.Write("Enter number:  ");
            string number = Console.ReadLine();
            inputNumber = int.Parse(number);
            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);

            }


        }
        foreach (int number in numbers)
        {
            sum += number;
            average = sum / (numbers.Count);
            
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
   
}