using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guessNumber = -1;
            int count = 0;
            while (guessNumber != number)
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                count += 1;
                if (guessNumber > number)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guessNumber < number)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");

                }

            }
            Console.WriteLine($"You guessed {count} times. ");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
        



    }

}

