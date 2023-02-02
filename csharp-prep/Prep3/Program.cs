using System;

class Program
{
  static void Main(string[] args)
  {
    Random randomGenerator = new Random();
    bool playAgain = true;
    int guess;
    int magicNumber;
    int numberOfGuesses;
    string answer;

    while (playAgain)
    {
      guess = 0;
      numberOfGuesses = 0;
      answer = "";
      magicNumber = randomGenerator.Next(1, 101);

      while (guess != magicNumber)
      {
        Console.WriteLine("Guess a number between 1 and 100: ");
        guess = int.Parse(Console.ReadLine());
        Console.WriteLine("You chose the number: " + guess);

        if (guess > magicNumber)
        {
          Console.WriteLine(guess + ": this number is too high!");
        }
        else if (guess < magicNumber)
        {
          Console.WriteLine("The number " + guess + " is too low!");
        }
        numberOfGuesses++;
      }
      Console.WriteLine("");
      Console.WriteLine("Magic Number: " + magicNumber);
      Console.WriteLine("YOU WIN!");
      Console.WriteLine("Number of Guesses: " + numberOfGuesses);

      Console.WriteLine("Do you want to play again (y/n): ");
      answer = Console.ReadLine();

      if (answer == "y")
      {
        playAgain = true;
      }
      else
      {
        playAgain = false;
      }
    }

    Console.WriteLine("Thanks for playing!");

  }
}
