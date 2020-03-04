using System;
using System.Collections.Generic;
using Play.Models;

class Program
{
  static void Main()
  {
    StartGame();
  }

  public static void StartGame()
  {
    Console.WriteLine("Do you want to play in Rock, Paper, Scissors? Choose Y (for Yes) or N (for No)");
    string response = Console.Readline().toLower();
    if (response == "y")
    {
      SecondQuestion();
    }
    else if (response == "n")
    {
      Console.WriteLine("Sorry, that you decide to choose No. See you next time");
      System.Environment.Exit(0);
    }
    else
    {
      Console.WriteLine("Sorry, I don't understand. Please, choose from options above");
      StartGame();
    }
  }

  public static void SecondQuestion()
  {
    Console.WriteLine ("Do you want to play against player or against computer? Choose P (for Player) or C (for Computer)");
    string response = Console.Readline().toLower();
    if (response == "c")
    {
    }
    else if (response == "p")
    {
    }
    else
    {
      Console.WriteLine("Sorry, I don't understand. Please, choose from options above");
      SecondQuestion();
    }
  }

}
