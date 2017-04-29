using System;


namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
        
            int number = random.Next(1, 101);
            int guess = 0;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("What's your guess?");

            do
            {
                Console.WriteLine("Your guess: ");

                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("This was not a number!");
                    Console.WriteLine("Error Message: \n" + e);
                    return;
                }

                if (guess > number)
                {
                    Console.WriteLine("I'm thinking of a smaller number! Try again: ");
                }
                else if(guess < number)
                {
                    Console.WriteLine("I'm thinking of a larger number! Try again: ");
                }
                else
                {
                    Console.WriteLine("Correct! Well done!");
                    Console.WriteLine("Press any key to quit . . .");
                    Console.ReadKey();
                    return;
                }

            } while (guess != number);

            Console.WriteLine("Press any key to quit . . .");
            Console.ReadKey();
        }
    }
}
