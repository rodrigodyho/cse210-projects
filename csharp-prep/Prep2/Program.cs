using System;

//It show the user if passed the course according to the grade.
class Program
{
  static void Main(string[] args)
  {
    Console.Write("What is your grade percentage? ");
    string userInput = Console.ReadLine();
    double gradePercent = double.Parse(userInput);

    string letter = "";

    if (gradePercent >= 90)
    {
      letter = "A";
    }
    else if (gradePercent >= 80)
    {
      letter = "B";
    }
    else if (gradePercent >= 70)
    {
      letter = "C";
    }
    else if (gradePercent >= 60)
    {
      letter = "D";
    }
    else
    {
      letter = "F";
    }

    Console.WriteLine($"Your letter grade to this course is: {letter}");

    if (gradePercent >= 70)
    {
      Console.WriteLine("Well done! You worked well and passed the course!");
    }
    else
    {
      Console.WriteLine("You did not passed the course. I know you can do it next time.");
    }
  }
}