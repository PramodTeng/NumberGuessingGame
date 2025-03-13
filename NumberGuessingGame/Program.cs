using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Greet user
            Console.WriteLine("Welcome contestant!");

            // Create random number
            var numberToGuess = new Random().Next(0, 100);

            //Create  invalid guessed number
            var userGuessedNumber = -1;

            // Until the user guessed the right number
            while (userGuessedNumber != numberToGuess)
            {
                // Tell user to guess a number
                Console.WriteLine("Take a guess what I'm thinking... Any number between 0 and 100");

                // Read user input
                var userInput = Console.ReadLine();

                // If the user entered a valid number
                if (int.TryParse(userInput, out userGuessedNumber))
                {
                    if (userGuessedNumber == numberToGuess)
                    {
                        // Congratulate the user for guessing the right number
                        Console.WriteLine($"Well done!!! You guessed right. I was thinking of {userGuessedNumber}.");
                        break;
                    }
                    else

                    {
                        // Check the user's guess
                        var a = userGuessedNumber < numberToGuess ? "higher" : "lower";
                        Console.WriteLine($"Not quite. I'm thinking of a number that is {a}.");
                    }
                }
                else
                {
                    // Inform user they entered an invalid number
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            //Thank user for playing
            Console.WriteLine("Thanks for Playing");

            Console.ReadLine();
        }
    }
}