using System;

namespace NumberGuessingGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Greet user
            Console.WriteLine("Welcome contestant!");

            //Create random number
            var numberToGuess = new Random().Next(0, 100);

            //Ask user for a number
            var userGuessedNumber = AskForNumber(numberToGuess);

            //Check the result
            CheckResult(numberToGuess, userGuessedNumber);
        }

        /// <summary>
        /// Ask user to guess a number
        /// </summary>
        /// <param name="numberToGuess">The number to guess by the user</param>
        /// <returns>the user's guessed number</returns>
        public static int AskForNumber(int numberToGuess)
        {
            //Create checked number with initial out of range value;
            var number = int.MaxValue;

            //until the number is valid
            while (number == int.MaxValue)
            {
                //Tell user to guess a number what he is thinking
                Console.WriteLine("Take a guess what I'm thinking... Any number between 0 and 100");

                //Read user input
                var userGuessedNumber = Console.ReadLine();

                //If the user entered a valid number
                if (int.TryParse(userGuessedNumber, out var guessednumber))
                    //Set the checked number to the guessed number
                    number = guessednumber;

                //Otherwise...
                else
                    //Inform user they entered an invalid number
                    Console.WriteLine("Please enter a valid number");
            }
            return number;
        }

        /// <summary>
        /// Check the user's guess Result
        /// </summary>
        /// <param name="numberToGuess">the number to guess by user</param>
        /// <param name="userGuessedNumber">the user guess number</param>

        public static void CheckResult(int numberToGuess, int userGuessedNumber)
        {
            //until the user guessed the right number
            while (numberToGuess != userGuessedNumber)
            {
                //check the user's guess if it is lower
                if (userGuessedNumber < numberToGuess)
                {
                    //Inform user with hint that number is higher
                    Console.WriteLine("Not quite. I'm thinking of a number that is higher ");
                }
                //check the user's guess if it is higher
                else if (userGuessedNumber > numberToGuess)
                {
                    //Inform user with hint that number is lower
                    Console.WriteLine("Not quite. I'm thinking of a number that is lower ");
                }
                // Ask for another guess
                userGuessedNumber = AskForNumber(numberToGuess);
            }
            //Congratulate the user for guessing the right number
            Console.WriteLine($"Well done!!! you guessed right. I was thinking of {userGuessedNumber}. Thanks for playing");
        }
    }
}