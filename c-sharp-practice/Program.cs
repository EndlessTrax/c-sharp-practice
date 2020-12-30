using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameover = false;

            // Create a random number beween 0-10, inclusive.
            Random rand = new Random();
            int randomNumber = rand.Next(0, 10);

            Console.WriteLine("Guess the Number Game");
            Console.WriteLine("=====================");
            Console.WriteLine("");
            Console.WriteLine("Guess the number from 0 - 10: ");

            while (!gameover)
            {
                string input = Console.ReadLine();
                int guess = Convert.ToInt32(input);

                if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    gameover = true;
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again");
                }
            }
        }
    }
}
