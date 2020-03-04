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
      Console.WriteLine("Sorry, I don't understand. Please, choose from the available options.");
      StartGame();
    }
  }

  public static void SecondQuestion()
  {
    Console.WriteLine ("Do you want to play against player or against computer? Choose P (for Player) or C (for Computer)");
    string response = Console.Readline().toLower();
    if (response == "c")
    {
      Game.hasComputerPlayer = true;
      PlayerChoice(0);
      Game.ShowResult();
    }
    else if (response == "p")
    {
      int numberOfPlayers = 2;
      for (int i=0; i < numberOfPlayers; i++)
      {
        PlayerChoice(i);
      }
      Game.ShowResult();
    }
    else
    {
      Console.WriteLine("Sorry, I don't understand. Please, choose from the available options.");
      SecondQuestion();
    }
  }

  public static void PlayerChoice(int number)
  {
    Console.WriteLine($"Player {number+1}, what do you choose: Rock, Paper, or Scissors?");
    string playerChoice = Console.ReadLine().toLower();
    if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissors")
    {
      Game.AddPlayer(playerChoice);
    }
    else
    {
      Console.WriteLine("Sorry, I don't understand. Please, choose from the available options.");
      PlayerChoice(number);
    }
  }

}
