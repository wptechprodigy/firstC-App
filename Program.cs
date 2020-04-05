using System;
using System.Threading;

namespace firstC_App
{
    class Program
    {
        private const string Congratulations = "Please be sure your to drink your Ovaltine.";

        static void Main(string[] args)
        {
            var randomNumber = new Random();
            int lowerBound = 1;
            Console.WriteLine("Please choose a number for the upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());
            int secretNumber = randomNumber.Next(lowerBound, upperBound + 1);
            int guessed = -1;
            string message = $"Please guess a number between {lowerBound} and {upperBound}!";

            while (guessed != secretNumber)
            {
                Console.WriteLine(message);

                Thread.Sleep(500);

                // Guess the middle of the possible numbers
                guessed = lowerBound + (upperBound - lowerBound) / 2;
                Console.WriteLine($"Guessing {guessed} between {lowerBound} and {upperBound}");

                if (guessed < secretNumber)
                {
                    // Set lowerBound to previous guess
                    message = "Higher!";
                    lowerBound = guessed;
                }
                else if (guessed > secretNumber)
                {
                    // Set upperBound to previous bound
                    message = "Lower!";
                    upperBound = guessed;
                }
            }

            Console.WriteLine(Congratulations);

            // string myPassword = "Pa$$w0rd";
            // string guess = "";

            // while (guess != myPassword)
            // {
            //     Console.WriteLine("Please enter the correct password:");
            //     string newGuess = Console.ReadLine();
            //     guess = newGuess;
            // }

            // Console.WriteLine("Pick a number:");

            // int times = int.Parse(Console.ReadLine());
            // var today = DateTime.Now;

            // Console.WriteLine("The current time is " + today);

            // for (int i = 0; i < times; i++)
            // {
            //     // variable declaration
            //     string greeting = "Hey CSharp...it's great learning C#.";
            //     Console.WriteLine($"This is {greeting} from me to C#");
            // }
        }
    }
}
