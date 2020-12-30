using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameover = false;

            Random rand = new Random();
            int randomNumber = rand.Next(0, 10);
            Console.WriteLine(randomNumber);


            Console.WriteLine("Guess the Number Game");
            Console.WriteLine("=====================");
            Console.WriteLine("");
            Console.WriteLine("Guess the number from 0 - 10: ");

            while (!gameover)
            {
                string guess = Console.ReadLine();
                int convertedGuess = Convert.ToInt32(guess);

                if (convertedGuess == randomNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    gameover = true;
                }
                else if (convertedGuess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Try again");
                }
                else if (convertedGuess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again");
                }
            }
        }
    }
}
