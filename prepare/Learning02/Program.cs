using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Console.Write("What is your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        string letter = "";
        string sign = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (number >= 70)
        {
            Console.Write("Congratulations on passing the course!");
        }
        else
        {
            Console.Write("Keep up the good work, you'll pass next time!!");
        }
        int lastNumber = number % 10;
        if (lastNumber >= 7)
        {
            if (letter != "A" || letter != "F")
            {
                sign = "+";
            }
            else
            {
                sign = " ";
            }
        }
        else if (lastNumber < 3)
        {
            if (letter != "F")
            {
                sign = "-";
            }
            else
            {
                sign = " ";
            }
        }
        Console.WriteLine($"Your grade is: {letter}{sign}"); 
    
    }
}