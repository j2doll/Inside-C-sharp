using System;

class IfTestApp
{
    const int MAX = 10;

    public static void Main()
    {
        Console.Write("Guess a number between 1 and {0}...", MAX);
        string inputString = Console.ReadLine();
			
        int userGuess = inputString.ToInt32();

        Random rnd = new Random();
        double correctNumber = rnd.NextDouble() * MAX;
        correctNumber = Math.Round(correctNumber);

        Console.Write("The correct number was {0} and you guessed {1}...",
            correctNumber, userGuess);
        if (userGuess == correctNumber) // they got it right!
        {
            Console.WriteLine("Congratulations!");
        }
        else // wrong answer!
        {
            Console.WriteLine("maybe next time!");
        }
    }
}
