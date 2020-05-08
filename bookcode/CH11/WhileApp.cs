using System;

class WhileApp
{
    const int MIN = 1;
    const int MAX = 10;
    const string QUIT_CHAR = "Q";

    public static void Main()
    {
        Random rnd = new Random();
        double correctNumber;

        string inputString;
        int userGuess;

        bool correctGuess = false;
        bool userQuit = false;

        while (!correctGuess && !userQuit)
        {
            correctNumber = rnd.NextDouble() * MAX;
            correctNumber = Math.Round(correctNumber);

            Console.Write
                ("Guess a number between {0} and {1}...({2} to quit)", 
                MIN, MAX, QUIT_CHAR);
            inputString = Console.ReadLine();

            if (0 == string.Compare(inputString, QUIT_CHAR, true))
                userQuit = true;
            else 
            {
                userGuess = inputString.ToInt32();
                correctGuess = (userGuess == correctNumber);

                Console.WriteLine("The correct number was {0}\n", correctNumber);
            }
        }

        if (correctGuess && !userQuit)
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Maybe next time!");
        }
    }
}
