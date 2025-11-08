using System;
using System.Collections.Generic;
class Program
{
        static void Main(string[] args)
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int number = PromptUserNumber();
            int square = SquareNumber(number);
            int birthday;
            PromptUserBirthYear(out birthday);
            DisplayResult(userName,square,birthday);

        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name:  ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string score = Console.ReadLine();
            int number = int.Parse(score);
            return number;
        }
        static void PromptUserBirthYear(out int birthday)
        {
            Console.Write("Please enter the year you were born: ");
            string birthYear = Console.ReadLine();
            birthday = int.Parse(birthYear);
        }
        static int SquareNumber(int number)
        {
            int Square = number * number;
            return Square;
        }
        static void DisplayResult(string userName, int square, int birthday)
        {
            Console.WriteLine($"{userName} the square of your number is {square}"); 
            Console.WriteLine($"{userName} you will turn {2025-birthday}this year"); 
            
        }
}
