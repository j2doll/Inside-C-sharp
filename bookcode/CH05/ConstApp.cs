using System;

class MagicNumbers
{
	public const double pi;
	public const int answerToAllLifesQuestions = 42;
}

class ConstApp
{
	public static void Main()
	{
		Console.WriteLine("pi = {0}, everything else = {1}",
			MagicNumbers.pi, MagicNumbers.answerToAllLifesQuestions);
	}
}
