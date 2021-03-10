using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo();

            greetUser();

            while (true)
            {

                // random number 
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guessed number 
                int guess = 0;

                // ask user for number
                Console.WriteLine("guess a number between 1 and 10.");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    string newGuess = Console.ReadLine();

                    // check if number
                    if (!int.TryParse(newGuess, out guess))
                    {

                        printColorMessage(ConsoleColor.Red, "please enter a number");

                        continue;
                    }

                    // cast to int and put in the guess variable 
                    guess = Int32.Parse(newGuess);

                    // check if is correct

                    if (guess != correctNumber)
                    {
                        // display error message
                        printColorMessage(ConsoleColor.Red, "wrong number, please try again");
                    }
                }

                // guess is correct
                printColorMessage(ConsoleColor.Yellow, "congrats, you are correct!!");



                // play again
                Console.WriteLine("play again? [y/n]");

                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    continue;
                }
                else if (answer == "n")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }


        // display app info
        static void getAppInfo()
        {
            /// app vars
            string appName = "number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "maora";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();

        }


        // ask for name & greet
        static void greetUser()
        {
            // prompt for name
            Console.WriteLine("what is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("hello, {0}. let's play a game!", input);
        }

        // change color 

        static void printColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }

}
