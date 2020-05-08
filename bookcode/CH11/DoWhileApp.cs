using System;

class DoWhileApp
{
    const int MIN = 1;
    const int MAX = 10;
    const string QUIT_CHAR = "Q";

    public static void Main()
    {
        Random rnd = new Random();
        double correctNumber;

        string inputString;
        int userGuess = -1;

        bool userHasNotQuit = true;

        do 
        {
            correctNumber = rnd.NextDouble() * MAX;
            correctNumber = Math.Round(correctNumber);

            Console.Write
                ("Guess a number between {0} and {1}...({2} to quit)", 
                MIN, MAX, QUIT_CHAR);
            inputString = Console.ReadLine();

            if (0 == string.Compare(inputString, QUIT_CHAR, true))
                userHasNotQuit = false;
            else
            {
                userGuess = inputString.ToInt32();
                Console.WriteLine
                    ("The correct number was {0}\n", correctNumber);
            }
        } while (userGuess != correctNumber
            && userHasNotQuit);

        if (userHasNotQuit
            && userGuess == correctNumber)
        {
            Console.WriteLine("Congratulations!");
        }
        else // wrong answer!
        {
            Console.WriteLine("Maybe next time!");
        }
    }
}
