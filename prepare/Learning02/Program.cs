using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

        int lastDigit = percent % 10; 
        if (letter != "A" || letter != "F" )
        {
            if (lastDigit >= 7)
            {
                Console.WriteLine($"Your grade is: {letter}+");
            }
            else if (lastDigit < 3)
            {
                Console.WriteLine($"Your grade is: {letter}- ");
            }
            else
            {
            Console.WriteLine($"Your grade is: {letter}");;
            }

        }
    
    }
}