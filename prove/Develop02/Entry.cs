using System;

//This class is responsable to all entry logic, including random prompt, 
//the current date and to save their response in a variable

public class Entry
{
  public string _entry;
  public string _prompt;
  public string _date;


  public void GetEntry()
  {
    Console.Write("> ");
    _entry = Console.ReadLine();
  }

  public void ShowPrompt()
  {
    List<string> promptsList = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most interesting thing you did today?",
        "Did you get to solve any problems/make anything cool/help anybody today?",
        "Is your work still challenging/rewarding to you?",
        "If you could change one thing about your day, what would it be?",
        "Have you learned anything new lately?",
        "Did you receive any good news today?",
        "What songs did you listen to today?"};

    Random rand = new Random();
    int randomIndex = rand.Next(promptsList.Count);
    _prompt = promptsList[randomIndex];
    Console.WriteLine(_prompt);
  }

  public void GetDate()
  {
    DateTime theCurrentTime = DateTime.Now;
    _date = theCurrentTime.ToShortDateString();
  }

}